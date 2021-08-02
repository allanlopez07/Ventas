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
    public partial class Form12ReporteCitas : Form
    {
        public Form12ReporteCitas()
        {
            InitializeComponent();

            var _citasBL = new CitasBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _citasBL.ObtenerCitas();

            var reporte = new ReporteCitas();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
