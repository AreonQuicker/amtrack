using System;
using System.Linq;
using Amtrack.Data_V2.Data;
using Amtrack.Services.Users;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Amtrack.API
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			//services.AddMemoryCache();

			services.AddResponseCaching(options =>
			{
				options.UseCaseSensitivePaths = true;
				options.MaximumBodySize = 1024;
			});

			services.AddMvc(setupAction =>
			{
				setupAction.ReturnHttpNotAcceptable = true;
				setupAction.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter());

				var jsonInputFormatter = setupAction.InputFormatters
				.OfType<JsonInputFormatter>().FirstOrDefault();

			});

			var connectionString = Configuration["connectionStrings:AmtrackDB_V2"];
			services.AddDbContext<AmtrackMainContext>(o => o.UseSqlServer(connectionString));

			services.AddScoped<IUsersController, UsersController>();

			services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();

			services.AddScoped<IUrlHelper>(implementationFactory =>
			{
				var actionContext = implementationFactory.GetService<IActionContextAccessor>()
				.ActionContext;
				return new UrlHelper(actionContext);
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if(env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseHsts();
			}

			AutoMapper.Mapper.Initialize(cfg =>
			{
				cfg.CreateMap<Users, Amtrack.ValueObjects.Users.UserVO>()
				 .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Username))
				 .ForMember(dest => dest.Flags, opt => opt.Ignore())
				 .ForMember(dest => dest.Status, opt => opt.Ignore());
			});

			app.UseHttpsRedirection();

			app.UseResponseCaching();

			app.Use(async (context, next) =>
			{
				context.Response.GetTypedHeaders().CacheControl =
					new Microsoft.Net.Http.Headers.CacheControlHeaderValue()
					{
						Public = true,
						MaxAge = TimeSpan.FromSeconds(10)
					};
				context.Response.Headers[Microsoft.Net.Http.Headers.HeaderNames.Vary] =
					new string[] { "Accept-Encoding" };

				await next();
			});

			app.UseMvc();
		}
	}
}
