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
using DevExpress.XtraGrid.Columns;
using System.Globalization;

namespace GESTION_DE_STOCK
{
    public partial class Detail_Devis_chaque_forni : DevExpress.XtraEditors.XtraForm
    {
        gestion_de_stockEntities dbcontex;
        int id_fornisseur;
    
        stocks_in stock_innn;
        public Detail_Devis_chaque_forni( int id_fornisss)
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            dbcontex = new gestion_de_stockEntities();

            id_fornisseur = id_fornisss;

            fornisseurBindingSource.DataSource = dbcontex.fornisseurSet.Where(h => h.id_fornisseur == id_fornisseur).ToList();

            devisBindingSource.DataSource = dbcontex.devisSet.Where(h => h.fornisseur_id_fornisseur == id_fornisseur).ToList();


            stocksinBindingSource.DataSource = dbcontex.stocks_inSet.Where(j => j.devis.fornisseur_id_fornisseur == id_fornisseur).ToList(); // all devis for chaque fornisseur

            show_current_year();
        }

        DateTime first_day_in_year, last_day_in_year;

        void show_current_year() // for STOCK OUTTt  & BONNN & SERvice 
        {
            DateTime dCalcDate = DateTime.Now;
            first_day_in_year = new DateTime(dCalcDate.Year, 1, 1);
            last_day_in_year = new DateTime(dCalcDate.Year, 12, 1);

            
            filterControl1.SourceControl = gridControl1;
            GridColumn columnCustomer = gridView1.Columns["devis.date_facture"];
            columnCustomer.FilterInfo = new ColumnFilterInfo("[devis.date_facture] between (#" + first_day_in_year.ToString(CultureInfo.InvariantCulture) + "#,#" + last_day_in_year.ToString(CultureInfo.InvariantCulture) + "#)");
             
            filterControl1.ApplyFilter();
 

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
         
        }

         

        int id_devi_gett;
        private void stocksinBindingSource_PositionChanged(object sender, EventArgs e)
        {
            stock_innn = (stocks_in)stocksinBindingSource.Current;
            id_devi_gett = stock_innn.devis_id_devis;

            textEdit6.Text = dbcontex.stocks_inSet.Where(j => j.devis.fornisseur_id_fornisseur == id_fornisseur && j.devis.id_devis == id_devi_gett).Count().ToString(); 
            textEdit2.Text = dbcontex.stocks_inSet.Where(j => j.devis.fornisseur_id_fornisseur == id_fornisseur && j.devis.id_devis == id_devi_gett).Sum(h => h.prix_in_unitaire_x_quntite).ToString();

        }

      


    }
}