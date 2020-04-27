
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sintagri.Modelo.Entidades.Trabajadores
{
    public class Roles
    {
        [Key,Required,DatabaseGenerated(DatabaseGeneratedOption.Identity),
            Column(TypeName ="int")]
        public uint ID_Rol { get; set; }

        [MaxLength(50),Required]
        public string Nombre_Rol { get; set; }
    }
}
