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

namespace GESTION_DE_STOCK
{
    public partial class new_bon : DevExpress.XtraEditors.XtraForm
    {
        gestion_de_stockEntities dbcontex;
        les_bon les_bonnn ,les_bonnn1;
        public new_bon()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            dbcontex = new gestion_de_stockEntities();
            textEdit2.Enabled = false; dateEdit1.Enabled = false;
            les_bonnn = new les_bon();
            lesservicesBindingSource.DataSource = dbcontex.les_servicesSet.ToList();

            searchLookUpEdit1.Enabled = false;
 
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            lesbonBindingSource.DataSource = les_bonnn;
            simpleButton4.Enabled = false;
            simpleButton2.Enabled = true;
            searchLookUpEdit1.Enabled = true;

            textEdit2.Enabled = true; dateEdit1.Enabled = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                lesbonBindingSource.EndEdit();
                dbcontex.les_bonSet.Add((les_bon)lesbonBindingSource.Current);
                dbcontex.SaveChanges();

                AlertInfo info = new AlertInfo("", "لقد تمت الاضافة بنجاح");
                alertControl1.Show(this, info);

                les_bonnn = new les_bon();

                searchLookUpEdit1.Enabled = false;

                simpleButton4.Enabled = true;
                simpleButton2.Enabled = false;

                textEdit2.Enabled = false; dateEdit1.Enabled = false;

            }
            catch
            {

                MessageBox.Show("!!  يوجد حقـــــــل فــــارغ . يرجى التــــــــأكد      ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        int id_serv_selctd, id_bon_selctd;
         
        private void simpleButton1_Click(object sender, EventArgs e)
        {   


            les_bonnn1 = (les_bon)lesbonBindingSource.Current;
            if (les_bonnn1 != null)
            {
                id_bon_selctd = les_bonnn1.id_bon;
                id_serv_selctd = les_bonnn1.les_services_id_service;

                out_stock frm = new out_stock(id_serv_selctd, id_bon_selctd);
                frm.Show();
                frm.simpleButton2.Enabled = false;

                this.Hide();
                
            }
            else
            {
                MessageBox.Show(" قــــم بتحديــــــــد : المصلــحة   و وصــــل التسليم   ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

               
           
            
        }
    }
}