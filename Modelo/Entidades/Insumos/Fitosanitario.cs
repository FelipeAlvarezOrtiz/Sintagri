using Sintagri.Modelo.Entidades.Misc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sintagri.Modelo.Entidades
{
    public class Fitosanitario : Insumo
    {
        [MaxLength(100)]
        public string Etiqueta { get; set; }
        [Required,Column(TypeName = "int")]
        public int RegistroSAG { get; set; }

        public List<Ingrediente_Activo> Ingredientes { get; set; }
        public List<PFQ_Fitosanitario> Propiedades_Fitosanitarios { get; set; }
        [Required,MaxLength(50)]
        public string Modo_Accion { get; set; }

    }
}
