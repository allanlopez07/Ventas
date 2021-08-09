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
    public partial class Form8Agenda : Form
    {
        //EmpleadosBL _empleados;
        public Form8Agenda()
        {
            InitializeComponent();
          /*  _empleados = new EmpleadosBL();
            listaEmpleadosBindingSource.DataSource = _empleados.ObtenerEmpleados();
            listaEmpleadosBindingSource1.DataSource = _empleados.ObtenerEmpleados();
            */
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form8Agenda_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            var form6Citas = new Form6Citas();
            form6Citas.ShowDialog();
        }
    }
}
