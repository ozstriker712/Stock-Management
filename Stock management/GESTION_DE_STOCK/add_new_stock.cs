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
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraGrid.Views.Grid;
using GESTION_DE_STOCK.print;
using DevExpress.XtraReports.UI;

namespace GESTION_DE_STOCK
{
    public partial class add_new_stock : DevExpress.XtraEditors.XtraForm
    {
        gestion_de_stockEntities dbcontex;
        stocks_in stock_inn;
        les_articles les_articless;
        fornisseur fornisser;
        devis devisss;
        public add_new_stock(int id_frnsr , int id_devi)
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();

             id_fornisseurrrr = id_frnsr;
             id_devisss = id_devi;

            dbcontex = new gestion_de_stockEntities();
            stock_inn = new stocks_in();
            les_articless = new les_articles();
            fornisser = new fornisseur();

            lesarticlesBindingSource.DataSource = dbcontex.les_articlesSet.ToList();
            
            
            stocksinBindingSource1.DataSource = dbcontex.stocks_inSet.Where(aa => aa.devis_id_devis == id_devisss).ToList();  // showing for good list
            fornisseurBindingSource.DataSource = dbcontex.fornisseurSet.Where(aa => aa.id_fornisseur == id_frnsr).ToList();
            devisBindingSource.DataSource = dbcontex.devisSet.Where(aa => aa.id_devis == id_devisss).ToList();
 
        }

        int id_devisss, id_fornisseurrrr;
        private void simpleButton2_Click(object sender, EventArgs e)
        { 
            devisss = (devis)devisBindingSource.Current;

            try
            {
                stocksinBindingSource.EndEdit();
                dbcontex.stocks_inSet.Add((stocks_in)stocksinBindingSource.Current);
                stock_inn.devis_id_devis = id_devisss;
                stock_inn.date_in = devisss.date_facture;
                
                dbcontex.SaveChanges();

                stock_inn = new stocks_in();
                stocksinBindingSource.DataSource = stock_inn;
                stocksinBindingSource1.DataSource = dbcontex.stocks_inSet.Where(aa => aa.devis_id_devis == id_devisss).ToList(); // just for List

                simpleButton2.Enabled = false;
                simpleButton1.Enabled = true ;

                AlertInfo info = new AlertInfo("", "لقد تمت الاضافة بنجاح");
                alertControl1.Show(this, info);
                searchLookUpEdit1.Properties.ReadOnly = true;

                RefreshAll();
            }
            catch  
            {

                MessageBox.Show("!!  يوجد حقـــــــل فــــارغ . يرجى التــــــــأكد      ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

       
      
        
       

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                e.Handled = true;
                MessageBox.Show(" !! يرجـــــــــى التاكـــــد من القيم المدخلـة ,قيمـــة سالبـــة   ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textEdit1.Text = "";

            }
            
        }


        public void RefreshAll()
        {
            foreach (var entity in dbcontex.ChangeTracker.Entries())
            {
                entity.Reload();
            }
            lesarticlesBindingSource.ResetBindings(true);
            lesarticlesBindingSource.DataSource = dbcontex.les_articlesSet.ToList();

        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle > -1)
            {
                GridView view = (GridView)sender;
                e.Info.DisplayText = "N°: " + e.RowHandle.ToString();


            }
          
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            simpleButton1.Enabled = false;
            stocksinBindingSource.DataSource = stock_inn;
            simpleButton2.Enabled = true;
            searchLookUpEdit1.Properties.ReadOnly = false;
            
        }
 

        private void simpleButton3_Click(object sender, EventArgs e)
        { 
            XtraReport1 frm = new XtraReport1(id_fornisseurrrr, id_devisss);
            ReportPrintTool printTool = new ReportPrintTool(frm);
            printTool.ShowPreviewDialog();
          
        }
    }
}