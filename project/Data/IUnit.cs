using Magasin.Data.RCategory;


using Magasin.Data.RProduct;
using Magasin.Data.RStock;

using Magasin.Data.RUser;
using Magasin.Data.RVendor;

namespace Magasin.Data
{
    public interface IUnit : IDisposable
    {
        public ICategoryRepository Category { get;  } 

       
        
        public IProductRepository Product { get; }
        public IStockRepository Stock { get; }
        
        public IUserRepository User { get; }
        public IVendorRepository Vendor { get; }
        bool complete();
    }
}
