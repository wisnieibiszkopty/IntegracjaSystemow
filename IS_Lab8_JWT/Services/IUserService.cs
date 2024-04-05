using IS_Lab8_JWT.Entities;
using IS_Lab8_JWT.Model;

namespace IS_Lab8_JWT.Services;

public interface IUserService
{
    AuthenticationResponse Authenticate(AuthenticationRequest request);
    IEnumerable<User> GetUsers();
    User GetByUsername(string username);
    User GetById(int id);
}