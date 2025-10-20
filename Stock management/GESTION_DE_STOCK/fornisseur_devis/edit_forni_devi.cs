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
using GESTION_DE_STOCK.fornisseur_devis;

namespace GESTION_DE_STOCK
{
    public partial class edit_forni_devi : DevExpress.XtraEditors.XtraForm
    {
        gestion_de_stockEntities dbcontex;
        fornisseur fornisss;
        devis devisss;
        public edit_forni_devi()
        {
            InitializeComponent();
            dbcontex = new gestion_de_stockEntities();
            fornisss = new fornisseur();
            devisss = new devis();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();

            fornisseurBindingSource.DataSource = dbcontex.fornisseurSet.ToList();
            devisBindingSource.DataSource = dbcontex.devisSet.ToList();

            textEdit7.Text = ""; textEdit6.Text = "";
            show_first_time_on_textedit();

            

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int x = dbcontex.fornisseurSet.Count();
            if (x!=0)
            {
                dbcontex.SaveChanges();
                fornisseurBindingSource.DataSource = dbcontex.fornisseurSet.ToList();
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
            try
            {
                DialogResult reponse = MessageBox.Show(" هل تريد حذف  من قاعدة البيانات ؟؟ ", " Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (DialogResult.OK == reponse)
                {
                    fornisseurBindingSource.EndEdit();
                    fornisseur delt_lits = (fornisseur)fornisseurBindingSource.Current;
                    dbcontex.fornisseurSet.Remove(delt_lits);

                    dbcontex.SaveChanges();
                    fornisseurBindingSource.DataSource = dbcontex.fornisseurSet.ToList();   // just for list
                    MessageBox.Show(" لقد تم حذف ملـــــــف من قاعدة البيانات ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch 
            {
                MessageBox.Show("!!  لايوجـــــــد اي عنصــــر . يرجى التــــــــأكد      ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                
            }
            
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            int x =  dbcontex.devisSet.Count();
            if (x!=0)
            {
                dbcontex.SaveChanges();
                devisBindingSource.DataSource = dbcontex.devisSet.ToList();
                AlertInfo info = new AlertInfo("", "لقد تم التعديل بنجاح");
                alertControl1.Show(this, info);
            }
            else
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
                    devisBindingSource.EndEdit();
                    devis delt_lits = (devis)devisBindingSource.Current;
                    dbcontex.devisSet.Remove(delt_lits);

                    dbcontex.SaveChanges();
                    devisBindingSource.DataSource = dbcontex.devisSet.ToList();   // just for list
                    MessageBox.Show(" لقد تم حذف ملـــــــف من قاعدة البيانات ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch  
            {
                MessageBox.Show("!!  لايوجـــــــد اي عنصــــر . يرجى التــــــــأكد      ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                 
            }
           
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            //textEdit7.Text = ""; textEdit6.Text = "";

            //devisss = (devis)devisBindingSource.Current;
            //if (devisss.stocks_in.Count() != 0)
            //{
            //    textEdit7.Text = devisss.fornisseur.nom_fornisseur.ToString();
            //    textEdit6.Text = devisss.fornisseur.prenom_fornisseur.ToString();

            //}


            fornisseurBindingSource.EndEdit();

            textEdit6.Text = (string)searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("prenom_fornisseur");
            textEdit7.Text = (string)searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("societe_fornisseur");
 
        }

       

        private void devisBindingSource_PositionChanged(object sender, EventArgs e)
        {
            //devisss = (devis)devisBindingSource.Current;
            //if (devisss.stocks_in.Count() !=0)
            //{
            //    textEdit7.Text = devisss.fornisseur.nom_fornisseur.ToString();
            //    textEdit6.Text = devisss.fornisseur.prenom_fornisseur.ToString();
               
            //}
             
        }

        void show_first_time_on_textedit()
        {
            devisss = (devis)devisBindingSource.Current;
            if (devisss != null)
            {
                textEdit7.Text = devisss.fornisseur.nom_fornisseur.ToString();
                textEdit6.Text = devisss.fornisseur.prenom_fornisseur.ToString();

            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            fornisss = (fornisseur)fornisseurBindingSource.Current;
            add_activite_fornisseur frm = new add_activite_fornisseur(fornisss.id_fornisseur);
            frm.Show();
        }

       
       
    }
}