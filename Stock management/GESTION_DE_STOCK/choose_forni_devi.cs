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
    public partial class choose_forni_devi : DevExpress.XtraEditors.XtraForm
    {
        gestion_de_stockEntities dbcontex;
        fornisseur fornisseeer;
        devis devissss;
        public choose_forni_devi( int get_choix_button)
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            choix_button = get_choix_button;
            dbcontex = new gestion_de_stockEntities();
            fornisseeer = new fornisseur();
            devissss = new devis();
            fornisseurBindingSource.DataSource = dbcontex.fornisseurSet.ToList();
            devisBindingSource.DataSource = dbcontex.devisSet.ToList();

        }

        int choix_button;
        int id_fornisseur_selctd, id_devis_selctd ;
        private void simpleButton1_Click(object sender, EventArgs e)
        { 
            try
            {
                id_fornisseur_selctd = (int)searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("id_fornisseur");
                id_devis_selctd = (int)searchLookUpEdit2.Properties.View.GetFocusedRowCellValue("id_devis");

                if (choix_button ==1)  // insert new stock in
                {
                    add_new_stock frm = new add_new_stock(id_fornisseur_selctd, id_devis_selctd);
                    frm.Show();
                    frm.simpleButton2.Enabled = false; 
                    frm.searchLookUpEdit1.Properties.ReadOnly = true;
                    this.Close();  
 
                }
                if (choix_button == 2)  // edit   stock in
                {
                    edit_delete_in_stock frm = new edit_delete_in_stock(id_fornisseur_selctd, id_devis_selctd);
                    frm.Show(); 
                    frm.simpleButton4.Hide(); 
                    frm.gridView1.Columns["date_in"].OptionsColumn.AllowEdit = true;
                    this.Close(); 
                }
                if (choix_button == 3)  // delete   stock in
                {
                    edit_delete_in_stock frm = new edit_delete_in_stock(id_fornisseur_selctd, id_devis_selctd);
                    frm.Show(); 
                    frm.simpleButton3.Hide();
                    this.Close(); 
                }
               
              
               
            }
            catch
            {
                MessageBox.Show(" قــــم بتحديد الممـــــل أو الفاتــــــــورة  ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            
             
           
        }


        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (flag == true)
            {
                fornisseurBindingSource.EndEdit();

                textEdit1.Text = (string)searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("prenom_fornisseur");
                textEdit2.Text = (string)searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("societe_fornisseur");

                devisBindingSource.DataSource = dbcontex.devisSet.Where(h => h.fornisseur_id_fornisseur == (int)searchLookUpEdit1.EditValue).ToList();

                searchLookUpEdit2.Properties.ReadOnly = false;   
            }
            else
            {
                fornisseurBindingSource.EndEdit();

                textEdit1.Text = (string)searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("prenom_fornisseur");
                textEdit2.Text = (string)searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("societe_fornisseur");

                devisBindingSource.DataSource = dbcontex.devisSet.Where(h => h.fornisseur_id_fornisseur == (int)searchLookUpEdit1.EditValue && h.stocks_in.Count == 0).ToList();

                searchLookUpEdit2.Properties.ReadOnly = false;   
            }
           

           
        }

        private void searchLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            fornisseurBindingSource.EndEdit();
             
               
                try
                {
                 textEdit3.Text = Convert.ToDateTime(searchLookUpEdit2.Properties.View.GetFocusedRowCellValue("date_facture")).ToShortDateString();
                textEdit4.Text = (searchLookUpEdit2.Properties.View.GetFocusedRowCellValue("anne_facture")).ToString();
                }
                catch  
                {
                    MessageBox.Show("  لاتوجد  فاتــــــــورة  لهذا الممول  ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
    
        }

        bool flag;
        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                flag = true;
                
                Refrechh_alll();
                textEdit3.Text = "";
                textEdit4.Text = "";

            }
            else
            {
                flag = false;  // show all
                Refrechh_alll();
                textEdit3.Text = "";
                textEdit4.Text = "";
            }
        }

        void Refrechh_alll()
        {
            foreach (var entity in dbcontex.ChangeTracker.Entries())
            {
                entity.Reload();
            }
            devisBindingSource.ResetBindings(true);
            devisBindingSource.DataSource = null;
        }
    }
}