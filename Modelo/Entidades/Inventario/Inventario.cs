using Sintagri.Modelo.Entidades.Empresas;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sintagri.Modelo.Entidades.Inventario
{
    public class Inventario
    {
        [Key,Required,DatabaseGenerated(DatabaseGeneratedOption.Identity),
            Column(TypeName = "int")]
        public uint ID_Inventario { get; set; }
        [Key,Required]
        public Agricola Agricola { get; set; }

        public List<Relacion_Inventario_Productos> Insumos_Agricola { get; set; }

    }

    public class Relacion_Inventario_Productos
    {
        public uint ID_Inventario { get; set; }
        public Inventario Inventario { get; set; }
        public uint ID_Insumo { get; set; }
        public Insumo Insumo { get; set; }

        [Required,Column(TypeName = "int")]
        public uint Cantidad { get; set; }
    }
}
