using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoMunicipalidad.DataAcces.Repository.IRepository;
using ProyectoMunicipalidad.DataAcces.Datos;
using ProyectoMunicipalidad.DataAcces.Repository.IRepository;
using ProyectoMunicipalidad.Models;

namespace ProyectoMunicipalidad.DataAcces.Repository
{
    public class MantenimientoRepository : Repository<Mantenimiento>, IMantenimientoRepository
    {
        private readonly ApplicationDbContext _context;

        public MantenimientoRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public void Update(Mantenimiento mantenimiento)

        {
            var objDesdeBd = _context.Mantenimientos.FirstOrDefault(m => m.Id == mantenimiento.Id);
            objDesdeBd.FechaMantenimiento = mantenimiento.FechaMantenimiento;
            objDesdeBd.TipoMantenimiento = mantenimiento.TipoMantenimiento;
            objDesdeBd.Estado = mantenimiento.Estado;
            objDesdeBd.Responsable = mantenimiento.Responsable;
            objDesdeBd.Descripcion = mantenimiento.Descripcion;
            objDesdeBd.EquipoId = mantenimiento.EquipoId;

        }
    }
}