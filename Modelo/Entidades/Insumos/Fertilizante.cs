using Sintagri.Modelo.Entidades.Misc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sintagri.Modelo.Entidades
{
    public enum Tipo
    {
        Granulado = 1,
        Soluble = 2,
        Liquido = 3,
        Gel = 4,
    }
    public class Fertilizante : Insumo
    {
        [Required,Column(TypeName = "tinyint")]
        public Tipo Tipo_Formulacion { get; set; }
        
        public List<PFQ_Fertilizante> Propiedades_Fertilizante { get; set; }
        
    }
}
