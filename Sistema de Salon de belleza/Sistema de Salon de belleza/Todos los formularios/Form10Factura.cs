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
    public partial class Form10Factura : Form
    {
        FacturaBL _facturaBL;
        ClientesBL _clientesBL; 
        ProductosBL _productosBL;
        public Form10Factura()
        {
            InitializeComponent();

            _facturaBL = new FacturaBL();
            facturaDetalleBindingSource.DataSource = _facturaBL.ObtenerFacturas();

            _clientesBL = new ClientesBL();
            listaClientesBindingSource.DataSource = _clientesBL.ObtenerClientes();

            _productosBL = new ProductosBL();
            listaProductosBindingSource.DataSource = _productosBL.ObtenerProductos();

           
        }

        private void fechaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fechaLabel_Click(object sender, EventArgs e)
        {

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
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _facturaBL.AgregarFactura();
            facturaBindingSource.MoveLast();

            DeshabilitarHabilitarHabilitarBotones(false);
        }

        private void facturaDetalleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            facturaBindingSource.EndEdit();

            var factura = (Factura)facturaBindingSource.Current;
            var resultado = _facturaBL.GuardarFactura(factura);

            if (resultado.Exitoso == true)
            {
                facturaBindingSource.ResetBindings(false);
                DeshabilitarHabilitarHabilitarBotones(true);
                MessageBox.Show("Factura Guardada");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarHabilitarBotones(true);
            _facturaBL.CancelarCambios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var factura = (Factura)facturaBindingSource.Current;

            _facturaBL.AgregarFacturaDetalle(factura);

            DeshabilitarHabilitarHabilitarBotones(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var factura = (Factura)facturaBindingSource.Current;
            var facturaDetalle = (FacturaDetalle)facturaDetalleBindingSource.Current;

            _facturaBL.RemoverFacturaDetalle(factura, facturaDetalle);

            DeshabilitarHabilitarHabilitarBotones(false);
        }

       
      
        private void facturaDetalleDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void facturaDetalleDataGridView_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            var factura = (Factura)facturaBindingSource.Current;
            _facturaBL.CalcularFactura(factura);

            facturaBindingSource.ResetBindings(false);

        }

        private void Form10Factura_Load(object sender, EventArgs e)
        {

        }
    }
}
