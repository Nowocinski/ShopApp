using DataAccessLayer.Context;
using DataAccessLayer.Models;
using DataAccessLayer.ViewModel;

namespace DataAccessLayer.Repositories
{
    public interface IUserRepository
    {
        UserViewModel LogIn(string email, string password);
    }

    public class UserRepository : IUserRepository
    {
        private readonly DataBaseContext context;
        public UserRepository()
        {
            this.context = DataBaseContext.Instance;
        }

        public UserViewModel LogIn(string email, string password)
        {
            Customer user = context.Customer
                .FirstOrDefault(x => x.Email == email && x.Password == password);

            if (user == null)
            {
                return null;
            }

            return new UserViewModel
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName
            };
        }
    }
}
