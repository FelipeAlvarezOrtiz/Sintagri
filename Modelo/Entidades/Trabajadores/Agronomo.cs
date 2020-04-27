using Sintagri.Modelo.Entidades.Empresas;
using Sintagri.Modelo.Session;

namespace Sintagri.Modelo.Entidades.Trabajadores
{
    public class Agronomo : Persona, IAgronomo
    {
        public Agricola Agricola_Pertenenciente { get; set; }

        public void AbrirNuevaOrden()
        {
            throw new System.NotImplementedException();
        }

        public void ModificarInsumo()
        {
            throw new System.NotImplementedException();
        }

        public string Obtener_LugarDeTrabajo()
        {
            return Agricola_Pertenenciente.Nombre_Fantasia;
        }
        
        public string Obtener_Cargo()
        {
            return "Agronomo";
        }
        public uint Obtener_ID_Empresa()
        {
            return Agricola_Pertenenciente.ID_Agricola;
        }
        public uint Obtener_ID_Cargo()
        {
            return 1;
        }
    }
}
