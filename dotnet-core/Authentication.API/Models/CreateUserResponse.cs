using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.API.Models
{
    public class CreateUserResponse
    {
        public long UserId { get; set; }

        public string Message { get; set; }
    }
}
