using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoMunicipalidad.Models
{
    public class Mantenimiento
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "La fecha de mantenimiento es obligatoria")]
        [Display(Name = "Fecha de Mantenimiento")]
        [DataType(DataType.Date)]
        public DateTime FechaMantenimiento { get; set; }

        [Required(ErrorMessage = "El tipo de mantenimiento es obligatorio")]
        [Display(Name = "Tipo de Mantenimiento")]
        public string TipoMantenimiento { get; set; }

        [Required(ErrorMessage = "El estado es obligatorio")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "El responsable es obligatorio")]
        public string Responsable { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        public string Descripcion { get; set; }

        // Relación con Equipo
        [Required(ErrorMessage = "Debe seleccionar un equipo")]
        public int EquipoId { get; set; }

        [ForeignKey("EquipoId")]
        public Equipo Equipo { get; set; }
    }
}