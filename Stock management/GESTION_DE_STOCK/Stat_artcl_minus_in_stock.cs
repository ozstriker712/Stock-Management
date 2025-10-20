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

namespace GESTION_DE_STOCK
{
    public partial class Stat_artcl_minus_in_stock : DevExpress.XtraEditors.XtraForm
    {
        gestion_de_stockEntities dbcontex;

        public Stat_artcl_minus_in_stock()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            dbcontex = new gestion_de_stockEntities();
        }

      
        private void checkEdit3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit3.Checked)
            { 
                lesarticlesBindingSource.DataSource = dbcontex.les_articlesSet.Where(h => h.quantite_total == 0).ToList();
            }
            else
            {
                foreach (var entity in dbcontex.ChangeTracker.Entries())
                {
                    entity.Reload();
                }


                lesarticlesBindingSource.ResetBindings(true);
                lesarticlesBindingSource.DataSource = null;
 
            }

           
            
        }

        private void checkEdit4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit4.Checked  )
            { 
                lesarticlesBindingSource.DataSource = dbcontex.les_articlesSet.Where(h => h.quantite_total < 0).ToList();
            }
            else
            {
                foreach (var entity in dbcontex.ChangeTracker.Entries())
                {
                    entity.Reload();
                }


                lesarticlesBindingSource.ResetBindings(true);
                lesarticlesBindingSource.DataSource = null;
 
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

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                int etat = Convert.ToInt32(View.GetRowCellDisplayText(e.RowHandle, View.Columns["quantite_total"]));

                if (etat ==0)
                {
                    e.Appearance.BackColor = Color.GreenYellow;
                    e.Appearance.BackColor2 = Color.SeaShell;

                }
                
                if (etat < 0)
                {
                    e.Appearance.BackColor = Color.Tomato;
                    e.Appearance.BackColor2 = Color.SeaShell;
                }
                
            }


          
        }

        
    }
}