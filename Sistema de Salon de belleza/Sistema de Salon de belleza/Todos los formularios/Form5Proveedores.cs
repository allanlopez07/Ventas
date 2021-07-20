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

        private void proveedoresBLBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            var proveedores = (BL.Rentas.Proveedores)listaProveedoresBindingSource.Current;

            var resultado = _proveedores.GuardarProveedores(proveedores);
            if (resultado.Exitoso == true)
            {
                listaProveedoresBindingSource.ResetBindings(false);
                DeshabilitarHabilitarHabilitarBotones(true);
                MessageBox.Show("Proveedores Guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _proveedores.AgregarProveedores();
            listaProveedoresBindingSource.MoveLast();

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

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var idproveedor = Convert.ToInt32(idTextBox.Text);
                    Eliminar(idproveedor);
                }
                
            }
        }

        private void Eliminar(int idproveedor)
        {
           
            var resultado = _proveedores.EliminarProveedores(idproveedor);

            if (resultado == true)
            {
                listaProveedoresBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un erro al eliminar el proveedor");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _proveedores.CancelarCambios();
            DeshabilitarHabilitarHabilitarBotones(true);

        }

        private void nombreCompaniaLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
