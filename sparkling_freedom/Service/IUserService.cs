using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sparkling_freedom.Model;

namespace sparkling_freedom.Service
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAll();

        Task<User?> GetById(long id);

        Task<User?> GetByUsuario(string usuario);

        Task<User?> Create(User usuario);

        Task<User?> Update(User usuario);
    }
}