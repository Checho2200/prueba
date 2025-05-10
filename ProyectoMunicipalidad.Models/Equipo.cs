using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoMunicipalidad.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre o descripcion del equipo es obligatoria.")]
        [StringLength(250)]
        public string Nombre { get; set; } // Ej: "Impresora láser multifunción HP"


        [StringLength(100)]
        public string? Marca { get; set; }

        [StringLength(100)]
        public string? Modelo { get; set; }

        [Required(ErrorMessage = "Fecha de registro en area de informatica")]
        [DataType(DataType.Date)]
        public DateTime FechaAdquisicion { get; set; }

        [Required(ErrorMessage = "El estado del equipo es obligatorio.")]
        [StringLength(50)]
        public string Estado { get; set; } // Ej: "Operativo", "En mantenimiento", "Fuera de servicio"

        [Required(ErrorMessage = "La ubicación del equipo es obligatoria.")]
        [StringLength(100)]
        public string Ubicacion { get; set; } // Ej: "Oficina de Finanzas - Segundo Piso"

        [Required(ErrorMessage = "Registrar el encargado de la maquina")]
        [StringLength(100)]
        public string Responsable { get; set; } // Persona encargada o usuaria del equipo

        //relacion con el mantenimiento
        public ICollection<Mantenimiento>? Mantenimientos { get; set; }
    }
}
