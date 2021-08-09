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
using static BL.Rentas.SeguridadBl;

namespace Sistema_de_Salon_de_belleza.Todos_los_formularios
{
    public partial class FormUsuarios : Form
    {
        SeguridadBl _usuarios; 

        public FormUsuarios()
        {
            InitializeComponent();
            _usuarios = new SeguridadBl();
            listaUsuariosBindingSource1.DataSource = _usuarios.ObtenerUsuarios();

        }

        private void seguridadBl_UsuariosDBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            var usuario = (UsuariosDB)listaUsuariosBindingSource1.Current;

            if (fotoPictureBox.Image != null)
            {
                usuario.Foto = Program.imageToByteArray(fotoPictureBox.Image);
            }
            else
            {
                usuario.Foto = null;
            }
            var resultado = _usuarios.GuardarUsuario(usuario);
            if (resultado.Exitoso == true)
            {
                listaUsuariosBindingSource1.ResetBindings(false);
                DeshabilitarHabilitarHabilitarBotones(true);
                MessageBox.Show("Usuario Guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
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
            _usuarios.AgregarUsuario();
            listaUsuariosBindingSource1.MoveLast();

            DeshabilitarHabilitarHabilitarBotones(false);
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

        private void Eliminar(int idusuario)
        {

            var resultado = _usuarios.EliminarUsuario(idusuario);

            if (resultado == true)
            {
                listaUsuariosBindingSource1.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un erro al eliminar el usuario");
            }
        }
        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _usuarios.CancelarCambios();
            DeshabilitarHabilitarHabilitarBotones(true);
        }

        private void seguridadBl_UsuariosDBBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            DeshabilitarHabilitarHabilitarBotones(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usuario = (UsuariosDB)listaUsuariosBindingSource1.Current;
            if (usuario != null)
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
                MessageBox.Show("Cree un Usuario antes de asignarle una imagen");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }
    }
}
