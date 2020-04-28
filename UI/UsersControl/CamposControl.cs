using System;
using System.Windows.Forms;
using Sintagri.Modelo.DataBase.MSSQLServer.Models;
using Sintagri.Modelo.Entidades;
using Sintagri.UI.Formularios;

namespace Sintagri.UI.UsersControl
{
    public partial class CamposControl : UserControl
    {
        public CamposControl()
        {
            InitializeComponent();
        }

        private void CrearPredioButton_Click(object sender, EventArgs e)
        {
            using (var context = new SQLServerDbContext())
            {
                var PredioGenerado = new Predio()
                {
                    Nombre = NombrePredioTB.Text,
                    Superficie_Hectareas = float.Parse(superficieTB.Text),
                    Agricola_ID = 1,
                };
                context.Predios.Add(PredioGenerado);
                context.SaveChanges();
                NombrePredioTB.Text = string.Empty;
                superficieTB.Text = string.Empty;
                MessageBox.Show("Predio Ingresado Correctamente","Confirmación",MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void CrearPotreroButton_Click(object sender, EventArgs e)
        {
            using (var context = new SQLServerDbContext())
            {
                var PotreroGenerado = new Potreros()
                {
                    Nombre = NombrePotreroTB.Text,
                    Agricola_ID = 1,
                    Superficie_Hectareas = float.Parse(SuperficiePotreroTB.Text),
                };
                context.Potreros.Add(PotreroGenerado);
                context.SaveChanges();
            }
            NombrePotreroTB.Text = string.Empty;
            SuperficiePotreroTB.Text = string.Empty;
            MessageBox.Show("Potrero Ingresado Correctamente", "Confirmación", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void CrearSector_Click(object sender, EventArgs e)
        {
            using (var context = new SQLServerDbContext())
            {
                var SectorGenerado = new Sectores()
                {
                    Nombre = SectorTB.Text,
                    Superficie_Hectareas = float.Parse(SuperficieSectorTB.Text),
                    Agricola_ID = 1,
                };
                context.Sectores.Add(SectorGenerado);
                context.SaveChanges();
            }
            SectorTB.Text = string.Empty;
            SuperficieSectorTB.Text = string.Empty;
            MessageBox.Show("Sector Ingresado Correctamente", "Confirmación", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void CrearSubsectorButton_Click(object sender, EventArgs e)
        {
            using (var context = new SQLServerDbContext())
            {
                var SubsectorGenerado = new Valvulas()
                {
                    Nombre = NombreSubsectorTB.Text,
                    Superficie_Hectareas = float.Parse(SuperficieSubsectorTB.Text),
                    Agricola_ID = 1,
                };
                context.Valvulas.Add(SubsectorGenerado);
                context.SaveChanges();
            }
            NombreSubsectorTB.Text = string.Empty;
            SuperficieSubsectorTB.Text = string.Empty;
            MessageBox.Show("Subsector Ingresado Correctamente", "Confirmación", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void AsociarSectoresButton_Click(object sender, EventArgs e)
        {
            var informacion = new DisplayInfoControl(2){
                Dock = DockStyle.Fill
            };

            new Informaciones("Buscador de Predios",this, informacion).Show();
        }
    }
}
