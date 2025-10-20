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
    public partial class new_forn_devi : DevExpress.XtraEditors.XtraForm
    {
        gestion_de_stockEntities dbcontex;
        devis deviss;
        fornisseur fornisseuur, get_fornisseuur; 
        public new_forn_devi()
        {
            InitializeComponent();
            dbcontex = new gestion_de_stockEntities();
            deviss = new devis();
            fornisseuur = new fornisseur();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            //fornisseurBindingSource.DataSource = dbcontex.fornisseurSet.ToList(); 
            //textEdit1.Enabled = false; textEdit4.Enabled = false; textEdit5.Enabled = false;
            simpleButton4.Enabled = false; simpleButton2.Enabled = false;
        }


        int id_get; 
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            try
            {
                fornisseurBindingSource.EndEdit();
                dbcontex.fornisseurSet.Add((fornisseur)fornisseurBindingSource.Current); 
                    dbcontex.SaveChanges();
                    get_fornisseuur = (fornisseur)fornisseurBindingSource.Current ;
                    
                    simpleButton3.Enabled = true;
                    simpleButton1.Enabled = false;
                    fornisseurBindingSource.DataSource = dbcontex.fornisseurSet.Where(h => h.id_fornisseur == fornisseuur.id_fornisseur).ToList();
                    AlertInfo info = new AlertInfo("", "لقد تمت الاضافة بنجاح");
                    alertControl1.Show(this, info); 
                    //textEdit1.Enabled = false; textEdit4.Enabled = false; textEdit5.Enabled = false; 

                    id_get = get_fornisseuur.id_fornisseur;
                    add_activite_fornisseur frm = new add_activite_fornisseur(id_get);
                    frm.Show();
                    simpleButton4.Enabled = true; simpleButton2.Enabled = true;

            }
            catch  
            {

                MessageBox.Show("!!  يوجد حقـــــــل فــــارغ . يرجى التــــــــأكد      ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
           
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            fornisseuur = new fornisseur();
           
            fornisseurBindingSource.EndEdit();
            fornisseurBindingSource.DataSource = fornisseuur;
             
            simpleButton3.Enabled = false;
            simpleButton1.Enabled = true; 
            //textEdit1.Enabled = true; textEdit4.Enabled = true; textEdit5.Enabled = true;

            gridControl1.DataSource = dbcontex.forni_activiteSet.Where(j => j.fornisseur_id_fornisseur == fornisseuur.id_fornisseur).ToList();


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //fornisseurBindingSource.DataSource = dbcontex.fornisseurSet.Where(h => h.id_fornisseur == fornisseuur.id_fornisseur).ToList();
            gridControl1.DataSource = dbcontex.forni_activiteSet.Where(j => j.fornisseur_id_fornisseur == fornisseuur.id_fornisseur).ToList();

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            id_get = get_fornisseuur.id_fornisseur;
            add_activite_fornisseur frm = new add_activite_fornisseur(id_get);
            frm.Show(); 
        }

       

        

      
      
    }
}