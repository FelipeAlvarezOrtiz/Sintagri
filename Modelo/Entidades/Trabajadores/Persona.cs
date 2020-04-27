using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sintagri.Modelo.Entidades.Trabajadores
{
    public abstract class Persona
    {
        [Key, Required, Column("RUT_Trabajador")]
        public int ID_Trabajador { get; set; }
        [Required,MaxLength(100)]
        public string Nombres { get; set; }
        [Required,MaxLength(30)]
        public string Apellido_Paterno { get; set; }
        [Required,MaxLength(30)]
        public string Apellido_Materno { get; set; }
        [MaxLength(200)]
        public string Direccion { get; set; }
        [MaxLength(100)]
        public string Comuna { get; set; }
        [MaxLength(100)]
        public string Region { get; set; }
        [MaxLength(150)]
        public string Nacionalidad { get; set; }
        [MaxLength(20)]
        public string Numero_Contacto_Principal { get; set; }
        [MaxLength(20)]
        public string Numero_Contacto_Emergencia { get; set; }
        [MaxLength(50)]
        public string Correo { get; set; }
  
        public Roles Rol { get; set; }
    }
}
