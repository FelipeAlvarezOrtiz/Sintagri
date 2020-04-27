using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sintagri.Modelo.Entidades.Cultivos
{
    public enum Tipo_Cultivo
    {
        Hortaliza = 1,
        Frutal = 2,
    }

    public enum Formato_Cultivo
    {
        Semilla = 1,
        Plantula = 2,
        Arbol = 3,
    }

    public enum Proveedor
    {
        NA = 0,
        Invernadero = 1,
    }

    public class Cultivo
    {
        [Key, Required,
            DatabaseGenerated(DatabaseGeneratedOption.Identity)]]
        public int Id_Cultivo { get; set; }
        //Crear tabla Especie
        public int Especie { get; set; }
        [Column(TypeName = "smallint")]
        public Tipo_Cultivo Tipo { get; set; }
        [MaxLength(50)]
        public string Variedad { get; set; }
        [Column(TypeName = "decimal(8,3)")]
        public float Profundidad_Raiz_Minima{ get; set; }
        [Column(TypeName = "decimal(8,3)")]
        public float Profundidad_Raiz_Maxima { get; set; }
        public int Dias_Minimos_Cosecha { get; set; }
        public int Dias_Maximos_Cosecha { get; set; }
        [MaxLength(100)]
        public string Semillera { get; set; }
        [Column(TypeName ="smallint")]
        public Formato_Cultivo Formato { get; set; }
        [Column(TypeName ="smallint")]
        public Proveedor Proveedor { get; set; }

    }
}
