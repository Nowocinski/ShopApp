using DataAccessLayer.Context;
using DataAccessLayer.Models;
using DataAccessLayer.ViewModel;

namespace DataAccessLayer.Repositories
{
    public interface IUserRepository
    {
        UserViewModel LogIn(string email, string password);
        void Add(string email, string password, string firstname, string lastname);
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

        public void Add(string email, string password, string firstname, string lastname)
        {
            Customer user = new Customer()
            {
                Id = Guid.NewGuid(),
                FirstName = firstname,
                LastName = lastname,
                Password = password,
                Email = email

            };
            context.Customer.Add(user);
            context.SaveChanges();
        }
    }
}
