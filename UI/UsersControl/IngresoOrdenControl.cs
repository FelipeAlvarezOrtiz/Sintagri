using Sintagri.UI.Formularios;
using System;
using System.Windows.Forms;

namespace Sintagri.UI.UsersControl
{
    public partial class IngresoOrdenControl : UserControl
    {
        private static int ID_Agricola = 0;

        public IngresoOrdenControl(int _idAgricola)
        {
            InitializeComponent();
            if (_idAgricola == 0)
                MessageBox.Show("Error cargando la agricola.","Error");
            ID_Agricola = _idAgricola;
            //Setear la fecha
            fechaInput.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void Subsector_FindClick(object sender, EventArgs e)
        {
            MessageBox.Show("Haz presionado para buscar el Subsector.", "Búsqueda");
        }

        private void Predio_FindClick(object sender, EventArgs e)
        {
            MessageBox.Show("Haz presionado para buscar el predio.", "Búsqueda");
            var informacion = new DisplayInfoControl();
            
            new Informaciones("Buscador de Predios",informacion).Show();
        }

        private void Sector_FindClick(object sender, EventArgs e)
        {
            MessageBox.Show("Haz presionado para buscar el Sector.", "Búsqueda");
        }
    }
}
