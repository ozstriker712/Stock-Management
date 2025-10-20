namespace GESTION_DE_STOCK
{
    partial class choose_forni_devi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(choose_forni_devi));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.fornisseurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_fornisseur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_fornisseur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprenom_fornisseur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsociete_fornisseur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchLookUpEdit2 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.devisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldate_facture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coln_facture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colanne_facture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstocks_in = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornisseurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 160);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(119, 38);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "تأكــــــــــــيد";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(626, 83);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = " : الممـــــــــول ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(626, 133);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = " :   الفاتــــــــورة";
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.EditValue = "";
            this.searchLookUpEdit1.Location = new System.Drawing.Point(409, 78);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.DataSource = this.fornisseurBindingSource;
            this.searchLookUpEdit1.Properties.DisplayMember = "nom_fornisseur";
            this.searchLookUpEdit1.Properties.ValueMember = "id_fornisseur";
            this.searchLookUpEdit1.Properties.View = this.searchLookUpEdit1View;
            this.searchLookUpEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchLookUpEdit1.Size = new System.Drawing.Size(198, 22);
            this.searchLookUpEdit1.TabIndex = 5;
            this.searchLookUpEdit1.EditValueChanged += new System.EventHandler(this.searchLookUpEdit1_EditValueChanged);
            // 
            // fornisseurBindingSource
            // 
            this.fornisseurBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.fornisseur);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_fornisseur,
            this.colnom_fornisseur,
            this.colprenom_fornisseur,
            this.colsociete_fornisseur});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid_fornisseur
            // 
            this.colid_fornisseur.Caption = "الرقم";
            this.colid_fornisseur.FieldName = "id_fornisseur";
            this.colid_fornisseur.Name = "colid_fornisseur";
            this.colid_fornisseur.Visible = true;
            this.colid_fornisseur.VisibleIndex = 0;
            this.colid_fornisseur.Width = 113;
            // 
            // colnom_fornisseur
            // 
            this.colnom_fornisseur.Caption = "الاسم";
            this.colnom_fornisseur.FieldName = "nom_fornisseur";
            this.colnom_fornisseur.Name = "colnom_fornisseur";
            this.colnom_fornisseur.Visible = true;
            this.colnom_fornisseur.VisibleIndex = 1;
            this.colnom_fornisseur.Width = 306;
            // 
            // colprenom_fornisseur
            // 
            this.colprenom_fornisseur.Caption = "اللقب";
            this.colprenom_fornisseur.FieldName = "prenom_fornisseur";
            this.colprenom_fornisseur.Name = "colprenom_fornisseur";
            this.colprenom_fornisseur.Visible = true;
            this.colprenom_fornisseur.VisibleIndex = 2;
            this.colprenom_fornisseur.Width = 306;
            // 
            // colsociete_fornisseur
            // 
            this.colsociete_fornisseur.Caption = "اسم المؤسسة / الشركة";
            this.colsociete_fornisseur.FieldName = "societe_fornisseur";
            this.colsociete_fornisseur.Name = "colsociete_fornisseur";
            this.colsociete_fornisseur.Visible = true;
            this.colsociete_fornisseur.VisibleIndex = 3;
            this.colsociete_fornisseur.Width = 319;
            // 
            // searchLookUpEdit2
            // 
            this.searchLookUpEdit2.EditValue = "";
            this.searchLookUpEdit2.Location = new System.Drawing.Point(410, 130);
            this.searchLookUpEdit2.Name = "searchLookUpEdit2";
            this.searchLookUpEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLookUpEdit2.Properties.Appearance.Options.UseFont = true;
            this.searchLookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit2.Properties.DataSource = this.devisBindingSource;
            this.searchLookUpEdit2.Properties.DisplayMember = "n_facture";
            this.searchLookUpEdit2.Properties.ValueMember = "id_devis";
            this.searchLookUpEdit2.Properties.View = this.gridView1;
            this.searchLookUpEdit2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchLookUpEdit2.Size = new System.Drawing.Size(198, 22);
            this.searchLookUpEdit2.TabIndex = 6;
            this.searchLookUpEdit2.EditValueChanged += new System.EventHandler(this.searchLookUpEdit2_EditValueChanged);
            // 
            // devisBindingSource
            // 
            this.devisBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.devis);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldate_facture,
            this.coln_facture,
            this.colanne_facture,
            this.colstocks_in});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // coldate_facture
            // 
            this.coldate_facture.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.coldate_facture.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.coldate_facture.AppearanceCell.Options.UseFont = true;
            this.coldate_facture.AppearanceCell.Options.UseForeColor = true;
            this.coldate_facture.Caption = "تاريخ الفاتورة";
            this.coldate_facture.FieldName = "date_facture";
            this.coldate_facture.Name = "coldate_facture";
            this.coldate_facture.Visible = true;
            this.coldate_facture.VisibleIndex = 1;
            this.coldate_facture.Width = 386;
            // 
            // coln_facture
            // 
            this.coln_facture.Caption = "رقم الفاتورة";
            this.coln_facture.FieldName = "n_facture";
            this.coln_facture.Name = "coln_facture";
            this.coln_facture.Visible = true;
            this.coln_facture.VisibleIndex = 0;
            this.coln_facture.Width = 194;
            // 
            // colanne_facture
            // 
            this.colanne_facture.Caption = "سنة الفاتورة";
            this.colanne_facture.FieldName = "anne_facture";
            this.colanne_facture.Name = "colanne_facture";
            this.colanne_facture.Visible = true;
            this.colanne_facture.VisibleIndex = 2;
            this.colanne_facture.Width = 277;
            // 
            // colstocks_in
            // 
            this.colstocks_in.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colstocks_in.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.colstocks_in.AppearanceCell.Options.UseFont = true;
            this.colstocks_in.AppearanceCell.Options.UseForeColor = true;
            this.colstocks_in.Caption = "عدد العتاد";
            this.colstocks_in.FieldName = "stocks_in.Count";
            this.colstocks_in.Name = "colstocks_in";
            this.colstocks_in.Visible = true;
            this.colstocks_in.VisibleIndex = 3;
            this.colstocks_in.Width = 187;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(227, 78);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit1.Size = new System.Drawing.Size(178, 22);
            this.textEdit1.TabIndex = 7;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(15, 78);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Properties.ReadOnly = true;
            this.textEdit2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit2.Size = new System.Drawing.Size(206, 22);
            this.textEdit2.TabIndex = 8;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(278, 130);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit3.Properties.Appearance.Options.UseFont = true;
            this.textEdit3.Properties.ReadOnly = true;
            this.textEdit3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit3.Size = new System.Drawing.Size(126, 22);
            this.textEdit3.TabIndex = 9;
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(156, 130);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit4.Properties.Appearance.Options.UseFont = true;
            this.textEdit4.Properties.ReadOnly = true;
            this.textEdit4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit4.Size = new System.Drawing.Size(116, 22);
            this.textEdit4.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkEdit1);
            this.groupBox1.Controls.Add(this.textEdit2);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.textEdit4);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.textEdit3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.searchLookUpEdit1);
            this.groupBox1.Controls.Add(this.textEdit1);
            this.groupBox1.Controls.Add(this.searchLookUpEdit2);
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 211);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(388, 28);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Green;
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.checkEdit1.Properties.Caption = "اظهــــــار جميع الفواتيــــــر المنجــــــــــــــــــزة";
            this.checkEdit1.Size = new System.Drawing.Size(310, 20);
            this.checkEdit1.TabIndex = 11;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // choose_forni_devi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 223);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "choose_forni_devi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اختيـــــــــار الممـــــــــــــــول و الفاتـــــــــــورة  المراد حجـــــــــزه" +
    "ا";
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornisseurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource fornisseurBindingSource;
        private System.Windows.Forms.BindingSource devisBindingSource;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraGrid.Columns.GridColumn colid_fornisseur;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_fornisseur;
        private DevExpress.XtraGrid.Columns.GridColumn colprenom_fornisseur;
        private DevExpress.XtraGrid.Columns.GridColumn colsociete_fornisseur;
        private DevExpress.XtraGrid.Columns.GridColumn coln_facture;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_facture;
        private DevExpress.XtraGrid.Columns.GridColumn colanne_facture;
        public DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colstocks_in;
        public System.Windows.Forms.GroupBox groupBox1;
        public DevExpress.XtraEditors.CheckEdit checkEdit1;

    }
}