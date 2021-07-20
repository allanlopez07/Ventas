using BL.Rentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Salon_de_belleza.Todos_los_formularios
{
    public partial class FormProductos : Form
    {

        ProductosBL _productos;
        CategoriaBL _categorias;
        TipoBL _tipos; 
        public FormProductos() 
        {
            InitializeComponent();

            _productos = new ProductosBL();
            ListaProductosBindingSource.DataSource = _productos.ObtenerProductos();

            _categorias = new CategoriaBL();
            listaCategoriasBindingSource.DataSource = _categorias.ObtenerCategorias();

            _tipos = new TipoBL(); 
            listaTiposBindingSource.DataSource = _tipos.ObtenerTipos(); 
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            
            DeshabilitarHabilitarHabilitarBotones(true);

        }

        private void productoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void seguridadBlBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            ListaProductosBindingSource.EndEdit();
            var producto = (Producto) ListaProductosBindingSource.Current;

            if (fotoPictureBox.Image!= null)
            {
                producto.Foto = Program.imageToByteArray(fotoPictureBox.Image);
            }
            else
            {
                producto.Foto = null;
            }
            var resultado = _productos.GuardarProducto(producto);
            if (resultado.Exitoso == true)
            {
                ListaProductosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarHabilitarBotones(true);
                MessageBox.Show("Producto Guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
          //  MessageBox.Show(producto);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
             
            _productos.AgrearProducto();
            ListaProductosBindingSource.MoveLast();

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
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
                
            }
       }

        private void Eliminar(int id)
        {
            var resultado = _productos.EliminarProducto(id);

            if (resultado == true)
            {
                ListaProductosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un erro al eliminar el producto");
            }
        }

        private void seguridadBlBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            //DeshabilitarHabilitarHabilitarBotones(true);

        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _productos.CancelarCambios();
            DeshabilitarHabilitarHabilitarBotones(true);
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var producto = (Producto)ListaProductosBindingSource.Current;
            if (producto != null)
            {
                openFileDialog1.ShowDialog();
                var archivo = openFileDialog1.FileName;

                if (archivo != "")
                {
                    var fileInfo = new FileInfo(archivo);
                    var fileStream = fileInfo.OpenRead();

                    fotoPictureBox.Image = Image.FromStream(fileStream);
                }
            }
            else
            {
                MessageBox.Show("Cree un producto antes de asignarle una imagen");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void citasIdTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void clienteIdTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tipoIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
