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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraBars.Alerter;
using GESTION_DE_STOCK.print;
using DevExpress.XtraReports.UI;

namespace GESTION_DE_STOCK
{
    public partial class edit_delet_out_stock : DevExpress.XtraEditors.XtraForm
    {
        gestion_de_stockEntities dbcontex;
        stock_out stock_outt;
        int id_bonnn, id_servicess;

        les_bon bon;


        public edit_delet_out_stock(int id_servic, int id_bon)
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            id_servicess = id_servic;
            id_bonnn = id_bon;
            dbcontex = new gestion_de_stockEntities();
            bon = new les_bon();

            stock_outt = new stock_out();
           

            lesarticlesBindingSource.DataSource = dbcontex.les_articlesSet.ToList();

            stockoutBindingSource.DataSource = dbcontex.stock_outSet.Where(pp => pp.les_bon_id_bon == id_bonnn).ToList();
            lesservicesBindingSource.DataSource = dbcontex.les_servicesSet.Where(oo => oo.id_service == id_servicess).ToList();
            lesbonBindingSource.DataSource = dbcontex.les_bonSet.Where(mm => mm.id_bon == id_bonnn).ToList();

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

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult reponse = MessageBox.Show(" هل تريد حذف  من قاعدة البيانات ؟؟ ", " Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (DialogResult.OK == reponse)
                {
                    stockoutBindingSource.EndEdit();
                    stock_out delt_lits = (stock_out)stockoutBindingSource.Current;
                    dbcontex.stock_outSet.Remove(delt_lits);

                    dbcontex.SaveChanges();
                    stockoutBindingSource.DataSource = dbcontex.stock_outSet.ToList();
                    MessageBox.Show(" لقد تم الحــــــــــــــذف  من قاعدة البيانات ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {

                MessageBox.Show("!!  لايوجـــــــد اي عنصــــر . يرجى التــــــــأكد      ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        int val1, val2;
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                stockoutBindingSource.EndEdit();
                bon = (les_bon)lesbonBindingSource.Current;
                if ((Convert.ToInt32(textEdit1.Text)) <= val1 + val2)
                {

                    dbcontex.SaveChanges();

                    AlertInfo info = new AlertInfo("", "لقد تم التعديل بنجاح");
                    alertControl1.Show(this, info);
                }
                else
                {
                    MessageBox.Show(" عدد المخزون المخــــــرج أكبــــــــر من العدد الباقي للمخزون الموجود . يرجى التاكد", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
            }
            catch
            {

                MessageBox.Show("!!  لايوجـــــــد اي عنصــــر . يرجى التــــــــأكد      ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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


         
        private void stockoutBindingSource_PositionChanged(object sender, EventArgs e)
        {
            stock_outt = (stock_out)stockoutBindingSource.Current;

            if (stock_outt != null)
            {
                stockoutBindingSource.EndEdit();
                stock_outt = (stock_out)stockoutBindingSource.Current;
                val1 = stock_outt.quantite_out;
                 

            }

            int wiw = dbcontex.les_bonSet.Where(mm => mm.id_bon == id_bonnn).Count();
            if (wiw != 0)
            {
                val2 = stock_outt.les_articles.quantite_total.Value;
                

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            XtraReport2 frm = new XtraReport2(id_servicess, id_bonnn);
            ReportPrintTool printTool = new ReportPrintTool(frm);
            printTool.ShowPreviewDialog();
        }

       

         
    }
}