using Authentication.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.API.Contract
{
    public interface IUserService
    {
        CreateUserResponse AddUser(User user);
    }
}
