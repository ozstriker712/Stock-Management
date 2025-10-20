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
using DevExpress.XtraGrid.Columns;
using System.Globalization;

namespace GESTION_DE_STOCK
{
    public partial class stat_forn_stockIN : DevExpress.XtraEditors.XtraForm
    {
        gestion_de_stockEntities dbcontex   ;
        devis devissss;
        fornisseur fornissseuur   ;
       

        public stat_forn_stockIN()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();  
            dbcontex = new gestion_de_stockEntities();
            devissss = new devis();
            fornissseuur = new fornisseur(); 
            fornisseurBindingSource.DataSource = dbcontex.fornisseurSet.ToList();
  
        }
         

        int get_fornisseur ;
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (nombre_deivs >0 )
            {
                Detail_Devis_chaque_forni frm = new Detail_Devis_chaque_forni(get_fornisseur);
                frm.Show();
            }
            else
            {
                MessageBox.Show("!! لايوجـــــــد اي عنصــــر . يرجى التــــــــأكد      ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                

            }
                
            
                
        }

        int nombre_deivs;
        private void fornisseurBindingSource_PositionChanged(object sender, EventArgs e)
        {
            fornisseurBindingSource.EndEdit();
            fornissseuur = (fornisseur)fornisseurBindingSource.Current;
            if (fornissseuur != null)
            {
                get_fornisseur = fornissseuur.id_fornisseur;
                textEdit1.Text = fornissseuur.devis.Count().ToString();

                stocksinBindingSource.DataSource = dbcontex.stocks_inSet.Where(g => g.devis.fornisseur_id_fornisseur == get_fornisseur).ToList();
                nombre_deivs= dbcontex.stocks_inSet.Where(g => g.devis.fornisseur_id_fornisseur == get_fornisseur).Count();
                textEdit2.Text = nombre_deivs.ToString();

               
                try
                {
                    textEdit3.Text = dbcontex.stocks_inSet.Where(g => g.devis.fornisseur_id_fornisseur == get_fornisseur).Sum(h => h.prix_in_unitaire_x_quntite).ToString();
                     
                }
                catch (Exception)
                {

                    textEdit3.Text = "0";
                }

                 



            }

        }

        
        

       
        
    }
}