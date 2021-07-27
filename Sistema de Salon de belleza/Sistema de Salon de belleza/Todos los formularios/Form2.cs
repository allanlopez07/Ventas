using Sistema_de_Salon_de_belleza.Todos_los_formularios;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Login()
        {
            var form1 = new Form1();
            form1.ShowDialog();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            var form1 = new Form1();
           form1.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var FormProductos = new Todos_los_formularios.FormProductos();
            FormProductos.ShowDialog();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void seguridadToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          //  var form4 = new Todos_los_formularios.Reportes();
           // form4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form5Proveedores = new Form5Proveedores();
                form5Proveedores.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form4Clientes = new  Form4Clientes();
            form4Clientes.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form6Citas = new Form6Citas();
            form6Citas.ShowDialog();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form9Agenda = new Form9Calendario();
            form9Agenda.ShowDialog();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form11fac = new Form11fac();
          //  form10Factura.MdiParent = this;
             form11fac.ShowDialog();
        }
    }
}
