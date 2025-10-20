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
    public partial class users_form : DevExpress.XtraEditors.XtraForm
    {
        gestion_de_stockEntities dbcontex;
        users userss;

        public users_form()
        {
            InitializeComponent();
            dbcontex = new gestion_de_stockEntities();
            userss = new users();
            usersBindingSource.DataSource = dbcontex.usersSet.ToList();

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            simpleButton1.Enabled = false;
        }

        

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            usersBindingSource.DataSource = userss;
            
            simpleButton2.Enabled = false;
            simpleButton1.Enabled = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
                usersBindingSource.EndEdit();
                dbcontex.usersSet.Add((users)usersBindingSource.Current);
                dbcontex.SaveChanges();

                usersBindingSource.DataSource = dbcontex.usersSet.ToList();

                AlertInfo info = new AlertInfo("", "لقد تم العملية بنجاح ");
                alertControl1.Show(this, info);
                simpleButton2.Enabled = true;
                simpleButton1.Enabled = false;
           
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            dbcontex.SaveChanges();

            AlertInfo info = new AlertInfo("", "لقد تم التعديـــــل بنجاح ");
            alertControl1.Show(this, info);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show(" هل تريد حذف ملـــــــف من قاعدة البيانات ؟؟ ", " Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult.OK == reponse)
            {
                usersBindingSource.EndEdit();
                users delt_user = (users)usersBindingSource.Current;
                dbcontex.usersSet.Remove(delt_user);
                dbcontex.SaveChanges();
                usersBindingSource.DataSource = dbcontex.usersSet.ToList();
                MessageBox.Show(" لقد تم حذف ملـــــــف من قاعدة البيانات ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}