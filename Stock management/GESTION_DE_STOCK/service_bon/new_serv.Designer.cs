namespace GESTION_DE_STOCK
{
    partial class new_serv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(new_serv));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.lesservicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.lesservicesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_service = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_service = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_responsable_srvc = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesservicesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesservicesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(484, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "  : اسم المصلحة";
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lesservicesBindingSource, "nom_service", true));
            this.textEdit1.Location = new System.Drawing.Point(29, 32);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit1.Size = new System.Drawing.Size(449, 26);
            this.textEdit1.TabIndex = 2;
            // 
            // lesservicesBindingSource
            // 
            this.lesservicesBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.les_services);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(171, 147);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(121, 35);
            this.simpleButton3.TabIndex = 1;
            this.simpleButton3.Text = "اضــــــــافة";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(29, 147);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(121, 35);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "حفـــــــــــــــظ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(484, 88);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(129, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "  : اسم المكلف بالمصلحة";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textEdit2);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.simpleButton3);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.textEdit1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(651, 212);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[     المصلحـــــــــــة    ]";
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lesservicesBindingSource, "nom_responsable_srvc", true));
            this.textEdit2.Location = new System.Drawing.Point(200, 85);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit2.Size = new System.Drawing.Size(278, 26);
            this.textEdit2.TabIndex = 3;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelControl8.Location = new System.Drawing.Point(128, 92);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(66, 13);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "حقل اختياري";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.lesservicesBindingSource1;
            this.gridControl1.Location = new System.Drawing.Point(12, 241);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(651, 338);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.TabStop = false;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // lesservicesBindingSource1
            // 
            this.lesservicesBindingSource1.DataSource = typeof(GESTION_DE_STOCK.model.les_services);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_service,
            this.colnom_service,
            this.colnom_responsable_srvc});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_service
            // 
            this.colid_service.Caption = "رقم المصلحة";
            this.colid_service.FieldName = "id_service";
            this.colid_service.Name = "colid_service";
            this.colid_service.Visible = true;
            this.colid_service.VisibleIndex = 0;
            this.colid_service.Width = 76;
            // 
            // colnom_service
            // 
            this.colnom_service.Caption = "اسم المصلحة";
            this.colnom_service.FieldName = "nom_service";
            this.colnom_service.Name = "colnom_service";
            this.colnom_service.Visible = true;
            this.colnom_service.VisibleIndex = 1;
            this.colnom_service.Width = 346;
            // 
            // colnom_responsable_srvc
            // 
            this.colnom_responsable_srvc.Caption = "اسم المكلف بالمصلحة";
            this.colnom_responsable_srvc.FieldName = "nom_responsable_srvc";
            this.colnom_responsable_srvc.Name = "colnom_responsable_srvc";
            this.colnom_responsable_srvc.Visible = true;
            this.colnom_responsable_srvc.VisibleIndex = 2;
            this.colnom_responsable_srvc.Width = 211;
            // 
            // new_serv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 591);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "new_serv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة مصلحـــــــــــــــــة";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesservicesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesservicesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        public DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource lesservicesBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_service;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_service;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_responsable_srvc;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.BindingSource lesservicesBindingSource;
        public DevExpress.XtraEditors.TextEdit textEdit2;
    }
}