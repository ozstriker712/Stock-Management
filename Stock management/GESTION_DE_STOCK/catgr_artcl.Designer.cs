namespace GESTION_DE_STOCK
{
    partial class catgr_artcl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(catgr_artcl));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.catgrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.catgrBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_catgr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_catgr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catgrBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catgrBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(416, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = " : اسم الصنف ";
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.catgrBindingSource, "nom_catgr", true));
            this.textEdit1.Location = new System.Drawing.Point(19, 33);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(391, 22);
            this.textEdit1.TabIndex = 1;
            // 
            // catgrBindingSource
            // 
            this.catgrBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.catgr);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(19, 76);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(121, 40);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "تأكيـــــد";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(186, 76);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(122, 40);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "اضافـــة";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textEdit2);
            this.groupBox2.Controls.Add(this.simpleButton4);
            this.groupBox2.Controls.Add(this.simpleButton3);
            this.groupBox2.Controls.Add(this.simpleButton2);
            this.groupBox2.Controls.Add(this.simpleButton1);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Controls.Add(this.textEdit1);
            this.groupBox2.Location = new System.Drawing.Point(14, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(511, 145);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[  أصنــــــــــاف العتــــــــــاد  ]";
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.catgrBindingSource1, "nom_catgr", true));
            this.textEdit2.Location = new System.Drawing.Point(19, 33);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Size = new System.Drawing.Size(382, 22);
            this.textEdit2.TabIndex = 10;
            // 
            // catgrBindingSource1
            // 
            this.catgrBindingSource1.DataSource = typeof(GESTION_DE_STOCK.model.catgr);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(186, 76);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(129, 40);
            this.simpleButton4.TabIndex = 8;
            this.simpleButton4.Text = "تعـــديل";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(19, 76);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(129, 40);
            this.simpleButton3.TabIndex = 9;
            this.simpleButton3.Text = "حــــــذف";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.catgrBindingSource1;
            this.gridControl1.Location = new System.Drawing.Point(12, 172);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(511, 412);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.TabStop = false;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_catgr,
            this.colnom_catgr});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_catgr
            // 
            this.colid_catgr.Caption = "رقم الصنف";
            this.colid_catgr.FieldName = "id_catgr";
            this.colid_catgr.Name = "colid_catgr";
            this.colid_catgr.Visible = true;
            this.colid_catgr.VisibleIndex = 0;
            this.colid_catgr.Width = 82;
            // 
            // colnom_catgr
            // 
            this.colnom_catgr.Caption = "اســــــــم الصنـــــــف";
            this.colnom_catgr.FieldName = "nom_catgr";
            this.colnom_catgr.Name = "colnom_catgr";
            this.colnom_catgr.Visible = true;
            this.colnom_catgr.VisibleIndex = 1;
            this.colnom_catgr.Width = 405;
            // 
            // catgr_artcl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 598);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "catgr_artcl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضــــــافة صنـــــف";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catgrBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catgrBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraEditors.SimpleButton simpleButton2;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource catgrBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid_catgr;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_catgr;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private System.Windows.Forms.BindingSource catgrBindingSource1;
        public System.Windows.Forms.GroupBox groupBox2;
        public DevExpress.XtraEditors.SimpleButton simpleButton3;
        public DevExpress.XtraEditors.SimpleButton simpleButton4;
        public DevExpress.XtraEditors.TextEdit textEdit2;
        public DevExpress.XtraEditors.TextEdit textEdit1;
    }
}