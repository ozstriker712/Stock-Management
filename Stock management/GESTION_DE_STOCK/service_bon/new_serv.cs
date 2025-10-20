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
    public partial class new_serv : DevExpress.XtraEditors.XtraForm
    {
        gestion_de_stockEntities dbcontex;

        public new_serv()
        {
            InitializeComponent(); 
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();


            dbcontex = new gestion_de_stockEntities();
            les_servicess = new les_services();
            les_bonnn = new les_bon();

            lesservicesBindingSource1.DataSource = dbcontex.les_servicesSet.ToList();
            lesservicesBindingSource.DataSource = les_servicess;

            textEdit1.Enabled = false; textEdit2.Enabled = false;
   

        }

        les_services les_servicess;
        les_bon les_bonnn;
        private void simpleButton3_Click(object sender, EventArgs e)
        { 

            simpleButton3.Enabled = false;
            simpleButton1.Enabled = true;
            textEdit1.Enabled = true; textEdit2.Enabled = true;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                lesservicesBindingSource.EndEdit();
                dbcontex.les_servicesSet.Add((les_services)lesservicesBindingSource.Current);
                dbcontex.SaveChanges();

                les_servicess = new les_services();
                lesservicesBindingSource.DataSource = les_servicess;

                simpleButton3.Enabled = true;
                simpleButton1.Enabled = false;
                textEdit1.Enabled = false; textEdit2.Enabled = false;

                lesservicesBindingSource1.DataSource = dbcontex.les_servicesSet.ToList();
                AlertInfo info = new AlertInfo("", "لقد تمت الاضافة بنجاح");
                alertControl1.Show(this, info);

                lesservicesBindingSource.DataSource = les_servicess;
            }
            catch
            {

                MessageBox.Show("!!  يوجد حقـــــــل فــــارغ . يرجى التــــــــأكد      ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
        }
 
    }
}