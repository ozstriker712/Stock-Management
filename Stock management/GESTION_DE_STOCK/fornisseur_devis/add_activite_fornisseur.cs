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

namespace GESTION_DE_STOCK.fornisseur_devis
{
    public partial class add_activite_fornisseur : DevExpress.XtraEditors.XtraForm
    {
        gestion_de_stockEntities dbcontex;
        forni_activite forn_activitee;
        int id_forniiiis;
        public add_activite_fornisseur(int get_id)
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            id_forniiiis = get_id;
            dbcontex = new gestion_de_stockEntities();
            typeactivitefornisseurBindingSource.DataSource = dbcontex.type_activite_fornisseurSet.ToList();
            forniactiviteBindingSource1.DataSource = dbcontex.forni_activiteSet.Where(h => h.fornisseur_id_fornisseur == id_forniiiis).ToList();
            forn_activitee = new forni_activite();

            searchLookUpEdit1.Enabled = false; simpleButton1.Enabled = false;
          
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            forniactiviteBindingSource.EndEdit();
            forniactiviteBindingSource.DataSource = forn_activitee;
            searchLookUpEdit1.Enabled = true;
            simpleButton1.Enabled = true; simpleButton2.Enabled = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            forniactiviteBindingSource.EndEdit();
           
            dbcontex.forni_activiteSet.Add((forni_activite)forniactiviteBindingSource.Current);
            forn_activitee.fornisseur_id_fornisseur = id_forniiiis;

            forn_activitee.code_active = (int)searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("code_activite");
            dbcontex.SaveChanges();

            forniactiviteBindingSource1.DataSource = dbcontex.forni_activiteSet.Where(h => h.fornisseur_id_fornisseur == id_forniiiis).ToList();

            simpleButton1.Enabled = false; simpleButton2.Enabled = true; searchLookUpEdit1.Enabled = false;

        }

        
       
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult reponse = MessageBox.Show(" هل تريد حذف  من قاعدة البيانات ؟؟ ", " Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (DialogResult.OK == reponse)
                {
                    forniactiviteBindingSource.EndEdit();
                    forni_activite delt_lits = (forni_activite)forniactiviteBindingSource.Current;
                    dbcontex.forni_activiteSet.Remove(delt_lits);

                    dbcontex.SaveChanges();
                    forniactiviteBindingSource1.DataSource = dbcontex.forni_activiteSet.Where(j => j.fornisseur_id_fornisseur == id_forniiiis).ToList();   // just for list
                    MessageBox.Show(" لقد تم حذف ملـــــــف من قاعدة البيانات ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("!!  لايوجـــــــد اي عنصــــر . يرجى التــــــــأكد      ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }

      
      
    }
}