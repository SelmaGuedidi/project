
using Magasin.Models;

namespace Magasin.Data.RUser
{
    public interface IUserRepository : IRepository<User>
    {
        public IEnumerable<User> getList();
        public User  getByID(int id);
    }
}
