using GraphQL.Application.Interfaces;
using GraphQL.Domain.Entities;

namespace GraphQL.Backend;

public class Query
{
    public string Instructions => "Hello, GraphQL";

    public bool IsAuthenticatedToLogIn([Service]IUserService userService, string email, string password)
    {
        return userService.IsAuthenticatedToLogIn(email, password);
    }
}
