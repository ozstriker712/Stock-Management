using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace GESTION_DE_STOCK.print
{
    public partial class XtraReport4 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport4()
        {
            InitializeComponent();
            xrLabel1.Text = DateTime.Now.ToShortDateString().ToString();
        }

    }
}
