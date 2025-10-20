using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraBars.Alerter;

namespace GESTION_DE_STOCK
{
    public partial class save_data_base : DevExpress.XtraEditors.XtraForm
    {
        public save_data_base()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            simpleButton1.Enabled = false;
            simpleButton4.Enabled = false;


            
        }
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;
        string sql = "";
        string connectionString = "";


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string dateee= DateTime.Now.ToString("dd-MM-yyyy");
                if (comboBox1.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("!! يرجى تحديد قاعدة البيانات أولا");
                    return;
                }
                conn = new SqlConnection(connectionString);
                conn.Open();
                sql = "BACKUP DATABASE \"" + comboBox1.Text + "\" TO DISK ='" + textEdit2.Text + "\\" + comboBox1.Text + "_" + dateee +"__ "+DateTime.Now.Ticks.ToString()+".bak'";
                 
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();

                conn.Close();
                conn.Dispose();
            
 
                
                labelControl2.Show();
                progressBarControl1.Show();

                progressBarControl1.Properties.Step = 1;

                progressBarControl1.Properties.Minimum = 0;

                for (int i = 0; i < 1000; i++)
                {
                    progressBarControl1.Properties.Maximum = i;
                    progressBarControl1.PerformStep();
                    progressBarControl1.Update();
                }


                label1.Text = textEdit2.Text+"    : لقد تـــم حفـــظ قاعــــدة البيانات بنجاح في "  ;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
             
            try
            {

                //connectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True";

                connectionString = "Data Source=.\\SQLSERVER;Initial Catalog=master ;Integrated Security=True";

                //connectionString = "Trusted_Connection=True";
                 
                conn = new SqlConnection(connectionString);
                conn.Open();
                sql = "EXEC sp_databases";
                sql = "    SELECT * FROM  sys.databases d where d.database_id>4";
                command = new SqlCommand(sql, conn);
                reader = command.ExecuteReader();
                comboBox1.Items.Clear();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0].ToString());
                }
                reader.Dispose();
                conn.Close();
                conn.Dispose();

                AlertInfo info = new AlertInfo("", "لقد تمت العملية بنجاح ");
                alertControl1.Show(this, info);

                simpleButton2.Enabled = false;
                simpleButton4.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textEdit2.Text = dlg.SelectedPath;
                simpleButton1.Enabled = true;
                 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int heure = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int seconde = DateTime.Now.Second;
 
        }

       
    }
}