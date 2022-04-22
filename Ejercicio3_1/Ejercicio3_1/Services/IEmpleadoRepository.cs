using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ejercicio3_1.Models;

namespace Ejercicio3_1.Services
{
    public interface IEmpleadoRepository
    {
        Task<bool> AddEmpleadoAsync(EmpleadoInfo empleadoInfo);
        Task<bool> UpdateEmpleadoAsync(EmpleadoInfo empleadoInfo);
        Task<bool> DeteleEmpleadoAsync(int id);
        Task<EmpleadoInfo> GetEmpleadoAsync(int id);
        Task<IEnumerable<EmpleadoInfo>> GetEmpleadosAsync();
    }
}
