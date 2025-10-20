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

namespace GESTION_DE_STOCK
{
    public partial class show_all_forni_devis : DevExpress.XtraEditors.XtraForm
    {
        gestion_de_stockEntities dbcontex;
        
        public show_all_forni_devis()
        {
            InitializeComponent();
            dbcontex = new gestion_de_stockEntities();
            fornns = new fornisseur();
            deviss = new devis();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();

            fornisseurBindingSource.DataSource = dbcontex.fornisseurSet.ToList();
            //devisBindingSource.DataSource = dbcontex.devisSet.ToList();

        }

        fornisseur fornns;
        int get_id_selct_forn, get_id_devis_selct;
        devis deviss;
      
        private void fornisseurBindingSource_PositionChanged(object sender, EventArgs e)
        {
            stocksinBindingSource.DataSource = null;
           
            fornns = (fornisseur)fornisseurBindingSource.Current;
            get_id_selct_forn = fornns.id_fornisseur;

            devisBindingSource.DataSource = dbcontex.devisSet.Where(mm => mm.fornisseur_id_fornisseur == get_id_selct_forn).ToList();


            
             
        }

        private void devisBindingSource_PositionChanged(object sender, EventArgs e)
        {
            fornns = (fornisseur)fornisseurBindingSource.Current;
            int y = fornns.devis.Count();

            if (y!=0)
            {
                deviss = (devis)devisBindingSource.Current;
                int x = deviss.stocks_in.Count();
                devisBindingSource.DataSource = dbcontex.devisSet.Where(mm => mm.fornisseur_id_fornisseur == get_id_selct_forn).ToList();

                if (x != 0)
                {
                    deviss = (devis)devisBindingSource.Current;
                    get_id_devis_selct = deviss.id_devis;

                    stocksinBindingSource.DataSource = dbcontex.stocks_inSet.Where(aa => aa.devis_id_devis == get_id_devis_selct).ToList();
                }
                else
                {
                    foreach (var entity in dbcontex.ChangeTracker.Entries())
                    {
                        entity.Reload();
                    }
                    stocksinBindingSource.ResetBindings(true);
                    stocksinBindingSource.DataSource = null; 
                        
                }
            }
             
           

        }

 

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            GridView gridView = gridControl3.FocusedView as GridView;

            if (checkEdit1.Checked)
            {
                GridColumnSortInfo[] sortinfo = { new GridColumnSortInfo(gridView.Columns["les_articles.catgr.nom_catgr"], DevExpress.Data.ColumnSortOrder.Ascending) };
                gridView.SortInfo.ClearAndAddRange(sortinfo, 2);
            }

            else
            {
                gridView.ClearGrouping();
            }
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            GridView gridView = gridControl1.FocusedView as GridView;

            if (checkEdit2.Checked)
            {
                GridColumnSortInfo[] sortinfo = { new GridColumnSortInfo(gridView.Columns["anne_facture"], DevExpress.Data.ColumnSortOrder.Ascending) };
                gridView.SortInfo.ClearAndAddRange(sortinfo, 2);
            }

            else
            {
                gridView.ClearGrouping();
            }
        }

        private void gridView3_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >-1)
            {
                GridView view = (GridView)sender;
                e.Info.DisplayText = "N°: " + e.RowHandle.ToString();
           

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

         
     

        
    }
}