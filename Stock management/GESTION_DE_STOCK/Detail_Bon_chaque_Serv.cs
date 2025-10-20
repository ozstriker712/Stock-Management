using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GESTION_DE_STOCK.model;
using System.Globalization;
using DevExpress.XtraGrid.Columns;

namespace GESTION_DE_STOCK
{
    public partial class Detail_Bon_chaque_Serv : DevExpress.XtraEditors.XtraForm
    {
        gestion_de_stockEntities dbcontex;
        int id_service;
        stock_out stock_outttt;

        public Detail_Bon_chaque_Serv(int id_srvc)
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            dbcontex = new gestion_de_stockEntities();

            id_service = id_srvc;


            lesservicesBindingSource.DataSource = dbcontex.les_servicesSet.Where(h => h.id_service == id_service).ToList();

            lesbonBindingSource.DataSource = dbcontex.les_bonSet.Where(h => h.les_services_id_service == id_service).ToList();


            stockoutBindingSource.DataSource = dbcontex.stock_outSet.Where(j => j.les_bon.les_services_id_service == id_service).ToList(); // all devis for chaque fornisseur

            show_current_year();

        }


        DateTime first_day_in_year, last_day_in_year;

        void show_current_year() // for STOCK INNN  & BONN & SERvice 
        {
            DateTime dCalcDate = DateTime.Now;
            first_day_in_year = new DateTime(dCalcDate.Year, 1, 1);
            last_day_in_year = new DateTime(dCalcDate.Year, 12, 1);


            filterControl1.SourceControl = gridControl1;
            GridColumn columnCustomer = gridView1.Columns["les_bon.date_bon"];
            columnCustomer.FilterInfo = new ColumnFilterInfo("[les_bon.date_bon] between (#" + first_day_in_year.ToString(CultureInfo.InvariantCulture) + "#,#" + last_day_in_year.ToString(CultureInfo.InvariantCulture) + "#)");

            filterControl1.ApplyFilter();

            //calculate_detail();

        }


        void calculate_detail()
        {
            try
            { 
                textEdit6.Text = dbcontex.stock_outSet.Where(j => j.les_bon.les_services_id_service == id_service && j.les_bon.id_bon == id_bon_gett).Count().ToString();

                textEdit2.Text = dbcontex.stock_outSet.Where(j => j.les_bon.les_services_id_service == id_service && j.les_bon.id_bon == id_bon_gett).Sum(h => h.prix_out_unitaire_x_quantite).ToString();

            }
            catch
            {

                MessageBox.Show("!!  لايوجـــــــد اي عنصــــر . يرجى التــــــــأكد      ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        int id_bon_gett;
        private void stockoutBindingSource_PositionChanged(object sender, EventArgs e)
        {
            stock_outttt = (stock_out)stockoutBindingSource.Current;
            id_bon_gett = stock_outttt.les_bon_id_bon;
            calculate_detail();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }
    }
}