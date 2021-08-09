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
    public partial class FormReporte_de_Citas : Form
    {
        public FormReporte_de_Citas()
        {
            InitializeComponent();

            var _citas = new CitasBL();
            var bindinSourse = new BindingSource();
            bindinSourse.DataSource = _citas.ObtenerCitas();

            var reporte = new ReporteCitas();
            reporte.SetDataSource(bindinSourse);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
