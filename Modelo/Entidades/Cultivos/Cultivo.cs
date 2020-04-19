using System;

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
        public int IdCultivo { get; set; }
        //Crear tabla Especie
        public int Especie { get; set; }
        public Tipo_Cultivo Tipo { get; set; }
        public string Variedad { get; set; }
        public Tuple<float,float> Profundidad_Raiz { get; set; }
        public Tuple<int,int> Dias_Cosecha { get; set; }
        public string Semillera { get; set; }
        public Formato_Cultivo Formato { get; set; }
        public Proveedor Proveedor { get; set; }

        public Cultivo(int _idCultivo, int _especie, Tipo_Cultivo _tipo,
            string _variedad, Tuple<float,float> _profundidadRaiz,Tuple<int,int> _cosecha,
            string _semillera,Formato_Cultivo _formato, Proveedor _proveedor)
        {
            IdCultivo = _idCultivo;
            Especie = _especie;
            Tipo = _tipo;
            Variedad = _variedad;
            Profundidad_Raiz = _profundidadRaiz;
            Dias_Cosecha = _cosecha;
            Semillera = _semillera;
            Formato = _formato;
            Proveedor = _proveedor;
        }

        public bool Validar_Tamanos_Raiz(Tuple<float,float> ProfundidadRaiz)
        {
            return (ProfundidadRaiz.Item1 < ProfundidadRaiz.Item2) ? true : false;
        }

        public bool Validar_Dias_Cosecha(Tuple<int,int> DiasCosecha)
        {
            return DiasCosecha.Item1 < DiasCosecha.Item2 ? true : false;
        }

    }
}
