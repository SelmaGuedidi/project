

using Magasin.Models;
using Microsoft.EntityFrameworkCore;

namespace Magasin.Data.RUser
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly ProjectContext context;
        public UserRepository()
        {
            this.context = ProjectContext.Instance(); ;
        }
        public IEnumerable<User> getList()
        {
            return this.context.User.ToList();
        }
        public User getByID(int id)
        {
            return this.context.User.Find(id);
        }
    }
}
