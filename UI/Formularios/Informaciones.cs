using System.Windows.Forms;

namespace Sintagri.UI.Formularios
{
    public partial class Informaciones : Form
    {
        private UserControl _internalUse = null;

        public Informaciones(string _nombre,UserControl formularioBase,UserControl _controlDesplegable)
        {
            InitializeComponent();
            _internalUse = formularioBase;
            Text = _nombre;
            _controlDesplegable.Dock = DockStyle.Fill;
            Width = _controlDesplegable.Width;
            Height = _controlDesplegable.Height;
            MaximizeBox = false;
            MinimizeBox = false;
            Panel_Informaciones.Controls.Add(_controlDesplegable);
        }
    }
}
