using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Sintagri.Modelo.DataBase.MSSQLServer.Models;
using Sintagri.Modelo.Entidades;
using Sintagri.Modelo.Entidades.Misc;
using Sintagri.UI.Formularios;

namespace Sintagri.UI.UsersControl
{
    public partial class IngresoInsumos : UserControl
    {
        Informaciones info;

        public IngresoInsumos()
        {
            InitializeComponent();
        }

        private void IndexInsumo_Changed(object sender, EventArgs e)
        {
            //Si es Fitosanitario
            if (InsumosBox.SelectedIndex == 0)
            {
                TipoFertilizanteCB.Enabled = false;
            }
            else if(InsumosBox.SelectedIndex == 1)
            {
                TipoFertilizanteCB.Enabled = true;
            }
            else
            {
                MessageBox.Show("Selecciona un tipo de Insumo","Información",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void AgregarPropiedad_Click(object sender, EventArgs e)
        {
            info = new Informaciones("Propiedades e Ingredientes",this, new PropiedadesControl(ref PropiedadesDataGrid))
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            info.ShowDialog();
        }

        private void EliminarCell_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in PropiedadesDataGrid.SelectedRows)
            {
                PropiedadesDataGrid.Rows.RemoveAt(item.Index);
            }
        }

        private void VolverInventario_Clock(object sender, EventArgs e)
        {
            Parent.Controls.Add(new InventarioControl()
            {
                Dock = DockStyle.Fill
            }
            );
            Parent.Controls.Remove(this);
        }

        private void AgregarProducto_Click(object sender, EventArgs e)
        {
            #region Querys a Entidades
            //Fitosanitario
            if (InsumosBox.SelectedIndex == 0)
            {
                using (var context = new SQLServerDbContext())
                {
                    var InsumoEntrante = new Fitosanitario()
                    {
                        Nombre_Comercial = NombreComercialTB.Text,
                        Presentacion_Insumo = Presentacion.Envase,
                        Costo_Total = int.Parse(CostoTotalTB.Text),
                        Manofacturera = ManofactureraTB.Text,
                        Proveedor = ProveedorTB.Text,
                        Prioridad = int.Parse(PrioridadTB.Text),
                        Subprioridad = int.Parse(SubprioridadTB.Text),
                        RegistroSAG = int.Parse(RegistroSAGTB.Text),
                        Modo_Accion = ModoAccionTB.Text,
                        Etiqueta = "Amarilla",
                    };
                    
                    context.Fitosanitarios.Add(InsumoEntrante);
                    context.SaveChanges();

                    var Ingredientes = ObtenerListadoDeIngredientesFitos(InsumoEntrante.ID_Insumo);
                    context.AddRange(Ingredientes);
                    context.SaveChanges();
                }
            }
            //Fertilizante
            else
            {
                using (var context = new SQLServerDbContext())
                {
                    var InsumoEntrante = new Fertilizante()
                    {
                        Nombre_Comercial = NombreComercialTB.Text,
                        Presentacion_Insumo = Presentacion.Envase,
                        Costo_Total = int.Parse(CostoTotalTB.Text),
                        Manofacturera = ManofactureraTB.Text,
                        Proveedor = ProveedorTB.Text,
                        //Prioridad = int.Parse(PrioridadTB.Text),
                        //Subprioridad = int.Parse(SubprioridadTB.Text),
                        //RegistroSAG = int.Parse(RegistroSAGTB.Text),
                        //Modo_Accion = ModoAccionTB.Text,
                        //Etiqueta = "Amarilla",
                    };

                    context.Fertilizantes.Add(InsumoEntrante);
                    context.SaveChanges();

                    var Ingredientes = ObtenerListadoDeIngredientesFertilizantes(InsumoEntrante.ID_Insumo);
                    context.AddRange(Ingredientes);
                    context.SaveChanges();
                }
            }
            #endregion
            MessageBox.Show("Insumo agregado correctamente a la base de datos.","Confirmación",MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Parent.Controls.Add(new InventarioControl()
            {
                Dock = DockStyle.Fill
            }
            );
            Parent.Controls.Remove(this);
        }

        private List<PFQ_Fertilizante> ObtenerListadoDeIngredientesFertilizantes(int id_Insumo)
        {
            if (PropiedadesDataGrid.Rows.Count > 0)
            {
                var listaTemporal = new List<PFQ_Fertilizante>();
                foreach (DataGridViewRow data in PropiedadesDataGrid.Rows)
                {
                    listaTemporal.Add(new PFQ_Fertilizante()
                    {
                        Nombre = data.Cells["Nombre"].Value.ToString(),
                        Valor_PFQ = float.Parse(data.Cells["Valor"].Value.ToString()),
                        Unidad_Medida = data.Cells["UnidadMedida"].Value.ToString(),
                        Categoria = data.Cells["Categoria"].Value.ToString(),
                        ID_Insumo = id_Insumo,
                    });
                }
                return listaTemporal;
            }
            else
            {
                MessageBox.Show("Cada Insumo debe al menos tener alguna propiedad o ingrediente.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private List<PFQ_Fitosanitario> ObtenerListadoDeIngredientesFitos(int id_Insumo)
        {
            if (PropiedadesDataGrid.Rows.Count > 0) {
                    var listaTemporal = new List<PFQ_Fitosanitario>();
                    foreach (DataGridViewRow data in PropiedadesDataGrid.Rows)
                    {
                        listaTemporal.Add(new PFQ_Fitosanitario()
                        {
                            Nombre = data.Cells["Nombre"].Value.ToString(),
                            Valor_PFQ = float.Parse(data.Cells["Valor"].Value.ToString()),
                            Unidad_Medida = data.Cells["UnidadMedida"].Value.ToString(),
                            Categoria = data.Cells["Categoria"].Value.ToString(),
                            ID_Insumo = id_Insumo,
                        });
                    }
                    return listaTemporal;
            }
            else
            {
                MessageBox.Show("Cada Insumo debe al menos tener alguna propiedad o ingrediente.","Error",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
