using System;
using System.Windows.Forms;

namespace Sintagri.UI.UsersControl
{
    public partial class PropiedadesControl : UserControl
    {
        private DataGridView _dataGridInterno;

        public PropiedadesControl(ref DataGridView dataGrid)
        {
            InitializeComponent();
            _dataGridInterno = dataGrid;
        }

        private void AgregarPropiedad_Click(object sender, EventArgs e)
        {
            //if (NombreTB.Text.CompareTo(string.Empty) == 0 &&
            //    float.TryParse(ValorTB.Text,out float resultado) &&
            //    UnidadMedidaTB.Text.CompareTo(string.Empty) == 0 &&
            //    CategoriaTB.Text.CompareTo(string.Empty) == 0 &&
            //    TipoCB.SelectedItem.ToString().CompareTo(string.Empty) == 0)
            //{
                _dataGridInterno.Rows.Add(NombreTB.Text,ValorTB.Text,
                    UnidadMedidaTB.Text,CategoriaTB.Text,TipoCB.SelectedItem.ToString());
                ((Form)this.TopLevelControl).Close();
            //}
        }
    }
}
