using Sintagri.Modelo.Entidades.Cultivos;
using Sintagri.Modelo.Entidades.Empresas;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sintagri.Modelo.Entidades
{
    public abstract class Unidad_Agricola
    {
        [Required, Key,
            DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint ID { get; set; }
        [Required, MaxLength(35)]
        public string Nombre { get; set; }
        [Required, Column("Superficie", TypeName = "decimal(15,3")]
        public uint Superficie_Hectareas { get; set; }
        
        public Agricola Empresa_Propietaria { get; set; }
    }
    
    public class Predio : Unidad_Agricola
    {
        public ICollection<Potreros> Potreros { get; set; }
    }

    public class Potreros : Unidad_Agricola
    {
        public Predio Predio_Pertenenciente { get; set; }
        public ICollection<Sectores> Sectores { get; set; }
    }

    public class Sectores : Unidad_Agricola
    {
        public Potreros Potrero_perteneciente { get; set; }
        public ICollection<Valvulas> Valvulas { get; set; }
    }

    public class Valvulas : Unidad_Agricola
    {
        public Sectores Sector { get; set; }
        public Cultivo Cultivo_Actual { get; set; }
        public Aguas Origen_Riego { get; set; }
    }
}
