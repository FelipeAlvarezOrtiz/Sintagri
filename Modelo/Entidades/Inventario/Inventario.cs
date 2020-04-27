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

        public HashSet<Insumo> Insumos_Agricola { get; set; }
        
    }
}
