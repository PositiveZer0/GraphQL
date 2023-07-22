using GraphQL.Application.Interfaces;
using GraphQL.Domain;

namespace GraphQL.Application.Services;

public class UserService : IUserService
{
    private ApplicationDbContext db;

    public UserService(ApplicationDbContext db)
    {
        this.db = db;
    }

    public bool IsAuthenticatedToLogIn(string email, string password)
    {
        var user = db.Users.FirstOrDefault(x => x.Email == email);


        if (user == null)
        {
            return false;
        }

        if (user.Password != password)
        {
            return false;
        }

        return true;
    }
}
