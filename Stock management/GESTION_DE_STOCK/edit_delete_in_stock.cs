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
    public partial class edit_delete_in_stock : DevExpress.XtraEditors.XtraForm
    {
        gestion_de_stockEntities dbcontex;
        stocks_in stock_inn;
        les_articles les_articless;
        fornisseur fornisser;
        devis devisss;
        int id_devisss, id_fornisseurrrr;

        public edit_delete_in_stock(int id_frnsr, int id_devi)
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


            stocksinBindingSource.DataSource = dbcontex.stocks_inSet.Where(aa => aa.devis_id_devis == id_devisss).ToList();
            fornisseurBindingSource.DataSource = dbcontex.fornisseurSet.Where(aa => aa.id_fornisseur == id_frnsr).ToList();
            devisBindingSource.DataSource = dbcontex.devisSet.Where(aa => aa.id_devis == id_devisss).ToList();


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

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                e.Handled = true;
                MessageBox.Show(" !! يرجـــــــــى التاكـــــد من القيم المدخلـة ,قيمـــة سالبـــة   ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textEdit1.Text = "";

            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult reponse = MessageBox.Show(" هل تريد حذف  من قاعدة البيانات ؟؟ ", " Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (DialogResult.OK == reponse)
                {
                    stocksinBindingSource.EndEdit();
                    stocks_in delt_lits = (stocks_in)stocksinBindingSource.Current;
                    dbcontex.stocks_inSet.Remove(delt_lits);
                    dbcontex.SaveChanges();
                    stocksinBindingSource.DataSource = dbcontex.stocks_inSet.Where(aa => aa.devis_id_devis == id_devisss).ToList(); // just for List 
                    MessageBox.Show(" لقد تم الحــــــــــــــذف  من قاعدة البيانات ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    AlertInfo info = new AlertInfo("", "لقد تم الحذف بنجاح");
                    alertControl1.Show(this, info);
                }
            }
            catch
            {

                MessageBox.Show("!!  لايوجـــــــد اي عنصــــر . يرجى التــــــــأكد      ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            stocksinBindingSource.EndEdit();
            devisss = (devis)devisBindingSource.Current;
            int x = dbcontex.stocks_inSet.Where(aa => aa.devis_id_devis == id_devisss).Count();
            if (x != 0)
            {

                dbcontex.SaveChanges();
                stocksinBindingSource.DataSource = dbcontex.stocks_inSet.Where(aa => aa.devis_id_devis == id_devisss).ToList(); // just for List 
                AlertInfo info = new AlertInfo("", "لقد تم التعديل بنجاح");
                alertControl1.Show(this, info);
            }
            else
            {
                MessageBox.Show("!!  لايوجـــــــد اي عنصــــر . يرجى التــــــــأكد      ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            stock_inn = (stocks_in)stocksinBindingSource.Current;
            XtraReport1 frm = new XtraReport1(id_fornisseurrrr, id_devisss);
            ReportPrintTool printTool = new ReportPrintTool(frm);
            printTool.ShowPreviewDialog();
        }

    }
}