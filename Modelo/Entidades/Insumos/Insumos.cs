namespace Sintagri.Modelo.Entidades.Insumos
{
    public enum Presentacion
    {
        Saco = 1,
        Envase = 2,
    }

    public class Insumos
    {
        public string Nombre_Comercial { get; set; }
        public Presentacion Presentacion_Insumo { get; set; }
        public int Costo_Neto { get; set; }
        public int Costo_Total { get; set; }
        public string Manofacturera { get; set; }
        public string Proveedor { get; set; }
    }

}
