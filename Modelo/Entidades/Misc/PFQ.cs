namespace Sintagri.Modelo.Entidades.Misc
{
    //Propiedades Fisico-Quimicas
    public class PFQ
    {
        public int Id_PFQ { get; set; }
        public string Nombre { get; set; }
        public float Valor_PFQ { get; set; }
        public string Unidad_Medida { get; set; }
        public string Categoria { get; set; }

        public PFQ(int _idPFQ,string _nombre,float _valorPFQ,string _unidadMedida,string _categoria)
        {
            Id_PFQ = _idPFQ;
            Nombre = _nombre;
            Valor_PFQ = _valorPFQ;
            Unidad_Medida = _unidadMedida;
            Categoria = _categoria;
        }



    }
}
