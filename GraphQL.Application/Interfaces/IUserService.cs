using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.Application.Interfaces
{
    public interface IUserService
    {
        bool IsAuthenticatedToLogIn(string username, string password);
    }
}
