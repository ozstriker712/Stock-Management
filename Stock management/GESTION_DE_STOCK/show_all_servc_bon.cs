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
    public partial class show_all_servc_bon : DevExpress.XtraEditors.XtraForm
    {
        gestion_de_stockEntities dbcontex;
        les_services service;
        les_bon les_bonnn;
        stocks_in stock_innn;

        public show_all_servc_bon()
        {
            InitializeComponent();
            dbcontex = new gestion_de_stockEntities();
            service = new les_services();
            les_bonnn = new les_bon();
            stock_innn = new stocks_in();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();

            lesservicesBindingSource.DataSource = dbcontex.les_servicesSet.ToList();
            
        }
        int get_id_selct_serv, get_id_bon_selct;
        private void lesservicesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            stockoutBindingSource.DataSource = null;
            service = (les_services)lesservicesBindingSource.Current;
            get_id_selct_serv = service.id_service;
  
            lesbonBindingSource.DataSource = dbcontex.les_bonSet.Where(m => m.les_services_id_service == get_id_selct_serv).ToList();
        }

        private void lesbonBindingSource_PositionChanged(object sender, EventArgs e)
        {
            service = (les_services)lesservicesBindingSource.Current;
            int y = service.les_bon.Count();
             
            if (y  != 0)
            {
                les_bonnn = (les_bon)lesbonBindingSource.Current;
                int x = les_bonnn.stock_out.Count();
                lesbonBindingSource.DataSource = dbcontex.les_bonSet.Where(m => m.les_services_id_service == get_id_selct_serv).ToList();


                if (x != 0)
                {
                    les_bonnn = (les_bon)lesbonBindingSource.Current;
                    get_id_bon_selct = les_bonnn.id_bon;
                    stockoutBindingSource.DataSource = dbcontex.stock_outSet.Where(k => k.les_bon_id_bon == get_id_bon_selct).ToList();
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
            
           
        }

        

        private void gridView3_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle > -1)
            {
                GridView view = (GridView)sender;
                e.Info.DisplayText = "N°: " + e.RowHandle.ToString();


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

       
         
    }
}