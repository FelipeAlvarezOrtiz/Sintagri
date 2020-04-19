namespace Sintagri.Modelo.Entidades.Misc
{
    public class Formulacion
    {
        public int Id_Formulacion { get; set; }
        public string Nombre_Formulacion { get; set; }
        public int Sub_Prioridad { get; set; }

        public Formulacion(int _id,string _nombre, int _subPrioridad)
        {
            Id_Formulacion = _id;
            Nombre_Formulacion = _nombre;
            Sub_Prioridad = _subPrioridad;
        }
    }
}
