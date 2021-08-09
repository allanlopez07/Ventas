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

            if (Program.UsuarioLogueado != null)
            {
                toolStripStatusLabel1.Text = "Usuario: " 
                    + Program.UsuarioLogueado.Nombre;

                if (Program.UsuarioLogueado.TipoUsuario == "Usuario Caja")
                {
                    reportesDeProductosToolStripMenuItem.Visible = true;
                    seguridadToolStripMenuItem1.Enabled = false;
                    transaccionesToolStripMenuItem1.Enabled = false;
                    empleadosToolStripMenuItem1.Enabled = false;
                    ventasToolStripMenuItem3.Enabled = false;
                    agendaToolStripMenuItem.Enabled = true;
                    button1.Enabled = false;
                    button5.Enabled = true;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                }
                else if (Program.UsuarioLogueado.TipoUsuario == "Administradores")
                {
                    reportesDeProductosToolStripMenuItem.Enabled = true;
                    seguridadToolStripMenuItem1.Enabled = true;
                    transaccionesToolStripMenuItem1.Enabled = true;
                    empleadosToolStripMenuItem1.Enabled = true;
                    ventasToolStripMenuItem3.Enabled = true;
                    agendaToolStripMenuItem.Enabled = true;
                    button1.Enabled = true;
                    button5.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                }
                else if (Program.UsuarioLogueado.TipoUsuario == "Usuarios Vendedores")
                {
                    reportesDeProductosToolStripMenuItem.Enabled = false;
                    seguridadToolStripMenuItem1.Enabled = false;
                    transaccionesToolStripMenuItem1.Enabled = false;
                    empleadosToolStripMenuItem1.Enabled = false;
                    ventasToolStripMenuItem3.Enabled = false;
                    agendaToolStripMenuItem.Enabled = true;
                    button1.Enabled = true; 
                    button5.Enabled = false;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                }
            } else
            {
                Application.Exit();
            }
            
                  
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
            var form11fac = new Form11fac();
            //form1Factura.MdiParent = this;
            form11fac.ShowDialog();
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
            
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var for7empleados = new Form7Empleados();
            for7empleados.ShowDialog();
        }

        private void reportesDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteproductos = new FormReportedeProductos();
            formReporteproductos.ShowDialog();
        }

        private void reporteDeCitasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formReportecitas = new FormReporte_de_Citas();
            formReportecitas.ShowDialog();
        }

        private void reportesDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteclientes = new FormReportedeClientes();
            formReporteclientes.ShowDialog();
        }

        private void reporteDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteproveedores = new FormReportedeProveedores();
            formReporteproveedores.ShowDialog();
        }

        private void ventasToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var formReporteventas = new FormReportedeVentas();
                formReporteventas.ShowDialog();
        }

        private void agregarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formusuarios = new FormUsuarios();
            //form1Factura.MdiParent = this;
            formusuarios.ShowDialog();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var formacerca = new FormAyuda();
            formacerca.ShowDialog();
        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manualusuario = new FormanualUsuario();
            manualusuario.ShowDialog();
        }
    }
}
