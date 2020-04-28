using System;
using System.Windows.Forms;

namespace Sintagri.UI.UsersControl
{
    public partial class MenuSideOptionsControl : UserControl
    {
        private AdminForm _formulario;
        private Panel mainPanel;

        public MenuSideOptionsControl(AdminForm _formIn, Panel _cPanel)
        {
            InitializeComponent();
            _formulario = _formIn;
            mainPanel = _cPanel;
        }

        private void InventarioOption_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new InventarioControl()
            {
                Dock = DockStyle.Fill,
            });
        }

        private void CamposOption_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new CamposControl()
            {
                Dock = DockStyle.Fill,
            });
        }

        private void OrdenesOption_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new IngresoOrdenControl(1)
            {
                Dock = DockStyle.Fill,
            });
        }

        private void MaquinariaOption_Field(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            MessageBox.Show("No tienes los permisos requeridos para modificar este item",
                "Información",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void ContabilidadOption_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No tienes permiso para ingresar aquí.", "Información", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void CultivosOption_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new VegetalesControl()
            {
                Dock = DockStyle.Fill,
            });
        }

        private void InsumosOption_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            MessageBox.Show("No tienes los permisos requeridos para modificar este item",
                "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
