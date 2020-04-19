using Sintagri.Modelo.Entidades.Misc;
using System.Collections.Generic;

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
        public int IdAgua { get; set; }
        public Origen_Agua Origen { get; set; }
        public string Nombre_Referencia { get; set; }
        public List<PFQ> Propiedades { get; set; }

        public Aguas(int _idAgua, Origen_Agua _origen,string _nombreReferencia)
        {
            IdAgua = _idAgua;
            Origen = _origen;
            Nombre_Referencia = _nombreReferencia;
            Propiedades = new List<PFQ>();
        }

        public Aguas(int _idAgua, Origen_Agua _origen, string _nombreReferencia,
            List<PFQ> _propiedades)
        {
            IdAgua = _idAgua;
            Origen = _origen;
            Nombre_Referencia = _nombreReferencia;
            Propiedades = _propiedades;
        }

    }
}
