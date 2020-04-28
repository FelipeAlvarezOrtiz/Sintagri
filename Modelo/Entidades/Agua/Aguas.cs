using Sintagri.Modelo.Entidades.Misc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sintagri.Modelo.Entidades
{
    public enum Origen_Agua
    {
        Pozo = 1,
        Canal = 2,
        Mezcla = 3,
    }
    public class Aguas
    {
        [Key,Required,
            DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Agua { get; set; }
        [Required,Column("Origen")]
        public Origen_Agua Origen { get; set; }
        [MaxLength(50),Column("Nombre")]
        public string Nombre_Referencia { get; set; }

        //Relación 1 a Muchos
        public List<PFQ_Agua> Propiedades_Agua { get; set; }

    }
}
