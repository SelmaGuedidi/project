using Magasin.Data;
using Magasin.Data.RCategory;


using Magasin.Data.RProduct;
using Magasin.Data.RStock;

using Magasin.Data.RUser;
using Magasin.Data.RVendor;
using Magasin.Models;

namespace Magasin.Data
{
    public class Unit : IUnit
    {
        private readonly ProjectContext _Context;
        public ICategoryRepository Category { get; private set; } 

       
       
        public IProductRepository Product { get; private set; }
        public IStockRepository Stock { get; private set; }
        
        public IUserRepository User { get; private set; }
        public IVendorRepository Vendor { get; private set; }

        public Unit()
        {
            this._Context = ProjectContext.Instance(); 
            Category = new CategoryRepository();
           
            Product = new ProductRepository();
            Stock = new StockRepository();
            
            User = new UserRepository();
            Vendor = new VendorRepository();
             

        }
    public bool complete()
    {

        try
        {
            int result = _Context.SaveChanges();
            if (result > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public void Dispose()
    {
        _Context.Dispose();
    }
}
} 