namespace GESTION_DE_STOCK
{
    partial class new_bon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(new_bon));
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_service = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_service = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lesbonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lesservicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lesbonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesservicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(22, 103);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(121, 35);
            this.simpleButton4.TabIndex = 1;
            this.simpleButton4.TabStop = false;
            this.simpleButton4.Text = "اضــــــــافة";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lesbonBindingSource, "les_services_id_service", true));
            this.searchLookUpEdit1.EditValue = "";
            this.searchLookUpEdit1.Location = new System.Drawing.Point(142, 34);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLookUpEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.searchLookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.searchLookUpEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.DataSource = this.lesservicesBindingSource;
            this.searchLookUpEdit1.Properties.DisplayMember = "nom_service";
            this.searchLookUpEdit1.Properties.ValueMember = "id_service";
            this.searchLookUpEdit1.Properties.View = this.searchLookUpEdit1View;
            this.searchLookUpEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchLookUpEdit1.Size = new System.Drawing.Size(410, 26);
            this.searchLookUpEdit1.TabIndex = 2;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_service,
            this.colnom_service});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid_service
            // 
            this.colid_service.Caption = "الرقم";
            this.colid_service.FieldName = "id_service";
            this.colid_service.Name = "colid_service";
            this.colid_service.Visible = true;
            this.colid_service.VisibleIndex = 0;
            this.colid_service.Width = 129;
            // 
            // colnom_service
            // 
            this.colnom_service.Caption = "اسم الملحقة / المصلحة";
            this.colnom_service.FieldName = "nom_service";
            this.colnom_service.Name = "colnom_service";
            this.colnom_service.Visible = true;
            this.colnom_service.VisibleIndex = 1;
            this.colnom_service.Width = 913;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(558, 37);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "  : المصلحـــــة";
            // 
            // dateEdit1
            // 
            this.dateEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lesbonBindingSource, "date_bon", true));
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(420, 151);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateEdit1.Size = new System.Drawing.Size(132, 26);
            this.dateEdit1.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(558, 158);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(86, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = " : تاريــخ الوصـــل";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(558, 97);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = " : رقم الوصــل";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(22, 154);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(121, 35);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "حفـــــــــــــــظ";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lesbonBindingSource, "n_bon", true));
            this.textEdit2.Location = new System.Drawing.Point(420, 90);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit2.Size = new System.Drawing.Size(132, 26);
            this.textEdit2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.simpleButton4);
            this.groupBox1.Controls.Add(this.searchLookUpEdit1);
            this.groupBox1.Controls.Add(this.textEdit2);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.dateEdit1);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(673, 211);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[     وصل استلام    ]";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "يرجى اختيار المصلحة";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(465, 243);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(220, 35);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "اخــــراج مخــــــــزون";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lesbonBindingSource
            // 
            this.lesbonBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.les_bon);
            // 
            // lesservicesBindingSource
            // 
            this.lesservicesBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.les_services);
            // 
            // new_bon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 299);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "new_bon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة وصل تسليم";
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lesbonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesservicesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton simpleButton4;
        public DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid_service;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_service;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        public DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.SimpleButton simpleButton2;
        public DevExpress.XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.BindingSource lesservicesBindingSource;
        private System.Windows.Forms.BindingSource lesbonBindingSource;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}