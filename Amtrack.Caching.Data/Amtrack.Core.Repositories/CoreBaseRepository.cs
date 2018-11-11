using System;
using Amtrack.Amtrack.Data;
using Amtrack.Amtrack_V2.Data;
using Amtrack.StockCheck.Data;

namespace Amtrack.Core.Repositories
{
    public abstract class CoreBaseRepository : ICoreRepository, IDisposable
    {
        protected CoreBaseRepository(Amtrack_V2.Data.AmtrackV2Context amtrackV2Context,
            Amtrack.Data.AmtrackContext amtrackContext,
            AmtrackStockCheckContext amtrackStockCheckContext)
        {
            AmtrackV2Context = amtrackV2Context;
            AmtrackContext = amtrackContext;
            AmtrackStockCheckContext = amtrackStockCheckContext;
        }

        /// <inheritdoc />
        public AmtrackV2Context AmtrackV2Context { get; }

        /// <inheritdoc />
        public AmtrackContext AmtrackContext { get; }

        /// <inheritdoc />
        public AmtrackStockCheckContext AmtrackStockCheckContext { get; }

        public virtual void Dispose()
        {
            if(AmtrackContext != null)
            {
                AmtrackContext.Dispose();
            }

            if(AmtrackV2Context != null)
            {
                AmtrackV2Context.Dispose();
            }

            if(AmtrackStockCheckContext != null)
            {
                AmtrackStockCheckContext.Dispose();
            }

        }
    }
}
