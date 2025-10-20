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
    public partial class new_devi : DevExpress.XtraEditors.XtraForm
    {
        gestion_de_stockEntities dbcontex;
        devis deviss;
        fornisseur fornisseuur;

        public new_devi()
        {
            InitializeComponent();
            dbcontex = new gestion_de_stockEntities();
            deviss = new devis();
            fornisseuur = new fornisseur();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            fornisseurBindingSource.DataSource = dbcontex.fornisseurSet.ToList();

            textEdit2.Enabled = false;  dateEdit1.Enabled = false;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            devisBindingSource.DataSource = deviss;
            simpleButton4.Enabled = false;
            simpleButton2.Enabled = true;
            searchLookUpEdit1.Enabled = true;

            textEdit2.Enabled = true;  dateEdit1.Enabled = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                devisBindingSource.EndEdit();
                dbcontex.devisSet.Add((devis)devisBindingSource.Current);
                dbcontex.SaveChanges();
 
                devisBindingSource.DataSource = dbcontex.devisSet.ToList();
                AlertInfo info = new AlertInfo("", "لقد تمت الاضافة بنجاح");
                alertControl1.Show(this, info);

                deviss = new devis();
                devisBindingSource.DataSource = deviss;
                searchLookUpEdit1.Enabled = false;
                textEdit6.Text = "";
                textEdit7.Text = "";

                simpleButton4.Enabled = true;
                simpleButton2.Enabled = false;

                textEdit2.Enabled = false;  dateEdit1.Enabled = false;


            }
            catch
            {

                MessageBox.Show("!!  يوجد حقـــــــل فــــارغ . يرجى التــــــــأكد      ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

  
        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            fornisseurBindingSource.EndEdit();

            textEdit6.Text = (string)searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("prenom_fornisseur");
            textEdit7.Text = (string)searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("societe_fornisseur");
 
        }
    }
}