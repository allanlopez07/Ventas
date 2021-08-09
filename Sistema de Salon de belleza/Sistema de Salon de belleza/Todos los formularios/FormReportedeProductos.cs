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
    public partial class FormReportedeProductos : Form
    {
        public FormReportedeProductos()
        {
            InitializeComponent();

            var _productoBL = new ProductosBL();
            var bindinSourse = new BindingSource();
            bindinSourse.DataSource = _productoBL.ObtenerProductos();

            var reporte = new ReporteProductos();
            reporte.SetDataSource(bindinSourse);

            crystalReportViewer2.ReportSource = reporte;
            crystalReportViewer2.RefreshReport();
        }

        private void FormReportedeProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
