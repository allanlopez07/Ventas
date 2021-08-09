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
    public partial class FormanualUsuario : Form
    {
        public FormanualUsuario()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void FormanualUsuario_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = "Haga doble click para ver el video";
            linkLabel1.Links.Add(0, 0 , "https://www.youtube.com/watch?v=YpLciwXL9pQ&list=PLApO8iXtRCMvqmDeAcwt3Lw9kR7jOeqEe&index=60");
        }
    }
}
