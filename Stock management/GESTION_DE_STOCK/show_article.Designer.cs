namespace GESTION_DE_STOCK
{
    partial class show_article
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(show_article));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.lesarticlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_article = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_article = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquantite_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcatgr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprixx_artcl_stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesarticlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.lesarticlesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(789, 564);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // lesarticlesBindingSource
            // 
            this.lesarticlesBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.les_articles);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_article,
            this.colnom_article,
            this.colquantite_total,
            this.colcatgr,
            this.colprixx_artcl_stock});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsPrint.AutoWidth = false;
            // 
            // colid_article
            // 
            this.colid_article.Caption = "رقم";
            this.colid_article.FieldName = "id_article";
            this.colid_article.Name = "colid_article";
            this.colid_article.Visible = true;
            this.colid_article.VisibleIndex = 0;
            this.colid_article.Width = 43;
            // 
            // colnom_article
            // 
            this.colnom_article.Caption = "اسم المنتج";
            this.colnom_article.FieldName = "nom_article";
            this.colnom_article.Name = "colnom_article";
            this.colnom_article.Visible = true;
            this.colnom_article.VisibleIndex = 1;
            this.colnom_article.Width = 305;
            // 
            // colquantite_total
            // 
            this.colquantite_total.Caption = "الكمية الاجمالية";
            this.colquantite_total.FieldName = "quantite_total";
            this.colquantite_total.Name = "colquantite_total";
            this.colquantite_total.Visible = true;
            this.colquantite_total.VisibleIndex = 2;
            this.colquantite_total.Width = 78;
            // 
            // colcatgr
            // 
            this.colcatgr.Caption = "الصنف";
            this.colcatgr.FieldName = "catgr.nom_catgr";
            this.colcatgr.Name = "colcatgr";
            this.colcatgr.Visible = true;
            this.colcatgr.VisibleIndex = 4;
            this.colcatgr.Width = 199;
            // 
            // colprixx_artcl_stock
            // 
            this.colprixx_artcl_stock.Caption = "السعر";
            this.colprixx_artcl_stock.FieldName = "prixx_artcl_stock";
            this.colprixx_artcl_stock.Name = "colprixx_artcl_stock";
            this.colprixx_artcl_stock.Visible = true;
            this.colprixx_artcl_stock.VisibleIndex = 3;
            this.colprixx_artcl_stock.Width = 143;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(275, 28);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.checkEdit1.Properties.Caption = "اضهـــــــــار حسب الصنف";
            this.checkEdit1.Size = new System.Drawing.Size(177, 20);
            this.checkEdit1.TabIndex = 3;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(793, 117);
            this.panelControl1.TabIndex = 4;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(668, 11);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(75, 82);
            this.pictureEdit1.TabIndex = 96;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkEdit1);
            this.groupBox1.Controls.Add(this.checkEdit2);
            this.groupBox1.Location = new System.Drawing.Point(184, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 67);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(26, 28);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkEdit2.Properties.Appearance.Options.UseFont = true;
            this.checkEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.checkEdit2.Properties.Caption = "اضهـــــــــار جميع العتاد";
            this.checkEdit2.Size = new System.Drawing.Size(177, 20);
            this.checkEdit2.TabIndex = 6;
            this.checkEdit2.CheckedChanged += new System.EventHandler(this.checkEdit2_CheckedChanged);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(12, 57);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(135, 45);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "طباعـــة القائمة";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(135, 39);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = " Excel تصدير الى  ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 117);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(793, 568);
            this.panelControl2.TabIndex = 5;
            // 
            // show_article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 685);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "show_article";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جميع المنتوجات الموجودة على مستوى المخزن";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesarticlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource lesarticlesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid_article;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_article;
        private DevExpress.XtraGrid.Columns.GridColumn colquantite_total;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colcatgr;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colprixx_artcl_stock;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}