using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sintagri.Modelo.Entidades
{
    public enum Presentacion
    {
        Saco = 0,
        Envase = 1,
    }

    public abstract class Insumo
    {
        [Required, Key, Column(TypeName = "int"),
            DatabaseGenerated(DatabaseGeneratedOption.Identity)]]
        public uint ID_Insumo { get; set; }
        [Required, MaxLength(100)]
        public string Nombre_Comercial;
        [Required, Column("Presentacion", TypeName = "tinyint")]
        public Presentacion Presentacion_Insumo { get; set; }
        [Column(TypeName = "int")]
        public uint Costo_Neto { get; set; }
        [Column(TypeName = "int")]
        public uint Costo_Total { get; set; }
        [MaxLength(100)]
        public string Manofacturera { get; set; }
        [MaxLength(100)]
        public string Proveedor { get; set; }
    }

}
