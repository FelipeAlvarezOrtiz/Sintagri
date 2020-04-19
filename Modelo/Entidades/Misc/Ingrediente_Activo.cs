namespace Sintagri.Modelo.Entidades.Misc
{
    public enum Dependencia
    {
        Hectarea = 1,
        Hectolitros = 2,
    }

    public class Ingrediente_Activo
    {
        public int Id_Ingrediente { get; set; }
        public string Nombre_Ingrediente { get; set; }
        public string Grupo_Quimico { get; set; }
        public float Concentracion { get; set; }
        public Dependencia Unidad_Dependencia { get; set; }

        public Ingrediente_Activo(int _idIngrediente,string _nombreIngrediente,
            string _grupoQquimico, float _concentracion)
        {
            Id_Ingrediente = _idIngrediente;
            Nombre_Ingrediente = _nombreIngrediente;
            Grupo_Quimico = _grupoQquimico;
            Concentracion = _concentracion;
        }

        public Dependencia Obtener_Dependencia(int _valorPreguntado)
        {
            return _valorPreguntado == 1 ? Dependencia.Hectarea : Dependencia.Hectolitros;
        }

        public int Obtener_Dependencia_ID()
        {
            return (int)Unidad_Dependencia;
        }


    }
}
