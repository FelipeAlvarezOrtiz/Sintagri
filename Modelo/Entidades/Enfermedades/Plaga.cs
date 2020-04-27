using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sintagri.Modelo.Entidades.Enfermedades
{
    public class Plaga
    {
        [Key, Required,
            Column(TypeName = "int"),
            DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint ID_Enfermedad { get; set; }
        [MaxLength(100)]
        public string Nombre_Comun { get; set; }
        [MaxLength(100)]
        public string Nombre_Cientifico { get; set; }
        [Column("Epoca_Aparicion", TypeName = ("tinyint"))]
        public Epoca_Aparicion Aparicion { get; set; }

    }

    //Estado es una relación muchos a muchos con los reportes
    public class Estado
    {
        [Key, Required, Column(TypeName = "smallint"),
            DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint ID_Estado { get; set; }
        [MaxLength(50)]
        public string Nombre { get; set; }

    }
}
