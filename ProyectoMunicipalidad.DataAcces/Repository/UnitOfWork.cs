using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoMunicipalidad.DataAcces.Datos;
using ProyectoMunicipalidad.DataAcces.Repository.IRepository;
using ProyectoMunicipalidad.Models;

namespace ProyectoMunicipalidad.DataAcces.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Equipo = new EquipoRepository(_context);
            Mantenimiento = new MantenimientoRepository(_context);
        }

        public IEquipoRepository Equipo { get; private set; }

        public IMantenimientoRepository Mantenimiento { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
