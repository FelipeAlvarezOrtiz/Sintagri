using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sintagri.Modelo.Entidades
{
    public enum Dependencia
    {
        Hectarea = 1,
        Hectolitros = 2,
    }

    public class Ingrediente_Activo
    {
        [Required,Key,Column(TypeName ="int"),
            DatabaseGenerated(DatabaseGeneratedOption.Identity)]]
        public int Id_Ingrediente { get; set; }
        [Required,MaxLength(100)]
        public string Nombre_Ingrediente { get; set; }
        [Required, MaxLength(100)]
        public string Grupo_Quimico { get; set; }
        [Required,Column(TypeName = "decimal(5,2)")]
        public float Concentracion { get; set; }
        [Column("Dependencia",TypeName = "int")]
        public Dependencia Unidad_Dependencia { get; set; }

        [ForeignKey("Insumo_Asociado")]
        public uint ID_Insumo { get; set; }
        public Fitosanitario Insumo { get; set; }

        public Dependencia Obtener_Dependencia(int _valorPreguntado) => _valorPreguntado == 1 ? Dependencia.Hectarea : Dependencia.Hectolitros;

        public int Obtener_Dependencia_ID() => (int)Unidad_Dependencia;


    }
}
