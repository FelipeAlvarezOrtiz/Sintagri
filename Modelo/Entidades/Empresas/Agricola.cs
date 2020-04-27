using Sintagri.Modelo.Entidades.Trabajadores;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sintagri.Modelo.Entidades.Empresas
{
    public class Agricola
    {
        [Key,Required,Column(TypeName = "int"),
            DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint ID_Agricola { get; set; }
        [Required,MaxLength(150)]
        public string Nombre_Fantasia { get; set; }
        [Required,MaxLength(25),Column("RUT_Empresa")]
        public string Rut_Empresa { get; set; }
        [Required,MaxLength(50)]
        public string Correo { get; set; }

        public ICollection<Contactos_Telefonicos> Contacto { get; set; }

        public ICollection<Unidad_Agricola> Propiedades_Agricolas { get; set; }

        public ICollection<Persona> Personal_Agricola { get; set; }
    }

    public class Contactos_Telefonicos
    {
        [MaxLength(25)]
        public string Numero_Telefonico { get; set; }
    }
}
