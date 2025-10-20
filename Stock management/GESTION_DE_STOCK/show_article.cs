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
using DevExpress.XtraGrid.Columns;
using System.IO;
using System.Diagnostics;
using GESTION_DE_STOCK.print;
using DevExpress.XtraReports.UI;

namespace GESTION_DE_STOCK
{
    public partial class show_article : DevExpress.XtraEditors.XtraForm
    {
        gestion_de_stockEntities dbcontex;
        

        public show_article()
        {
            InitializeComponent();
            dbcontex = new gestion_de_stockEntities();
            lesarticlesBindingSource.DataSource = dbcontex.les_articlesSet.Where(g => g.quantite_total != null).ToList();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();

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

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit2.Checked)
            {
                foreach (var entity in dbcontex.ChangeTracker.Entries())
                {
                    entity.Reload();
                }


                lesarticlesBindingSource.ResetBindings(true);
                lesarticlesBindingSource.DataSource = null;

                lesarticlesBindingSource.DataSource = dbcontex.les_articlesSet.ToList();
            }
            else
            {
                foreach (var entity in dbcontex.ChangeTracker.Entries())
                {
                    entity.Reload();
                }


                lesarticlesBindingSource.ResetBindings(true);
                lesarticlesBindingSource.DataSource = null;

                lesarticlesBindingSource.DataSource = dbcontex.les_articlesSet.Where(g => g.quantite_total != null).ToList();

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;


                    gridView1.ExportToXls(exportFilePath);
                    Process proc = new Process();
                    proc.StartInfo.FileName = exportFilePath;
                    proc.StartInfo.UseShellExecute = true;
                    proc.Start();

                }
            }
        }

       
        private void simpleButton2_Click(object sender, EventArgs e)
        {
             
            XtraReport4 frm = new XtraReport4();
            frm.DataSource = dbcontex.les_articlesSet.Where(r => r.quantite_total != 0).Where(r => r.quantite_total != null).ToList();
            ReportPrintTool printTool = new ReportPrintTool(frm);
            printTool.ShowPreviewDialog();
        }

         

        
    }
}