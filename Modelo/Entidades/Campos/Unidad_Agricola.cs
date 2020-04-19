using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sintagri.Modelo.Entidades.Campos
{
    public abstract class Unidad_Agricola
    {
        [Required,Key]
        private protected uint ID;
        [Required, MaxLength(35)]
        private protected string Nombre;
        [Required,Column("Superficie")]
        private protected uint Superficie_Hectareas;

        public virtual uint ObtenerID()
        {
            return ID;
        }

        public virtual void SetID(uint _id)
        {
            ID = _id;
        }

        public virtual void SetNombre(string _nombre)
        {
            Nombre = _nombre;
        }

        public virtual uint ObtenerSuperficie()
        {
            return Superficie_Hectareas;
        }

    }
}
