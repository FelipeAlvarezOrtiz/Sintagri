using Microsoft.EntityFrameworkCore;
using Sintagri.Modelo.DataBase.MSSQLServer.Models;
using Sintagri.UI.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sintagri.UI.UsersControl
{
    public partial class IngresoOrdenControl : UserControl
    {
        private static int ID_Agricola = 0;
        private List<string> nombreFitosDisponibles = new List<string>();
        private List<string> nombreFertiDisponibles = new List<string>();

        public IngresoOrdenControl(int _idAgricola)
        {
            InitializeComponent();
            if (_idAgricola == 0)
                MessageBox.Show("Error cargando la agricola.","Error");
            ID_Agricola = _idAgricola;
            //Setear la fecha
            fechaInput.Text = DateTime.Now.ToString("dd/MM/yyyy");
            RellenarInformacionStockDisponible();
            RellenarAutocompletar();
        }

        private void Subsector_FindClick(object sender, EventArgs e)
        {
            MessageBox.Show("Todo ha sido rellenado de manera automatica.", "Búsqueda");
        }

        private void Predio_FindClick(object sender, EventArgs e)
        {
            var informacion = new DisplayInfoControl(5);
            
            new Informaciones("Buscador de Predios",this,informacion).ShowDialog();
            PrediosSeleccionados.Text = "Nueva Vida";
            TotalHectareasTB.Text = "10";
            MojamientoTB.Text = "2MH/L";

        }

        private void Sector_FindClick(object sender, EventArgs e)
        {
            MessageBox.Show("Haz presionado para buscar el Sector.", "Búsqueda");
        }

        private void Cancelar_Orden_Button_Click(object sender, EventArgs e)
        {
            Parent.Controls.Clear();
        }

        private async void RellenarInformacionStockDisponible()
        {
            nombreFitosDisponibles.Clear();
            nombreFertiDisponibles.Clear();
            using (var context = new SQLServerDbContext())
            {
                nombreFitosDisponibles = await context.Fitosanitarios
                    .Where(x => x.Prioridad == 1)
                    .Select(x => x.Nombre_Comercial)
                    .ToListAsync();
                nombreFertiDisponibles = await context.Fertilizantes
                    .Where(x=> x.Prioridad == 1)
                    .Select(x => x.Nombre_Comercial).
                    ToListAsync();
            }
        }

        private void RellenarAutocompletar()
        {
            var datos = new AutoCompleteStringCollection();
            if (nombreFitosDisponibles.Count > 0)
            {
                foreach (var nombre in nombreFitosDisponibles)
                {
                    datos.Add(nombre);
                }
            }
            if (nombreFertiDisponibles.Count > 0)
            {
                foreach (var nombre in nombreFertiDisponibles)
                {
                    datos.Add(nombre);
                }
            }
            InsumoInput.AutoCompleteCustomSource = datos;
            InsumoInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            InsumoInput.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private async void EnterPresionado_Event(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                using (var context = new SQLServerDbContext())
                {
                    var Busqueda = await context.Fitosanitarios
                        .Where(x => x.Nombre_Comercial.CompareTo(InsumoInput.Text) == 0).
                        FirstAsync();
                    if (Busqueda !=null)
                    {
                        InsumosDataGrid.Rows.Add(Busqueda.ID_Insumo,Busqueda.Nombre_Comercial,
                            2.56f,"Litros");
                    }
                    else
                    {
                        MessageBox.Show("La búsqueda ha arrojado no ha arrojado nada", "Error",
                            MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void InsumoInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
