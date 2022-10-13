using CrudJWT.Models;

namespace CrudJWT.Services
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}
