using Sintagri.Modelo.Entidades.Inventario;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

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
            DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Insumo { get; set; }
        [Required, MaxLength(100)]
        public string Nombre_Comercial { get; set; }
        [Required, Column("Presentacion", TypeName = "tinyint")]
        public Presentacion Presentacion_Insumo { get; set; }
        [Column(TypeName = "int")]
        public int Costo_Neto { get; set; }
        [Column(TypeName = "int")]
        public int Costo_Total { get; set; }
        [MaxLength(100)]
        public string Manofacturera { get; set; }
        [MaxLength(100)]
        public string Proveedor { get; set; }
        [Required]
        public int Prioridad { get; set; }
        [Required]
        public int Subprioridad { get; set; }

        public IQueryable<Relacion_Inventario_Productos> Insumos_Agricola { get; set; }
 
    }

}
