//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormularioCuestionario.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Cuestionarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cuestionarios()
        {
            this.Finalizado = false;
            this.Referidos = new HashSet<Referidos>();
        }
    
        public int IdCuestionario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public int Ciudad { get; set; }
        public int Capacitación { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        [EmailAddress(ErrorMessage = "Email Invalido")]
        public string EMail { get; set; }
        public string Teléfono { get; set; }
        [Range(1, 100)]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int AsesoramientoInscripcion { get; set; }
        [Range(1, 100)]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int SalónEquipamiento { get; set; }
        [Range(1, 100)]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int Contenidos { get; set; }
        [Range(1, 100)]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int IstructorConocimiento { get; set; }
        [Range(1, 100)]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int InstructorClaridad { get; set; }
        [Range(1, 100)]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int InstructorTrato { get; set; }
        [Range(1, 100)]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int ConocimientoAdquirido { get; set; }
        [Range(1, 100)]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int Utilidad { get; set; }
        [Range(1, 100)]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int SatisfacciónGral { get; set; }
        public bool HariaOtro { get; set; }
        public string Cual { get; set; }
        [Range(1, 100)]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int Metodologia { get; set; }
        [Range(1, 100)]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int Material { get; set; }
        [Range(1, 100)]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int Duración { get; set; }
        [Range(1, 100)]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int Predisposicion { get; set; }
        [Range(1, 100)]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int Ejercicios { get; set; }
        [Range(1, 100)]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int TratoAdministrativo { get; set; }
        public string Sugerencias { get; set; }
        public System.DateTime FechaHora { get; set; }
        public bool Finalizado { get; set; }
    
        public virtual Capacitaciones Capacitaciones { get; set; }
        public virtual Ciudades Ciudades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Referidos> Referidos { get; set; }
    }
}
