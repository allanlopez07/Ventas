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
    public partial class Form6Citas : Form
    {
        CitasBL _citas; 

        public Form6Citas()
        {
            InitializeComponent();
            _citas = new CitasBL();
            listaCitasBindingSource.DataSource = _citas.ObtenerCitas();
        }

        private void Form6Citas_Load(object sender, EventArgs e)
        {

        }
    }
}
