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
using static BL.Rentas.CitasBL;

namespace Sistema_de_Salon_de_belleza
{
    public partial class FormReportedeProductos : Form
    {
        CitasBL _citas; 

        public FormReportedeProductos()
        {
            InitializeComponent();
            _citas = new CitasBL();
            listaCitasBindingSource.DataSource = _citas.ObtenerCitas();
        }

        private void Form6Citas_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var idcita = Convert.ToInt32(textBox1.Text);
                    Eliminar(idcita);
                }
            }
        }

        private void Eliminar(int idcita)
        {

            var resultado = _citas.EliminarCitas(idcita);

            if (resultado == true)
            {
                listaCitasBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un erro al eliminar la cita");
            }
        }

        private void listaCitasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;

            var resultado = _citas.GuardarCitas(citas);
            if (resultado.Exitoso == true)
            {
                listaCitasBindingSource.ResetBindings(false);
                DeshabilitarHabilitarHabilitarBotones(true);
                MessageBox.Show("Citas Guardada Correctamente");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _citas.AgregarCitas();
            listaCitasBindingSource.MoveLast();

            DeshabilitarHabilitarHabilitarBotones(false);
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
            toolStripButtonCancelar.Visible = !valor;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            _citas.CancelarCambios();
            DeshabilitarHabilitarHabilitarBotones(true);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
