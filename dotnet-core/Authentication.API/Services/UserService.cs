using Authentication.API.Contract;
using Authentication.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.API.Services
{
    public class UserService : IUserService
    {
        public CreateUserResponse AddUser(User user)
        {
            CreateUserResponse createUserResponse = new CreateUserResponse();
            return createUserResponse;
        }
    }
}
