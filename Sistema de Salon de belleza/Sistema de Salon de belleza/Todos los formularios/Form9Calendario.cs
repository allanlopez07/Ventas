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
    public partial class Form9Calendario : Form
    {
        CitasBL _citas;
        public Form9Calendario()
        {
            InitializeComponent();
            _citas = new CitasBL();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void Form9Calendario_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label9.Enabled = false;
            }

        private void button6_Click(object sender, EventArgs e)
        {
            var citas = (CitasBL.Citas)listaCitasBindingSource.Current;
            var form8Agenda = new Form8Agenda();
            form8Agenda.ShowDialog();
             var resultado = _citas.GuardarCitas(citas);
             if (resultado.Exitoso ==true)
             { 
                 label9.Enabled = true;
             }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            var form8Agenda = new Form8Agenda();
            form8Agenda.ShowDialog();
        }
    }
    
}
