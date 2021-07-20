using BL.Rentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Salon_de_belleza.Todos_los_formularios
{
    public partial class Prueba : Form
    {
        TipoBL _tipos;
        public Prueba()
        {
            InitializeComponent();
            _tipos = new TipoBL();
            listaTiposBindingSource.DataSource = _tipos.ObtenerTipos();
        }

        private void Prueba_Load(object sender, EventArgs e)
        {

        }
    }
}
