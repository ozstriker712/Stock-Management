using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using GESTION_DE_STOCK.model;
using System.Linq;

namespace GESTION_DE_STOCK
{
    public partial class login : SplashScreen
    {

        gestion_de_stockEntities dbcontex;
        settings settingss;

        public login()
        {
            InitializeComponent();
            dbcontex = new gestion_de_stockEntities();
            usersBindingSource.DataSource = dbcontex.usersSet.ToList();
            settingsBindingSource.DataSource = dbcontex.settingsSet.FirstOrDefault();
        
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (var loginn in dbcontex.usersSet)
            {
                if (loginn.user_names == comboBox1.Text && loginn.passwords == textBox1.Text)
                {
                    Form1 open_frm = new Form1(loginn.id_user, loginn.user_names); //
                    if (loginn.permissions == 1)
                    {
                        settingss = (settings)settingsBindingSource.Current;
                        if (settingss.etat_config ==true)
                        {
                            open_frm.Show();
                            this.Hide();
                            found = true;
                        }
                        else
                        {
                            MessageBox.Show("يجب عليك ادخال اعدادات السعـــــر الضرورية قبل استعمال البرنامج ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Setting_Prices frm_setting = new Setting_Prices(loginn.id_user, loginn.user_names,true);
                            frm_setting.Show();
                            frm_setting.groupBox2.Hide();
                            this.Hide();
                            found = true;
                        }
                        break;
                    }
                    else
                    {
                        open_frm.Show();
                        this.Hide();
                        found = true;
                    }

                }
            }

            if (found == false)
            {
                MessageBox.Show("كلمة المــــــــرور خاطئــــة أو لا تتطابق مع اسم المستخدم", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}