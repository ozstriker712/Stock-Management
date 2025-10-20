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
    public partial class out_stock : DevExpress.XtraEditors.XtraForm
    {
        gestion_de_stockEntities dbcontex;
        stock_out stock_outt;
        les_bon bonn;
        les_articles les_arc_getting;

        public out_stock(int id_servic, int id_bon)
        {
            InitializeComponent();
            dbcontex = new gestion_de_stockEntities();
            stock_outt = new stock_out();
            les_arc_getting = new les_articles();
            bonn = new les_bon();
            id_servicess = id_servic;
            id_bonnn = id_bon;
           
           
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();


            lesarticlesBindingSource.DataSource = dbcontex.les_articlesSet.ToList();

            stockoutBindingSource1.DataSource = dbcontex.stock_outSet.Where(pp => pp.les_bon_id_bon == id_bonnn).ToList(); 
            lesservicesBindingSource.DataSource = dbcontex.les_servicesSet.Where(oo => oo.id_service == id_servicess).ToList();
            lesbonBindingSource.DataSource = dbcontex.les_bonSet.Where(mm => mm.id_bon == id_bonnn).ToList();
 
        }

        int id_bonnn, id_servicess;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            simpleButton1.Enabled = false;
            stockoutBindingSource.DataSource = stock_outt;
            simpleButton2.Enabled = true;
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


       
       

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            bonn = (les_bon)lesbonBindingSource.Current;
             
            try
            {


                if ((Convert.ToInt32(textEdit1.Text)) <= x)  
                {
                    stockoutBindingSource.EndEdit();
                    dbcontex.stock_outSet.Add((stock_out)stockoutBindingSource.Current);
                    stock_outt.les_bon_id_bon = id_bonnn;
                    stock_outt.date_out = bonn.date_bon;
                    stock_outt.prix_article_out = y;

                    dbcontex.SaveChanges();
                    stock_outt = new stock_out();
                    stockoutBindingSource.DataSource = stock_outt;
                    stockoutBindingSource1.DataSource = dbcontex.stock_outSet.Where(pp => pp.les_bon_id_bon == id_bonnn).ToList();
                    simpleButton2.Enabled = false;
                    simpleButton1.Enabled = true;

                    AlertInfo info = new AlertInfo("", "لقد تمت الاضافة بنجاح");
                    alertControl1.Show(this, info);
                    RefreshAll();                    


                }
                else
                {
                    MessageBox.Show(" عدد المخزون المخــــــرج أكبــــــــر من العدد الباقي للمخزون الموجود . يرجى التاكد", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                    
          
               
            }
            catch 
            {

                 MessageBox.Show("يوجد حقـــــــل فــــارغ . يرجى التــــــــأكد   !!", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


       
       

        
    
        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                e.Handled = true;
                MessageBox.Show("  يرجى التاكد من القيم المدخلة ,قيمة سالبة !! ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textEdit1.Text = "";

            }
        }

         
      
         
        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle > -1)
            {
                GridView view = (GridView)sender;
                e.Info.DisplayText = "N°: " + e.RowHandle.ToString();


            }
          
        }

        int x ;
        decimal y;
        
        private void searchLookUpEdit1_EditValueChanged_1(object sender, EventArgs e)
        {
            x = Convert.ToInt32(searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("quantite_total"));
            //les_arc_getting = (les_articles)lesarticlesBindingSource.Current;
            y = Convert.ToDecimal(searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("prixx_artcl_stock"));
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            XtraReport2 frm = new XtraReport2(id_servicess, id_bonnn);
            ReportPrintTool printTool = new ReportPrintTool(frm);
            printTool.ShowPreviewDialog();
        }
      
     


         
    }
}