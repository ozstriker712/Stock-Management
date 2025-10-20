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

namespace GESTION_DE_STOCK
{
    public partial class choose__serv_bon : DevExpress.XtraEditors.XtraForm
    {
        gestion_de_stockEntities dbcontex;
        public choose__serv_bon(int get_choix_button)
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            choix_button = get_choix_button;
            dbcontex = new gestion_de_stockEntities();
            les_serv = new les_services();
            les_booon = new les_bon();
            lesservicesBindingSource.DataSource = dbcontex.les_servicesSet.ToList();

            lesbonBindingSource.DataSource = dbcontex.les_bonSet.ToList();

           
        }

        int choix_button;
        int id_serv_selctd, id_bon_selctd;
        les_services les_serv;
        les_bon les_booon;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                id_serv_selctd = (int)searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("id_service");
                id_bon_selctd = (int)searchLookUpEdit2.Properties.View.GetFocusedRowCellValue("id_bon");

                if (choix_button == 4)
                {
                    out_stock frm = new out_stock(id_serv_selctd, id_bon_selctd);
                    frm.Show();
                    frm.simpleButton2.Enabled = false;
                    
                    this.Close();


                    

                }
                if (choix_button == 5)
                {

                    edit_delet_out_stock frm = new edit_delet_out_stock(id_serv_selctd, id_bon_selctd);
                   
                    frm.Show();
         
                    frm.simpleButton4.Hide();
                    frm.searchLookUpEdit1.Properties.ReadOnly = true;
                    frm.gridView1.Columns["date_out"].OptionsColumn.AllowEdit = true;
                    this.Close();
                }
                if (choix_button == 6)
                {
                    edit_delet_out_stock frm = new edit_delet_out_stock(id_serv_selctd, id_bon_selctd);

                    
                    frm.Show();
              
                    frm.simpleButton3.Hide();
 
                    this.Close();
                }



            }
            catch
            {
                MessageBox.Show(" قــــم بتحديــــــــد : المصلــحة   و وصــــل التسليم   ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }


        void Refrechh_alll()
        {
            foreach (var entity in dbcontex.ChangeTracker.Entries())
            {
                entity.Reload();
            }
            lesbonBindingSource.ResetBindings(true);
            lesbonBindingSource.DataSource = null;
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (flag == true)
            {
                lesbonBindingSource.DataSource = dbcontex.les_bonSet.Where(h => h.les_services_id_service == (int)searchLookUpEdit1.EditValue).ToList();
                searchLookUpEdit2.Properties.ReadOnly = false;
                
            }
            else
            {

                lesbonBindingSource.DataSource = dbcontex.les_bonSet.Where(h => h.les_services_id_service == (int)searchLookUpEdit1.EditValue && h.stock_out.Count==0).ToList();
                searchLookUpEdit2.Properties.ReadOnly = false;
               
            }
             
                
           
             
        }

       

        private void searchLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        { 

            try
            {
                
                textEdit1.Text = Convert.ToDateTime(searchLookUpEdit2.Properties.View.GetFocusedRowCellValue("date_bon")).ToShortDateString();
               
            }
            catch
            {
                MessageBox.Show("  لايوجد  وصــــــــــل استلام لهته الملحقفة / الفرع     ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        bool flag;
        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                flag = true;
                Refrechh_alll();
               
              
            }
            else
            {
                flag = false;  // show all
                Refrechh_alll();
            }
        }

       
    }
}