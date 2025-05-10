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
    public class EquipoRepository : Repository<Equipo>, IEquipoRepository
    {
        private readonly ApplicationDbContext _context;
        public EquipoRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public void Update(Equipo equipo)

            {
            var objDesdeBd = _context.Equipos.FirstOrDefault(e => e.Id == equipo.Id);
            objDesdeBd.Nombre = equipo.Nombre;
            objDesdeBd.Marca = equipo.Marca;
            objDesdeBd.Modelo = equipo.Modelo;
            objDesdeBd.FechaAdquisicion = equipo.FechaAdquisicion;
            objDesdeBd.Estado = equipo.Estado;
            objDesdeBd.Ubicacion = equipo.Ubicacion;
            objDesdeBd.Responsable = equipo.Responsable;
        }
        }
    }