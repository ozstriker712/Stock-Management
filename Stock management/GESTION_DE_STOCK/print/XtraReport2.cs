using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using GESTION_DE_STOCK.model;
using System.Linq;



namespace GESTION_DE_STOCK.print
{
    public partial class XtraReport2 : DevExpress.XtraReports.UI.XtraReport
    {
        int idd_servicess, idd_bonnnn;
        gestion_de_stockEntities dbcontex;

        public XtraReport2(int id_serv, int id_bon)
        {
            InitializeComponent();
            idd_servicess = id_serv;
            idd_bonnnn = id_bon;
            dbcontex = new gestion_de_stockEntities();
            bindingSource1.DataSource = dbcontex.les_bonSet.Where(h => h.les_services_id_service == idd_bonnnn).ToList();
        }

    }
}
