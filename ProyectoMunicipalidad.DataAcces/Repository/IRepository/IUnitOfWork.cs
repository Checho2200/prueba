using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMunicipalidad.DataAcces.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IEquipoRepository Equipo { get; }
        IMantenimientoRepository Mantenimiento { get; }
        void Save();
    }
}
