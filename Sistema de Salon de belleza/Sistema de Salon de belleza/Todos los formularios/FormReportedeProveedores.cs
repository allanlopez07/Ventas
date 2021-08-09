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
    public partial class FormReportedeProveedores : Form
    {
        public FormReportedeProveedores()
        {
            InitializeComponent();
            var _proveedores = new ProveedoresBL();
            var bindinSourse = new BindingSource();
            bindinSourse.DataSource = _proveedores.ObtenerProveedores();

            var reporte = new ReporteProveedores();
            reporte.SetDataSource(bindinSourse);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
