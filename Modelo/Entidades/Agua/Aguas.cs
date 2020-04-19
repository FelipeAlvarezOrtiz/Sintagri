using Sintagri.Modelo.Entidades.Misc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sintagri.Modelo.Entidades.Agua
{
    public enum Origen_Agua
    {
        Pozo = 1,
        Canal = 2,
        Mezcla = 3,
    }

    public class Aguas
    {
        [Required,Key]
        public int Id_Agua { get; set; }
        [Required, Column("Origen",TypeName = "int")]
        public Origen_Agua Origen { get; set; }
        [MaxLength(50)]
        public string Nombre_Referencia { get; set; }
        public List<PFQ> Propiedades { get; set; }

        public Aguas(int _idAgua, Origen_Agua _origen,string _nombreReferencia)
        {
            Id_Agua = _idAgua;
            Origen = _origen;
            Nombre_Referencia = _nombreReferencia;
            Propiedades = new List<PFQ>();
        }

        public Aguas(int _idAgua, Origen_Agua _origen, string _nombreReferencia,
            List<PFQ> _propiedades)
        {
            Id_Agua = _idAgua;
            Origen = _origen;
            Nombre_Referencia = _nombreReferencia;
            Propiedades = _propiedades;
        }

    }
}
