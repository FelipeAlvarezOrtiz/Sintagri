using System.Collections.Generic;
using System.Windows.Forms;

namespace Sintagri.UI.UsersControl
{
    public partial class DisplayInfoControl : UserControl
    {
        public DisplayInfoControl()
        {
            InitializeComponent();
        }

        public void InicializarVistaSegunSector(List<int> _sectoresSeleccionados)
        {
            if (_sectoresSeleccionados.Count > 0) {
                if (_sectoresSeleccionados.Count == 1)
                {
                    //Solo si es un sector
                }
                else
                {
                    //Aqui si es 1 o más sectores
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar algún Sector","Información");
            }
        }

        public void InicializarVistaSegunPredio(int _idPredio)
        {

        }
    }
}
