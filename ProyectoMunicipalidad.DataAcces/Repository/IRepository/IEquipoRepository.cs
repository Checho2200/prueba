using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoMunicipalidad.Models;

namespace ProyectoMunicipalidad.DataAcces.Repository.IRepository
{
    public interface IEquipoRepository : IRepository<Equipo>
    {
        void Update(Equipo equipo);
    }
}
