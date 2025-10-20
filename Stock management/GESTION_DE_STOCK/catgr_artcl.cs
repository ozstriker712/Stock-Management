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
    public partial class catgr_artcl : DevExpress.XtraEditors.XtraForm
    {
        gestion_de_stockEntities dbcontex;
        catgr categorie;

        public catgr_artcl()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();

            dbcontex = new gestion_de_stockEntities();
            categorie = new catgr();

            catgrBindingSource1.DataSource = dbcontex.catgrSet.ToList();  // for just List 
            simpleButton2.Enabled = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            catgrBindingSource.DataSource = categorie;
            simpleButton1.Enabled = false;
            simpleButton2.Enabled = true;
            textEdit1.Enabled = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                catgrBindingSource.EndEdit();
                dbcontex.catgrSet.Add((catgr)catgrBindingSource.Current);
                dbcontex.SaveChanges();

                simpleButton2.Enabled = false;
                simpleButton1.Enabled = true;

                catgrBindingSource1.DataSource = dbcontex.catgrSet.ToList();  // for just List 

                categorie = new catgr();
                catgrBindingSource.DataSource = categorie;

                AlertInfo info = new AlertInfo("", "لقد تمت الاضافة بنجاح");
                alertControl1.Show(this, info);
                textEdit1.Enabled = false  ;

            }
            catch 
            {

                MessageBox.Show("!!  يوجد حقـــــــل فــــارغ . يرجى التــــــــأكد      ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                catgrBindingSource.EndEdit();
                dbcontex.SaveChanges();
                catgrBindingSource1.DataSource = dbcontex.catgrSet.ToList();  // for just List 

                AlertInfo info = new AlertInfo("", "لقد تمت العملية بنجاح");
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
                    catgrBindingSource1.EndEdit();
                    catgr delt_lits = (catgr)catgrBindingSource1.Current;
                    dbcontex.catgrSet.Remove(delt_lits);

                    dbcontex.SaveChanges();
                    catgrBindingSource1.DataSource = dbcontex.catgrSet.ToList();  // for just List 
                    MessageBox.Show(" لقد تم حذف ملـــــــف من قاعدة البيانات ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    AlertInfo info = new AlertInfo("", "لقد تمت العملية بنجاح");
                    alertControl1.Show(this, info);
                }
            }
            catch 
            {

                MessageBox.Show("!!  لايوجـــــــد اي عنصــــر . يرجى التــــــــأكد      ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
           
        }


    }
}