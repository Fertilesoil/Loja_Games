using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sparkling_freedom.Model;

namespace sparkling_freedom.Security
{
    public interface IAuthService
    {
        Task<UserLogin?> Autenticar(UserLogin userLogin);
    }
}