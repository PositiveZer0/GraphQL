namespace GraphQL.Application.Interfaces;

public interface IUserService
{
    bool IsAuthenticatedToLogIn(string username, string password);
}
