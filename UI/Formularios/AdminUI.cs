using Sintagri.UI.UsersControl;
using System.Windows.Forms;

namespace Sintagri
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, System.EventArgs e)
        {
            var _OptionPane = new MenuSideOptionsControl(this,MainPanel)
            {
                Dock = DockStyle.Fill
            };
            SideMenuPanel.Controls.Add(_OptionPane);

            //var _ordenIngreso = new IngresoInsumos();
            //_ordenIngreso.Dock = DockStyle.Fill;
            //MainPanel.Controls.Add(_ordenIngreso);

        }

        private void ObtenerPerfil_Click(object sender, System.EventArgs e)
        {

        }
    }
}
