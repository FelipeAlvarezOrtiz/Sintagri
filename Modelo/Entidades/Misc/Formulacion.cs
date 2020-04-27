using System.ComponentModel.DataAnnotations;

namespace Sintagri.Modelo.Entidades.Misc
{
    public class Formulacion
    {
        [Key,Required,
            DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Formulacion { get; set; }
        [Required,MaxLength(50)]
        public string Nombre_Formulacion { get; set; }
        public int Sub_Prioridad { get; set; }
    }
}
