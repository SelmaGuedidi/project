
using Magasin.Models;

namespace Magasin.Data.RProduct { 
    public class ProductRepository :  Repository<Product>, IProductRepository
    {
        private readonly ProjectContext context;
        public ProductRepository()
        {
            this.context = ProjectContext.Instance(); ;
        }
    }
}
