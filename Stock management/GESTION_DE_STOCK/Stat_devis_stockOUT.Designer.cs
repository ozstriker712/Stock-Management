namespace GESTION_DE_STOCK
{
    partial class Stat_devis_stockOUT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stat_devis_stockOUT));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.lesservicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_service = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_service = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stockoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lesbonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lesarticlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesservicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockoutBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lesbonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesarticlesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(531, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(472, 586);
            this.panelControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.lesservicesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(468, 582);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // lesservicesBindingSource
            // 
            this.lesservicesBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.les_services);
            this.lesservicesBindingSource.PositionChanged += new System.EventHandler(this.lesservicesBindingSource_PositionChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_service,
            this.colnom_service});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // colid_service
            // 
            this.colid_service.Caption = "الرقم";
            this.colid_service.FieldName = "id_service";
            this.colid_service.Name = "colid_service";
            this.colid_service.Visible = true;
            this.colid_service.VisibleIndex = 0;
            this.colid_service.Width = 59;
            // 
            // colnom_service
            // 
            this.colnom_service.Caption = "الملحقة / المصلحة";
            this.colnom_service.FieldName = "nom_service";
            this.colnom_service.Name = "colnom_service";
            this.colnom_service.Visible = true;
            this.colnom_service.VisibleIndex = 1;
            this.colnom_service.Width = 371;
            // 
            // stockoutBindingSource
            // 
            this.stockoutBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.stock_out);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textEdit3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textEdit2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textEdit1);
            this.groupBox1.Location = new System.Drawing.Point(12, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 226);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[          تفاصيل كل وصلات الاستلام       ]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "دج";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = ": السعر الكلي لجميع الوصلات ";
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(34, 164);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit3.Properties.Appearance.Options.UseFont = true;
            this.textEdit3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit3.Size = new System.Drawing.Size(214, 22);
            this.textEdit3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = " : العدد الكلي للعتاد في كل الوصلات";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(150, 104);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit2.Size = new System.Drawing.Size(98, 22);
            this.textEdit2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = ": العدد الكلي للوصلات ";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(184, 43);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit1.Size = new System.Drawing.Size(64, 22);
            this.textEdit1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupBox2);
            this.panelControl2.Controls.Add(this.groupBox3);
            this.panelControl2.Controls.Add(this.groupBox1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(531, 586);
            this.panelControl2.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.simpleButton2);
            this.groupBox2.Controls.Add(this.simpleButton3);
            this.groupBox2.Location = new System.Drawing.Point(12, 422);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 82);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(289, 23);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(151, 37);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Printing";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(54, 23);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(168, 39);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "Export to Excel";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.simpleButton1);
            this.groupBox3.Location = new System.Drawing.Point(30, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 69);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(88, 19);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(302, 39);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "تفاصيــــــل أكثر  - حسب التاريخ /عام/شهر/يوم";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lesbonBindingSource
            // 
            this.lesbonBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.les_bon);
            // 
            // lesarticlesBindingSource
            // 
            this.lesarticlesBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.les_articles);
            // 
            // Stat_devis_stockOUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 586);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Stat_devis_stockOUT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "احصاء كلي لوصــــــــــــــلات الاستلام";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesservicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockoutBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lesbonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesarticlesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public DevExpress.XtraEditors.TextEdit textEdit3;
        private System.Windows.Forms.Label label3;
        public DevExpress.XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.Label label2;
        public DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.BindingSource lesservicesBindingSource;
        private System.Windows.Forms.BindingSource stockoutBindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_service;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_service;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.BindingSource lesbonBindingSource;
        private System.Windows.Forms.BindingSource lesarticlesBindingSource;
    }
}