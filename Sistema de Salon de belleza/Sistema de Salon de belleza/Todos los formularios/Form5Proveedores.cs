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

namespace Sistema_de_Salon_de_belleza
{
    public partial class Form5Proveedores : Form
    {
        ProveedoresBL _proveedores;
        public Form5Proveedores()
        {
            InitializeComponent();
            _proveedores = new ProveedoresBL();
            listaProveedoresBindingSource.DataSource = _proveedores.ObtenerProveedores();
        }

        private void Form5Proveedores_Load(object sender, EventArgs e)
        {

        }
    }
}
