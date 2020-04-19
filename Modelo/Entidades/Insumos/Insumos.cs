using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sintagri.Modelo.Entidades.Insumos
{
    public enum Presentacion
    {
        Saco = 0,
        Envase = 1,
    }

    public abstract class Insumos
    {
        [Required, Key]
        protected private uint ID_Insumo;
        [Required, MaxLength(100)]
        protected private string Nombre_Comercial;
        [Required,Column("Presentacion",TypeName = "int")]
        public Presentacion Presentacion_Insumo { get; set; }
        public int Costo_Neto { get; set; }
        public int Costo_Total { get; set; }
        public string Manofacturera { get; set; }
        public string Proveedor { get; set; }
    }

}
