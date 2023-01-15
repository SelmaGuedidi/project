

using Magasin.Models;

namespace Magasin.Data.RStock
{
    public class StockRepository : Repository<Stock>, IStockRepository
    {
        private readonly ProjectContext context;
        public StockRepository()
        {
            this.context = ProjectContext.Instance(); ;
        }
    }
}
