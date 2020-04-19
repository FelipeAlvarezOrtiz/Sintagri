using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sintagri.Modelo.Entidades.Misc
{
    public enum Dependencia
    {
        Hectarea = 1,
        Hectolitros = 2,
    }

    public class Ingrediente_Activo
    {
        [Required,Key]
        public int Id_Ingrediente { get; set; }
        [Required,MaxLength(100)]
        public string Nombre_Ingrediente { get; set; }
        [Required, MaxLength(100)]
        public string Grupo_Quimico { get; set; }
        [Required]
        public float Concentracion { get; set; }
        [Column("Dependencia",TypeName = "int")]
        public Dependencia Unidad_Dependencia { get; set; }

        public Ingrediente_Activo(int _idIngrediente,string _nombreIngrediente,
            string _grupoQuimico, float _concentracion)
        {
            Id_Ingrediente = _idIngrediente;
            Nombre_Ingrediente = _nombreIngrediente;
            Grupo_Quimico = _grupoQuimico;
            Concentracion = _concentracion;
        }

        public Dependencia Obtener_Dependencia(int _valorPreguntado) => _valorPreguntado == 1 ? Dependencia.Hectarea : Dependencia.Hectolitros;

        public int Obtener_Dependencia_ID() => (int)Unidad_Dependencia;


    }
}
