using System.Windows.Forms;

namespace Sintagri.UI.Formularios
{
    public partial class Informaciones : Form
    {
        public Informaciones(string _nombre,UserControl _controlDesplegable)
        {
            InitializeComponent();
            Text = _nombre;
            _controlDesplegable.Dock = DockStyle.Fill;
            Width = _controlDesplegable.Width;
            Height = _controlDesplegable.Height;
            PanelInformaciones.Controls.Add(_controlDesplegable);
        }
    }
}
