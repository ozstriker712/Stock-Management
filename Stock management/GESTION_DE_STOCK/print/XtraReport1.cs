using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using GESTION_DE_STOCK.model;
using System.Linq;

namespace GESTION_DE_STOCK.print
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        int idd_devviiss, idd_forniss;
        gestion_de_stockEntities dbcontex;
        public XtraReport1(int id_devis , int id_forn)
        {
            InitializeComponent();
            idd_devviiss = id_devis;
            idd_forniss = id_forn;
            dbcontex = new gestion_de_stockEntities();
            bindingSource1.DataSource = dbcontex.devisSet.Where(h => h.fornisseur_id_fornisseur == id_forn).ToList();
        }

    }
}
