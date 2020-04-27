using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sintagri.Modelo.Entidades.Misc
{
    //Propiedades Fisico-Quimicas
    public abstract class PFQ
    {
        [Required, Key, Column(TypeName = "int"),
            DatabaseGenerated(DatabaseGeneratedOption.Identity)]]
        public int Id_PFQ { get; set; }
        [MaxLength(50)]
        public string Nombre { get; set; }
        [Column("Valor")]
        public float Valor_PFQ { get; set; }
        [MaxLength(10)]
        public string Unidad_Medida { get; set; }
        [MaxLength(35)]
        public string Categoria { get; set; }
    }

    public class PFQ_Fertilizante : PFQ
    {
        public uint ID_Insumo { get; set; }
        public Fertilizante Fertilizante { get; set; }
    }

    public class PFQ_Agua : PFQ
    {
        //public int Id_Agua { get; set; }
        public Aguas Agua { get; set; }
    }

    public class PFQ_Fitosanitario : PFQ
    {
        public Fitosanitario Fitosanitario { get; set; }
    }
}
