﻿using BL.Rentas;
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
    public partial class FormReportedeVentas : Form
    {
        public FormReportedeVentas()
        {
            InitializeComponent();
            var _factura = new FacturaBL();
            var bindinSourse = new BindingSource();
            bindinSourse.DataSource = _factura.ObtenerFacturas();

            var reporte = new ReporteVentas();
            reporte.SetDataSource(bindinSourse);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
