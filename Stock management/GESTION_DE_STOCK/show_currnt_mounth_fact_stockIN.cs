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
using DevExpress.XtraGrid.Columns;
using System.Globalization;

namespace GESTION_DE_STOCK
{
    public partial class show_currnt_mounth_fact_stockIN : DevExpress.XtraEditors.XtraForm
    {
        gestion_de_stockEntities dbcontex;
        devis deviss;
        stocks_in stock_innn;
        public show_currnt_mounth_fact_stockIN()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();

            dbcontex = new gestion_de_stockEntities();
            deviss = new devis();
            stock_innn = new stocks_in();

            stocksinBindingSource.DataSource = null; 

            devisBindingSource.DataSource = dbcontex.devisSet.ToList();
            show_current_month_for_devis_stock_inn();
            
           
           

        }

        DateTime first_day_in_month, last_day_in_month;

        void show_current_month_for_devis_stock_inn()  
        {
            DateTime dCalcDate = DateTime.Now;
            first_day_in_month = new DateTime(dCalcDate.Year, dCalcDate.Month, 1);
            last_day_in_month = new DateTime(dCalcDate.Year, dCalcDate.Month, DateTime.DaysInMonth(dCalcDate.Year, dCalcDate.Month));

            filterControl2.SourceControl = gridControl2;
            GridColumn columnCustomer = cardView1.Columns["date_facture"];
            columnCustomer.FilterInfo = new ColumnFilterInfo("[date_facture] between (#" + first_day_in_month.ToString(CultureInfo.InvariantCulture) + "#,#" + last_day_in_month.ToString(CultureInfo.InvariantCulture) + "#)");

            filterControl2.ApplyFilter();

            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            foreach (var entity in dbcontex.ChangeTracker.Entries())
            {
                entity.Reload();
            }


            devisBindingSource.ResetBindings(true);
            devisBindingSource.DataSource = null;
            devisBindingSource.DataSource = dbcontex.devisSet.ToList();
            filterControl2.ApplyFilter();
        }


        int get_id_devi_select;
        private void devisBindingSource_PositionChanged(object sender, EventArgs e)
        {
            deviss = (devis)devisBindingSource.Current;
            if (deviss != null)
            {
                if (cardView1.IsEmpty == false)
                {
                    get_id_devi_select = deviss.id_devis;
                    stocksinBindingSource.DataSource = dbcontex.stocks_inSet.Where(aa => aa.devis_id_devis == get_id_devi_select).ToList();
                    gridControl3.DataSource = dbcontex.stocks_inSet.Where(aa => aa.devis_id_devis == get_id_devi_select).ToList();
                }
                else
                {
                    gridControl3.DataSource = null;
                }
               
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
}