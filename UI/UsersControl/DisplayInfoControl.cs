using Microsoft.EntityFrameworkCore;
using Sintagri.Modelo.DataBase.MSSQLServer.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sintagri.UI.UsersControl
{
    public partial class DisplayInfoControl : UserControl
    {
        //1 según Predio
        //2 según Etapa
        //3 según Sector
        //4 según Valvula

        //5 para buscar Predios
        //6 para buscar Etapas
        //7 para buscar Sector
        //8 para buscar Valvulas

        private List<int> _idParciales = new List<int>();
        private int OperacionEnSesion = 0;
        private IngresoOrdenControl Origen = null;

        public DisplayInfoControl(int _idOperacion)
        {
            _idParciales.Clear();
            OperacionEnSesion = _idOperacion;
            InitializeComponent();
            CheckboxInput.Items.Clear();
            LlenarInterfazSegunOperacion(OperacionEnSesion);
        }

        public DisplayInfoControl(int _idOperacion,UserControl _origen)
        {
            Origen = (IngresoOrdenControl)_origen;
            _idParciales.Clear();
            OperacionEnSesion = _idOperacion;
            InitializeComponent();
            CheckboxInput.Items.Clear();
            
            LlenarInterfazSegunOperacion(OperacionEnSesion);
        }

        public void LlenarInterfazSegunOperacion(int _idOpe)
        {
            switch (_idOpe)
            {
                case 1:
                    LlenarSegunPredio();
                    break;
                case 2:
                    LlenarSegunEtapa();
                    break;
                case 3:
                    LlenarSegunSector();
                    break;
                case 4:
                    break;
                case 5:
                    LlenarPredios();
                    break;

            }
        }

        public async void LlenarPredios()
        {
            using (var context = new SQLServerDbContext())
            {
                var Predios = await context.Predios.ToListAsync();
                foreach (var Predio in Predios)
                {
                    _idParciales.Add(Predio.ID);
                    CheckboxInput.Items.Add(Predio.Nombre, false);
                }
            }
        }

        public async void LlenarSegunPredio()
        {
            using (var context = new SQLServerDbContext())
            {
                var Etapas = await context.Potreros.Where(x => x.Predio_Pertenenciente == null).ToListAsync();
                foreach (var Etapa in Etapas) { 
                    CheckboxInput.Items.Add(Etapa.Nombre,false);
                }
            }
        }

        //2
        public async void LlenarSegunEtapa()
        {
            using (var context = new SQLServerDbContext())
            {
                var Sectores = await context.Sectores.Where(x => x.Potrero_perteneciente == null).ToListAsync();
                foreach (var Sector in Sectores)
                {
                    CheckboxInput.Items.Add(Sector.Nombre, false);
                }
            }
        }

        //3
        public async void LlenarSegunSector()
        {
            using (var context = new SQLServerDbContext())
            {
                var Subsectores = await context.Valvulas.Where(x => x.Sector == null).ToListAsync();
                foreach (var subsector in Subsectores)
                {
                    CheckboxInput.Items.Add(subsector.Nombre, false);
                }
            }
        }

        private void Aceptar_Button_Click(object sender, System.EventArgs e)
        {

        }
    }
}
