using System;
using System.Windows.Forms;
using Sintagri.Modelo.DataBase.MSSQLServer.Models;
using Sintagri.Modelo.Entidades.Cultivos;

namespace Sintagri.UI.UsersControl
{
    public partial class VegetalesControl : UserControl
    {
        public VegetalesControl()
        {
            InitializeComponent();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            using (var context = new SQLServerDbContext())
            {
                var cultivoEntrante = new Cultivo()
                {
                    Especie = EspecieTB.Text,
                    Tipo = TipoCB.SelectedItem.ToString(),
                    Variedad = VariedadTB.Text,
                    Dias_Minimos_Cosecha = int.Parse(DMinCosechaTB.Text),
                    Dias_Maximos_Cosecha = int.Parse(DMaxCosechaTB.Text),
                    Semillera = SemilleraTB.Text,
                    Formato = Formato_Cultivo.Semilla,
                    Plantinera = PlantineraCB.Text,
                };

                context.Cultivos.Add(cultivoEntrante);
                context.SaveChanges();

                MessageBox.Show("Cultivo Guardado con éxito.", "Confirmación", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Parent.Controls.Clear();
            }
        }
    }
}
