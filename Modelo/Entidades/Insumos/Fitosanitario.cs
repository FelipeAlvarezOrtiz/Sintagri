using Sintagri.Modelo.Entidades.Misc;
using System.Collections.Generic;

namespace Sintagri.Modelo.Entidades.Insumos
{
    public class Fitosanitario : Insumos
    {
        public int ID_Fitosanitario { get; set; }
        public int Prioridad { get; set; }
        public string Etiqueta { get; set; }
        public int RegistroSAG { get; set; }
        public List<Ingrediente_Activo> Ingredientes { get; set; }
        public string Modo_Accion { get; set; }

        public Fitosanitario(int _idFitosanitario,string _nombreComercial, Presentacion _presentacionInsumo,
            int _costoNeto,int _costoTotal,string _manoFacturera,string _proveedor,
            int _prioridad,string _etiqueta,int _registroSag,List<Ingrediente_Activo> _ingredientes,
            string _modoAccion)
        {

        }

    }
}
