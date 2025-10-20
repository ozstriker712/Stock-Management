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
using DevExpress.XtraGrid.Columns;

namespace GESTION_DE_STOCK
{
    public partial class add_new_article : DevExpress.XtraEditors.XtraForm
    {
        gestion_de_stockEntities dbcontex;
        les_articles les_articless;

        public add_new_article()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();

            dbcontex = new gestion_de_stockEntities();
            les_articless = new les_articles();
            lesarticlesBindingSource1.DataSource = dbcontex.les_articlesSet.ToList();   // just for list
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();

            simpleButton2.Enabled = false;

            catgrBindingSource.DataSource = dbcontex.catgrSet.ToList();
         
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            lesarticlesBindingSource.DataSource = les_articless;
            simpleButton1.Enabled = false;
            simpleButton2.Enabled = true;

             searchLookUpEdit1.Enabled = true;
             
            textEdit1.Enabled = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                lesarticlesBindingSource.EndEdit();
                dbcontex.les_articlesSet.Add((les_articles)lesarticlesBindingSource.Current);
                dbcontex.SaveChanges();

                les_articless = new les_articles();
                lesarticlesBindingSource.DataSource = les_articless;

                lesarticlesBindingSource1.DataSource = dbcontex.les_articlesSet.ToList();   // just for list

                simpleButton1.Enabled = true;
                simpleButton2.Enabled = false;

                AlertInfo info = new AlertInfo("", "لقد تمت الاضافة بنجاح");
                alertControl1.Show(this, info);

                searchLookUpEdit1.Enabled = true;
                textEdit1.Enabled = true;
            }
            catch  
            {

                MessageBox.Show("!!  يوجد حقـــــــل فــــارغ . يرجى التــــــــأكد      ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
           
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                dbcontex.SaveChanges();
                lesarticlesBindingSource1.DataSource = dbcontex.les_articlesSet.ToList();   // just for list
                AlertInfo info = new AlertInfo("", "لقد تم التعديل بنجاح");
                alertControl1.Show(this, info);
            }
            catch  
            {

                MessageBox.Show("!!  لايوجـــــــد اي عنصــــر . يرجى التــــــــأكد      ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult reponse = MessageBox.Show(" هل تريد حذف  من قاعدة البيانات ؟؟ ", " Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (DialogResult.OK == reponse)
                {
                    lesarticlesBindingSource1.EndEdit();
                    les_articles delt_lits = (les_articles)lesarticlesBindingSource1.Current;
                    dbcontex.les_articlesSet.Remove(delt_lits);

                    dbcontex.SaveChanges();
                    lesarticlesBindingSource1.DataSource = dbcontex.les_articlesSet.ToList();   // just for list
                    MessageBox.Show(" لقد تم حذف ملـــــــف من قاعدة البيانات ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch  
            {

                MessageBox.Show("!!  لايوجـــــــد اي عنصــــر . يرجى التــــــــأكد      ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
           
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            GridView gridView = gridControl1.FocusedView as GridView;

            if (checkEdit1.Checked)
            {
                GridColumnSortInfo[] sortinfo = { new GridColumnSortInfo(gridView.Columns["catgr.nom_catgr"], DevExpress.Data.ColumnSortOrder.Ascending) };
                gridView.SortInfo.ClearAndAddRange(sortinfo, 2);
            }

            else
            {
                gridView.ClearGrouping();
            }
        }
    }
}