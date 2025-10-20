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
    public partial class edit_serv_bon : DevExpress.XtraEditors.XtraForm
    {
        gestion_de_stockEntities dbcontex;
        les_services les_servc;
        les_bon les_bonnnn;
        public edit_serv_bon()
        {
            InitializeComponent();
            dbcontex = new gestion_de_stockEntities();
            les_servc = new les_services();
            les_bonnnn = new les_bon();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            lesservicesBindingSource.DataSource = dbcontex.les_servicesSet.ToList();
            lesbonBindingSource.DataSource = dbcontex.les_bonSet.ToList();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                 
                dbcontex.SaveChanges();
                lesservicesBindingSource.DataSource = dbcontex.les_servicesSet.ToList();
                AlertInfo info = new AlertInfo("", "لقد تم التعديل بنجاح");
                alertControl1.Show(this, info);
            }
            catch  
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
                    lesservicesBindingSource.EndEdit();
                    les_services delt_lits = (les_services)lesservicesBindingSource.Current;
                    dbcontex.les_servicesSet.Remove(delt_lits);

                    dbcontex.SaveChanges();
                    lesservicesBindingSource.DataSource = dbcontex.les_servicesSet.ToList();   // just for list
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
            try
            {
                dbcontex.SaveChanges();
                lesbonBindingSource.DataSource = dbcontex.les_bonSet.ToList();
                AlertInfo info = new AlertInfo("", "لقد تم التعديل بنجاح");
                alertControl1.Show(this, info);
            }
            catch  
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
                    lesbonBindingSource.EndEdit();
                    les_bon delt_lits = (les_bon)lesbonBindingSource.Current;
                    dbcontex.les_bonSet.Remove(delt_lits);

                    dbcontex.SaveChanges();
                    lesbonBindingSource.DataSource = dbcontex.les_bonSet.ToList();   // just for list
                    MessageBox.Show(" لقد تم حذف ملـــــــف من قاعدة البيانات ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("!!  لايوجـــــــد اي عنصــــر . يرجى التــــــــأكد      ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
        }
    }
}