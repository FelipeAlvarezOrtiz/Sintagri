using Microsoft.EntityFrameworkCore;
using Sintagri.Modelo.DataBase.MSSQLServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sintagri.UI.UsersControl
{
    public partial class InventarioControl : UserControl
    {
        AutoCompleteStringCollection datos = new AutoCompleteStringCollection();
        public List<string> nombreFitosDisponibles = new List<string>();
        public List<string> nombreFertiDisponibles = new List<string>();

        public InventarioControl()
        {
            InitializeComponent();
            CargarInventario();
            RellenarInformacionStockDisponible();
            RellenarAutocompletar();
        }

        private async void RellenarInformacionStockDisponible()
        {
            nombreFitosDisponibles.Clear();
            nombreFertiDisponibles.Clear();
            using (var context = new SQLServerDbContext())
            {
                nombreFitosDisponibles = await context.Fitosanitarios.Select(x => x.Nombre_Comercial).ToListAsync();
                nombreFertiDisponibles = await context.Fertilizantes.Select(x => x.Nombre_Comercial).ToListAsync();
            }
        }

        private void RellenarAutocompletar()
        {
            datos.Clear();
            if (nombreFitosDisponibles.Count > 0) {
                foreach (var nombre in nombreFitosDisponibles)
                {
                    datos.Add(nombre);
                }
            }
            if (nombreFertiDisponibles.Count > 0) {
                foreach (var nombre in nombreFertiDisponibles)
                {
                    datos.Add(nombre);
                }
            }
            BusquedaInputText.AutoCompleteCustomSource = datos;
            BusquedaInputText.AutoCompleteMode = AutoCompleteMode.Suggest;
            BusquedaInputText.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public async void CargarInventario()
        {
            using (var context = new SQLServerDbContext())
            {
                var InventarioFitosanitario = await context.Fitosanitarios.
                    Select(x=> new { x.ID_Insumo,x.Nombre_Comercial,x.RegistroSAG,x.Manofacturera,x.Modo_Accion })
                    .OrderBy(x => x.ID_Insumo).ToListAsync();
                var InventarioFertilizante = await context.Fertilizantes.
                    Select(x => new { x.ID_Insumo, x.Nombre_Comercial, x.Manofacturera}).
                    OrderBy(x => x.ID_Insumo).ToListAsync();
                if (InventarioFitosanitario.Count > 0) {
                    foreach (var insumo in InventarioFitosanitario)
                    {
                        InventarioGridView.Rows.Add(insumo.ID_Insumo, insumo.Nombre_Comercial, "Fitosanitario",
                            insumo.RegistroSAG, insumo.Manofacturera, insumo.Modo_Accion);
                    }
                }
                if (InventarioFertilizante.Count > 0) {
                    foreach (var insumo in InventarioFertilizante)
                    {
                        InventarioGridView.Rows.Add(insumo.ID_Insumo, insumo.Nombre_Comercial, "Fertilizante",
                            "No aplica", insumo.Manofacturera, "No aplica");
                    }
                }
            }
        }

        public async void CargarInventario(string NombreBuscado)
        {
            using (var context = new SQLServerDbContext())
            {
                var InventarioFitosanitario = await context.Fitosanitarios.Where(x=> x.Nombre_Comercial == NombreBuscado)
                    .Select(x => new { x.ID_Insumo, x.Nombre_Comercial, x.RegistroSAG, x.Manofacturera, x.Modo_Accion })
                    .OrderBy(x => x.ID_Insumo).ToListAsync();
                var InventarioFertilizante = await context.Fertilizantes.
                    Select(x => new { x.ID_Insumo, x.Nombre_Comercial, x.Manofacturera }).
                    OrderBy(x => x.ID_Insumo).ToListAsync();
                if (InventarioFitosanitario.Count > 0)
                {
                    foreach (var insumo in InventarioFitosanitario)
                    {
                        InventarioGridView.Rows.Add(insumo.ID_Insumo, insumo.Nombre_Comercial, "Fitosanitario",
                            insumo.RegistroSAG, insumo.Manofacturera, insumo.Modo_Accion);
                    }
                }
                if (InventarioFertilizante.Count > 0)
                {
                    foreach (var insumo in InventarioFertilizante)
                    {
                        InventarioGridView.Rows.Add(insumo.ID_Insumo, insumo.Nombre_Comercial, "Fertilizante",
                            "No aplica", insumo.Manofacturera, "No aplica");
                    }
                }
            }
        }

        private void IngresarProducto_Click(object sender, EventArgs e)
        {
            //Parent.Controls.Remove(this);
            Parent.Controls.Add(new IngresoInsumos()
            {
                Dock = DockStyle.Fill
            }
            );
            Parent.Controls.Remove(this);
        }

        private async void BuscarEvent_Click(object sender, EventArgs e)
        {
            if (BusquedaInputText.Text.CompareTo(string.Empty) == 0)
            {
                MessageBox.Show("Ingresa algo para poder buscar.","Información",MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
            }
            else
            {
                if (datos.Contains(BusquedaInputText.Text))
                {
                    using (var context = new SQLServerDbContext())
                    {
                        var fito = await context.Fitosanitarios.Where(x => x.Nombre_Comercial == BusquedaInputText.Text)
                            .Select(x => new {x.ID_Insumo, x.Nombre_Comercial, x.RegistroSAG, x.Manofacturera, x.Modo_Accion })
                            .ToListAsync();
                        if (fito.Count > 0)
                        {
                            foreach (var insumo in fito)
                            {
                                InventarioGridView.Rows.Add(insumo.ID_Insumo, insumo.Nombre_Comercial, "Fitosanitario",
                                    insumo.RegistroSAG, insumo.Manofacturera, insumo.Modo_Accion);
                            }
                        }
                    }
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("El texto ingresado no corresponde con ningún dato dentro de los registros," +
                        "¿Desea agregar un nuevo insumo?","Información",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                    if (resultado == DialogResult.Yes)
                    {
                        Parent.Controls.Add(new IngresoInsumos()
                        {
                            Dock = DockStyle.Fill
                        });
                        Parent.Controls.Remove(this);
                    }
                }
            }
        }
    }
}
