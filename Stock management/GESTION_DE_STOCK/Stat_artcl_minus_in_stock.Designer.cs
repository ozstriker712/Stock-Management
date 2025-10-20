namespace GESTION_DE_STOCK
{
    partial class Stat_artcl_minus_in_stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stat_artcl_minus_in_stock));
            this.lesarticlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkEdit4 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_article = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_article = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquantite_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcatgr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprixx_artcl_stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkEdit3 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lesarticlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lesarticlesBindingSource
            // 
            this.lesarticlesBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.les_articles);
            // 
            // checkEdit4
            // 
            this.checkEdit4.Location = new System.Drawing.Point(21, 157);
            this.checkEdit4.Name = "checkEdit4";
            this.checkEdit4.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkEdit4.Properties.Appearance.Options.UseFont = true;
            this.checkEdit4.Properties.Appearance.Options.UseForeColor = true;
            this.checkEdit4.Properties.Caption = "اضهـــــــــار العتاد الناقص";
            this.checkEdit4.Size = new System.Drawing.Size(177, 20);
            this.checkEdit4.TabIndex = 6;
            this.checkEdit4.CheckedChanged += new System.EventHandler(this.checkEdit4_CheckedChanged);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(21, 36);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.checkEdit1.Properties.Caption = "اضهـــــــــار حسب الصنف";
            this.checkEdit1.Size = new System.Drawing.Size(177, 20);
            this.checkEdit1.TabIndex = 3;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(312, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(819, 497);
            this.panelControl2.TabIndex = 7;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.lesarticlesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(815, 493);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            // 
            // colid_article
            // 
            this.colid_article.Caption = "رقم العتاد";
            this.colid_article.FieldName = "id_article";
            this.colid_article.Name = "colid_article";
            this.colid_article.Visible = true;
            this.colid_article.VisibleIndex = 0;
            this.colid_article.Width = 71;
            // 
            // colnom_article
            // 
            this.colnom_article.Caption = "اسم العتاد";
            this.colnom_article.FieldName = "nom_article";
            this.colnom_article.Name = "colnom_article";
            this.colnom_article.Visible = true;
            this.colnom_article.VisibleIndex = 1;
            this.colnom_article.Width = 308;
            // 
            // colquantite_total
            // 
            this.colquantite_total.Caption = "الكمية الاجمالية";
            this.colquantite_total.FieldName = "quantite_total";
            this.colquantite_total.Name = "colquantite_total";
            this.colquantite_total.Visible = true;
            this.colquantite_total.VisibleIndex = 2;
            this.colquantite_total.Width = 91;
            // 
            // colcatgr
            // 
            this.colcatgr.Caption = "الصنف";
            this.colcatgr.FieldName = "catgr.nom_catgr";
            this.colcatgr.Name = "colcatgr";
            this.colcatgr.Visible = true;
            this.colcatgr.VisibleIndex = 4;
            this.colcatgr.Width = 212;
            // 
            // colprixx_artcl_stock
            // 
            this.colprixx_artcl_stock.Caption = "سعر الوحدة";
            this.colprixx_artcl_stock.FieldName = "prixx_artcl_stock";
            this.colprixx_artcl_stock.Name = "colprixx_artcl_stock";
            this.colprixx_artcl_stock.Visible = true;
            this.colprixx_artcl_stock.VisibleIndex = 3;
            this.colprixx_artcl_stock.Width = 140;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(GESTION_DE_STOCK.model.les_articles);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(63, 74);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(135, 37);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Printing";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(63, 19);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(135, 39);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Export to Excel";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Controls.Add(this.groupBox2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(312, 497);
            this.panelControl1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 142);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkEdit1);
            this.groupBox2.Controls.Add(this.checkEdit3);
            this.groupBox2.Controls.Add(this.checkEdit4);
            this.groupBox2.Location = new System.Drawing.Point(12, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 215);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // checkEdit3
            // 
            this.checkEdit3.Location = new System.Drawing.Point(21, 118);
            this.checkEdit3.Name = "checkEdit3";
            this.checkEdit3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkEdit3.Properties.Appearance.Options.UseFont = true;
            this.checkEdit3.Properties.Appearance.Options.UseForeColor = true;
            this.checkEdit3.Properties.Caption = "اضهـــــــــار العتـــــاد  المنتهــــي";
            this.checkEdit3.Size = new System.Drawing.Size(237, 20);
            this.checkEdit3.TabIndex = 3;
            this.checkEdit3.CheckedChanged += new System.EventHandler(this.checkEdit3_CheckedChanged);
            // 
            // Stat_artcl_minus_in_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 497);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stat_artcl_minus_in_stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اظهار العتــــاد منتهــــــــي الكميــــــة";
            ((System.ComponentModel.ISupportInitialize)(this.lesarticlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource lesarticlesBindingSource;
        private DevExpress.XtraEditors.CheckEdit checkEdit4;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_article;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_article;
        private DevExpress.XtraGrid.Columns.GridColumn colquantite_total;
        private DevExpress.XtraGrid.Columns.GridColumn colcatgr;
        private DevExpress.XtraGrid.Columns.GridColumn colprixx_artcl_stock;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.CheckEdit checkEdit3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}