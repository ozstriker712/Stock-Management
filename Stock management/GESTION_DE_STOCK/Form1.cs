using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GESTION_DE_STOCK.model;
using DevExpress.XtraGrid.Columns;
using System.Globalization;
using DevExpress.XtraGrid.Views.Grid;
using GESTION_DE_STOCK.print;
using DevExpress.XtraReports.UI;
using GESTION_DE_STOCK.fornisseur_devis;

namespace GESTION_DE_STOCK
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        gestion_de_stockEntities dbcontex;
        les_services les_sevrc;
        les_bon les_bonn;
        stock_out stock_outt;

        int id_userrr_public; string user_name;

        public Form1(int id_user_public, string user_name_public) //
        {
            InitializeComponent();
            dbcontex = new gestion_de_stockEntities();
            les_sevrc = new les_services();
            les_bonn = new les_bon();
            stock_outt = new stock_out();


            id_userrr_public = id_user_public; user_name = user_name_public;

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged(); 
            textEdit1.Text = user_name_public;

           
            lesbonBindingSource.DataSource = dbcontex.les_bonSet.ToList();
            show_current_month_for_bonnn_stock_outt();
           
        }

        DateTime first_day_in_month, last_day_in_month;

        void show_current_month_for_bonnn_stock_outt() // for STOCK OUTTt  & BONNN & SERvice 
        { 
            DateTime dCalcDate = DateTime.Now;
            first_day_in_month = new DateTime(dCalcDate.Year, dCalcDate.Month, 1);
            last_day_in_month = new DateTime(dCalcDate.Year, dCalcDate.Month, DateTime.DaysInMonth(dCalcDate.Year, dCalcDate.Month));

            filterControl2.SourceControl = gridControl2;
            GridColumn columnCustomer = cardView1.Columns["date_bon"];
            columnCustomer.FilterInfo = new ColumnFilterInfo("[date_bon] between (#" + first_day_in_month.ToString(CultureInfo.InvariantCulture) + "#,#" + last_day_in_month.ToString(CultureInfo.InvariantCulture) + "#)");

            
            filterControl2.ApplyFilter();
        }

       


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            add_new_article frm = new add_new_article();
            
            frm.Show();
            frm.xtraTabPage2.PageVisible = false;
            frm.searchLookUpEdit1.Enabled = false;
            textEdit1.Enabled = false;

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            add_new_article frm = new add_new_article();
            
            frm.Show();
            frm.xtraTabPage1.PageVisible = false;
        }

        

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            show_article frm = new show_article();
            frm.Show();
        }

         
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            choix_boutton = 2;
            choose_forni_devi frm = new choose_forni_devi(choix_boutton);
            frm.Show();
            frm.searchLookUpEdit2.Properties.ReadOnly = true;
            frm.checkEdit1.Checked = true;

            

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            choix_boutton = 3;
            choose_forni_devi frm = new choose_forni_devi(choix_boutton);
            frm.Show();
            frm.searchLookUpEdit2.Properties.ReadOnly = true;
            frm.checkEdit1.Checked = true;
          
       
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            users_form frm = new users_form();
            frm.xtraTabPage2.PageVisible = false;
            frm.gridView1.OptionsBehavior.ReadOnly = true;
            frm.Show();

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            users_form frm = new users_form();
            frm.xtraTabPage1.PageVisible = false;
            frm.gridView1.OptionsBehavior.ReadOnly = false;
            frm.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            about frm = new about();
            frm.Show();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            choix_boutton = 4; // insert

            choose__serv_bon frm = new choose__serv_bon(choix_boutton);
            frm.Show();
            frm.searchLookUpEdit2.Properties.ReadOnly = true;   

            
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            choix_boutton = 5; // insert
            choose__serv_bon frm = new choose__serv_bon(choix_boutton);
            frm.Show();
            frm.searchLookUpEdit2.Properties.ReadOnly = true;
            frm.checkEdit1.Checked = true;
            

        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            choix_boutton = 6; // insert
            choose__serv_bon frm = new choose__serv_bon(choix_boutton);
            frm.Show();
            frm.searchLookUpEdit2.Properties.ReadOnly = true;
            frm.checkEdit1.Checked = true;
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new_forn_devi frm = new new_forn_devi();
            frm.Show();
            frm.simpleButton1.Enabled = false;

            //frm.simpleButton4.Enabled = true;
            //frm.simpleButton2.Enabled = false;

            //frm.searchLookUpEdit1.Enabled = false;

        }

        int choix_boutton;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            choix_boutton = 1; // insert
            choose_forni_devi frm = new choose_forni_devi(choix_boutton);
            frm.Show();
            frm.searchLookUpEdit2.Properties.ReadOnly = true;

            
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            new_serv frm = new new_serv();
            frm.Show();
            frm.simpleButton1.Enabled = false;

           
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            catgr_artcl frm = new catgr_artcl();

            frm.Show();
            frm.textEdit1.Enabled = false;
            frm.simpleButton3.Hide(); frm.simpleButton4.Hide(); frm.textEdit2.Hide();
           


        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            catgr_artcl frm = new catgr_artcl();
            frm.Show();
            frm.simpleButton1.Hide();
            frm.simpleButton2.Hide();
            frm.textEdit1.Hide();

            
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            edit_forni_devi frm = new edit_forni_devi();
            frm.Show();

            frm.xtraTabPage2.PageVisible = false;
             
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            edit_forni_devi frm = new edit_forni_devi();
            frm.Show();
            frm.xtraTabPage1.PageVisible = false;
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            edit_serv_bon frm = new edit_serv_bon();
            frm.Show();
            frm.xtraTabPage2.PageVisible = false;
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            edit_serv_bon frm = new edit_serv_bon();
            frm.Show();
            frm.xtraTabPage1.PageVisible = false;
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            save_data_base frm = new save_data_base();
            frm.Show();
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            show_all_forni_devis frm = new show_all_forni_devis();
            frm.Show();
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            show_all_servc_bon frm = new show_all_servc_bon();
            frm.Show();
        }


        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle > -1)
            {
                GridView view = (GridView)sender;
                e.Info.DisplayText = "N°: " + e.RowHandle.ToString();


            }
          
        }

     
       

        private void lesbonBindingSource_PositionChanged(object sender, EventArgs e)   //   المخرجـــــــــــــــات
        {
            les_bonn = (les_bon)lesbonBindingSource.Current;


            if (les_bonn != null)
            { 
 
                    //stock_outt = (stock_out)stockoutBindingSource.Current;
                    int get_id_bon_selct = les_bonn.id_bon;
                    if (cardView1.IsEmpty == true)
                    {
                        gridControl1.DataSource = null;
                    }
                    else
                    {
                        stockoutBindingSource.DataSource = dbcontex.stock_outSet.Where(k => k.les_bon_id_bon == get_id_bon_selct).ToList();
                        gridControl1.DataSource = dbcontex.stock_outSet.Where(k => k.les_bon_id_bon == get_id_bon_selct).ToList();
                    }
                   
             }
            else
            {
                foreach (var entity in dbcontex.ChangeTracker.Entries())
                {
                    entity.Reload();
                }
                stockoutBindingSource.ResetBindings(true);
                stockoutBindingSource.DataSource = null;
                
                
            }
                 
             
        }

       
        
        private void barCheckItem1_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barCheckItem1.Checked)
            {
                if (gridView1.IsEmpty== true)
                {
                    gridControl1.DataSource = null;
                }
                else
                {
            
                    foreach (var entity in dbcontex.ChangeTracker.Entries())
                    {
                        entity.Reload();
                    }


                    lesbonBindingSource.ResetBindings(true);
                    lesbonBindingSource.DataSource = null;
                    lesbonBindingSource.DataSource = dbcontex.les_bonSet.ToList();
                    gridControl1.DataSource = null;
                    

                    show_current_month_for_bonnn_stock_outt();
                 
                }
                
                   
            
            }
 
            
        }

       
     
        private void simpleButton1_Click(object sender, EventArgs e)
        {
        
            
            foreach (var entity in dbcontex.ChangeTracker.Entries())
            {
                entity.Reload();
            }

            lesbonBindingSource.ResetBindings(true);
            lesbonBindingSource.DataSource = null;
            lesbonBindingSource.DataSource = dbcontex.les_bonSet.ToList();

            filterControl2.ApplyFilter();
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            show_currnt_mounth_fact_stockIN frm = new show_currnt_mounth_fact_stockIN();
            frm.Show();
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Stat_Global frm = new Stat_Global();
            frm.Show();

        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            stat_forn_stockIN frm = new stat_forn_stockIN();
            frm.Show();
        }

        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Stat_devis_stockOUT frm = new Stat_devis_stockOUT();
            frm.Show();
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Setting_Prices frm = new Setting_Prices(id_userrr_public, user_name, false);
            frm.Show();
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            show_article frm = new show_article();
            frm.Show();
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Stat_artcl_minus_in_stock frm = new Stat_artcl_minus_in_stock();
            frm.Show();
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start(@".\TeamViewer\TeamViewer.exe");

        }

        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraReport4 frm = new XtraReport4();
            frm.DataSource = dbcontex.les_articlesSet.Where(r => r.quantite_total != 0).Where(r => r.quantite_total != null).ToList();
            ReportPrintTool printTool = new ReportPrintTool(frm);
            printTool.ShowPreviewDialog();
        }

        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new_bon frm = new new_bon();
            frm.Show();
            frm.simpleButton2.Enabled = false;
        }

        private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new_devi frm = new new_devi();
            frm.Show();
        }

      
        
    }
}
