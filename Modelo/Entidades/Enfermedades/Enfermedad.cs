using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sintagri.Modelo.Entidades.Enfermedades
{
    public enum Epoca_Aparicion
    {
        Otoño = 1,
        Invierno = 2,
        Primavera = 3,
        Verano = 4,
        Año_Completo = 5,
    }

    public class Enfermedad
    {
        [Key,Required,Column(TypeName = "int"),
            DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint ID_Enfermedad { get; set; }
        [MaxLength(100)]
        public string Nombre_Comun { get; set; }
        [MaxLength(100)]
        public string Nombre_Cientifico { get; set; }
        [Column("Epoca_Aparicion",TypeName =("tinyint"))]
        public Epoca_Aparicion Aparicion { get; set; }

    }
}
