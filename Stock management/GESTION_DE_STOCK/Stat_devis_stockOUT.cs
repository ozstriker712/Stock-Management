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

namespace GESTION_DE_STOCK
{
    public partial class Stat_devis_stockOUT : DevExpress.XtraEditors.XtraForm
    {
        gestion_de_stockEntities dbcontex;
        les_services les_servicessss;
        les_bon les_bonnnn;
        public Stat_devis_stockOUT()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            dbcontex = new gestion_de_stockEntities();
            les_servicessss = new les_services();
            les_bonnnn = new les_bon();
            lesservicesBindingSource.DataSource = dbcontex.les_servicesSet.ToList();
        }


        int get_service, get_bon;
        private void lesservicesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            lesservicesBindingSource.EndEdit();
            les_servicessss = (les_services)lesservicesBindingSource.Current;
            var wow = "0";

            if (les_servicessss != null)
            {
                get_service = les_servicessss.id_service; 
                lesbonBindingSource.DataSource = dbcontex.les_bonSet.Where(h => h.les_services_id_service == get_service).ToList(); 
                les_bonnnn = (les_bon)lesbonBindingSource.Current;
                if (les_bonnnn != null)
                {
                    get_bon = les_bonnnn.id_bon; 
                    stockoutBindingSource.DataSource = dbcontex.stock_outSet.Where(g => g.les_bon_id_bon == get_bon).ToList();
                    try
                    {
                        wow = dbcontex.stock_outSet.Where(h => h.les_bon_id_bon == get_bon).Sum(h => h.prix_out_unitaire_x_quantite).ToString();  
                    }
                    catch
                    {
                        //textEdit3.Text = "";
                    }
                   
                   
                }

                textEdit3.Text = wow.ToString(); // prix
                textEdit1.Text = les_servicessss.les_bon.Count().ToString();  // count nombre les bon
                textEdit2.Text = dbcontex.stock_outSet.Where(h => h.les_bon.les_services_id_service == get_service).Count().ToString(); // count nombre les articles
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            les_bonnnn = (les_bon)lesbonBindingSource.Current;
            if (les_bonnnn != null)
            { 
                Detail_Bon_chaque_Serv frm = new Detail_Bon_chaque_Serv(get_service);
                frm.Show();
            }
            else
            {
                MessageBox.Show("!!  لا نوجـــــــد اي وصـــــــل استلام . يرجى التــــــــأكد      ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}