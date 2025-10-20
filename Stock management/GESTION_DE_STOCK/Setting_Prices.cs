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
using System.Data.SqlClient;
using DevExpress.XtraBars.Alerter;
 

namespace GESTION_DE_STOCK
{
    public partial class Setting_Prices : DevExpress.XtraEditors.XtraForm
    {
        gestion_de_stockEntities dbcontex;
        int id_userrr_public; string user_name;
        settings settingssss;
        bool firtssss_or_noooot;
        public Setting_Prices(int id_user_public, string user_name_public, bool first_or_not)
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            dbcontex = new gestion_de_stockEntities();
            id_userrr_public = id_user_public; user_name = user_name_public;
            settingssss = new settings(); 
            usersBindingSource.DataSource = dbcontex.usersSet.ToList();

            firtssss_or_noooot = first_or_not; 
            if (firtssss_or_noooot == false)
            {
                groupBox1.Enabled = false; 
            }
           
            textEdit1.Text = user_name_public;

            settingssss = dbcontex.settingsSet.FirstOrDefault();
            checkk__etat_first();

           
        }

      
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;
        string sql_1 = ""; string sql_2 = ""; string sql_3 = ""; string sql_4 = "";
        string connectionString = "";

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            connectionString = "Data Source=.\\SQLSERVER;Initial Catalog=gestion_de_stock;Integrated Security=True";

            conn = new SqlConnection(connectionString);
            conn.Open();

            if (etat == 1) // max
            {
                sql_1 = " ENABLE TRIGGER [dbo].[5_tracking_event_prix_MAX] ON  [dbo].[stocks_inSet] ";
                sql_2 = "   DISABLE TRIGGER [dbo].[6_tracking_event_prix_AVG] ON  [dbo].[stocks_inSet]	  ";
                sql_3 = "   ENABLE TRIGGER [7_tracking_event_delete_Prix_MAX] ON  [dbo].[stocks_inSet]	  ";
                sql_4 = "   DISABLE TRIGGER [dbo].[8_tracking_event_delete_Prix_AVG] ON  [dbo].[stocks_inSet]	  ";

                command = new SqlCommand(sql_1, conn);
                reader = command.ExecuteReader();
                reader.Dispose();

                command = new SqlCommand(sql_2, conn);
                reader = command.ExecuteReader();
                reader.Dispose();

                command = new SqlCommand(sql_3, conn);
                reader = command.ExecuteReader();
                reader.Dispose();

                command = new SqlCommand(sql_4, conn);
                reader = command.ExecuteReader();
                reader.Dispose();

                settingsBindingSource.EndEdit();
                settingssss.etat_price = 1;
                dbcontex.SaveChanges();
            }

            if (etat == 2) // AVG
            {
                sql_1 = " DISABLE TRIGGER [dbo].[5_tracking_event_prix_MAX] ON  [dbo].[stocks_inSet] ";
                sql_2 = "   ENABLE TRIGGER [dbo].[6_tracking_event_prix_AVG] ON  [dbo].[stocks_inSet]	  ";
                sql_3 = "   DISABLE TRIGGER [7_tracking_event_delete_Prix_MAX] ON  [dbo].[stocks_inSet]	  ";
                sql_4 = "   ENABLE TRIGGER [dbo].[8_tracking_event_delete_Prix_AVG] ON  [dbo].[stocks_inSet]	  ";

                command = new SqlCommand(sql_1, conn);
                reader = command.ExecuteReader();
                reader.Dispose();

                command = new SqlCommand(sql_2, conn);
                reader = command.ExecuteReader();
                reader.Dispose();

                command = new SqlCommand(sql_3, conn);
                reader = command.ExecuteReader();
                reader.Dispose();

                command = new SqlCommand(sql_4, conn);
                reader = command.ExecuteReader();
                reader.Dispose();

                settingsBindingSource.EndEdit();
                settingssss.etat_price = 2;
                dbcontex.SaveChanges();

            }


            conn.Close();
            conn.Dispose();

            
            AlertInfo info = new AlertInfo("", "لقد تمت العملية بنجاح ");
            alertControl1.Show(this, info);

            if (firtssss_or_noooot == true)
            {
               MessageBox.Show("هذه الاعدادت مرة واحدة فقط عند أول استعمال للبرنامج. سوف يشتغل البرنامج ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
               Form1 frm = new Form1(id_userrr_public, user_name);
               settingsBindingSource.EndEdit();
               settingssss.etat_config= true;
               dbcontex.SaveChanges();
               frm.Show();
               this.Hide();
               
            }
        }

        int etat;
        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                checkEdit2.Checked = false;
                etat = 1;
              


            }
            else
            {
                checkEdit1.Checked = false;
                etat = 2;
               

            }
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit2.Checked)
            {
                checkEdit1.Checked = false;
                etat = 2;

            }
            else
            {
                checkEdit2.Checked = false;
                etat = 1;
            }
        }

        void checkk__etat_first()
        {
            if (settingssss.etat_price == 1)
            {
                checkEdit1.Checked = true;
                checkEdit2.Checked = false;
            }
            else
            {
                checkEdit2.Checked = true;
                checkEdit1.Checked = false;
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            foreach (var loginn in dbcontex.usersSet)
            {
                if (loginn.id_user == id_userrr_public && loginn.passwords == textBox1.Text)
                {
                    if (loginn.permissions == 1)
                    {
                        groupBox1.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("حسابــك ليس له التصريح للتعديل على اعدادات السعر. يرجى الاتصال بمسؤول البرنامج ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
                else
                {
                    MessageBox.Show("كلمة المــــــــرور خاطئــــة أو لا تتطابق مع اسم المستخدم", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                }
            }
        }

    }
}