using System;
using BL.Rentas;
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
    public partial class Form7Empleados : Form
    {
        EmpleadosBL  _empleados;

        public Form7Empleados()
        {
            InitializeComponent();
            _empleados = new EmpleadosBL();
            listaEmpleadosBindingSource.DataSource = _empleados.ObtenerEmpleados();
        }

        private void Form7Empleados_Load(object sender, EventArgs e)
        {
            DeshabilitarHabilitarHabilitarBotones(true);
        }

        private void empleadosBL_EmpleadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            var empleados = (EmpleadosBL.Empleados)listaEmpleadosBindingSource.Current;

            var resultado = _empleados.GuardarEmpelados(empleados);

            if (resultado.Exitoso == true)
            {
                listaEmpleadosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarHabilitarBotones(true);
                MessageBox.Show("Empleado Guardado Correctamente");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _empleados.Agregarempleados();
            listaEmpleadosBindingSource.MoveLast();
            DeshabilitarHabilitarHabilitarBotones (false);
        }

        private void DeshabilitarHabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
           // toolStripButtonCancelar.Visible = !valor;
        }
    }
}

