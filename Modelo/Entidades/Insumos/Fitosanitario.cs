using Sintagri.Modelo.Entidades.Misc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sintagri.Modelo.Entidades
{
    public class Fitosanitario : Insumo
    {
        [Required,Column(TypeName = "int")]
        public uint Prioridad { get; set; }
        [MaxLength(100)]
        public string Etiqueta { get; set; }
        [Required,Column(TypeName = "int")]
        public uint RegistroSAG { get; set; }

        public ICollection<Ingrediente_Activo> Ingredientes { get; set; }
        public ICollection<PFQ_Fitosanitario> Propiedades_Fitosanitarios { get; set; }
        [Required,MaxLength(50)]
        public string Modo_Accion { get; set; }

    }
}
