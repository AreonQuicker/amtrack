using Amtrack.Amtrack.Data;
using Amtrack.Amtrack_V2.Data;
using Amtrack.StockCheck.Data;

namespace Amtrack.Core.Repositories
{
	public interface ICoreRepository
	{
		AmtrackV2Context AmtrackV2Context { get; }
		AmtrackContext AmtrackContext { get; }
		AmtrackStockCheckContext AmtrackStockCheckContext { get; }
	}
}
