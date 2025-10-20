namespace GESTION_DE_STOCK.fornisseur_devis
{
    partial class add_activite_fornisseur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_activite_fornisseur));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.forniactiviteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcode_active = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_active = new DevExpress.XtraGrid.Columns.GridColumn();
            this.forniactiviteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.typeactivitefornisseurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcode_activite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_activite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forniactiviteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forniactiviteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeactivitefornisseurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.forniactiviteBindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(503, 374);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // forniactiviteBindingSource1
            // 
            this.forniactiviteBindingSource1.DataSource = typeof(GESTION_DE_STOCK.model.forni_activite);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcode_active,
            this.colnom_active});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colcode_active
            // 
            this.colcode_active.Caption = "رمز النشاط";
            this.colcode_active.FieldName = "code_active";
            this.colcode_active.Name = "colcode_active";
            this.colcode_active.Visible = true;
            this.colcode_active.VisibleIndex = 0;
            this.colcode_active.Width = 92;
            // 
            // colnom_active
            // 
            this.colnom_active.Caption = "اسم النشاط";
            this.colnom_active.FieldName = "nom_active";
            this.colnom_active.Name = "colnom_active";
            this.colnom_active.Visible = true;
            this.colnom_active.VisibleIndex = 1;
            this.colnom_active.Width = 436;
            // 
            // forniactiviteBindingSource
            // 
            this.forniactiviteBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.forni_activite);
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.forniactiviteBindingSource, "nom_active", true));
            this.searchLookUpEdit1.EditValue = "";
            this.searchLookUpEdit1.Location = new System.Drawing.Point(15, 56);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.DataSource = this.typeactivitefornisseurBindingSource;
            this.searchLookUpEdit1.Properties.DisplayMember = "nom_activite";
            this.searchLookUpEdit1.Properties.ValueMember = "nom_activite";
            this.searchLookUpEdit1.Properties.View = this.searchLookUpEdit1View;
            this.searchLookUpEdit1.Size = new System.Drawing.Size(309, 22);
            this.searchLookUpEdit1.TabIndex = 1;
            // 
            // typeactivitefornisseurBindingSource
            // 
            this.typeactivitefornisseurBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.type_activite_fornisseur);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcode_activite,
            this.colnom_activite});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsBehavior.ReadOnly = true;
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colcode_activite
            // 
            this.colcode_activite.FieldName = "code_activite";
            this.colcode_activite.Name = "colcode_activite";
            this.colcode_activite.Visible = true;
            this.colcode_activite.VisibleIndex = 0;
            this.colcode_activite.Width = 200;
            // 
            // colnom_activite
            // 
            this.colnom_activite.FieldName = "nom_activite";
            this.colnom_activite.Name = "colnom_activite";
            this.colnom_activite.Visible = true;
            this.colnom_activite.VisibleIndex = 1;
            this.colnom_activite.Width = 844;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(15, 164);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(88, 29);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "حفــــظ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(15, 118);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(61, 29);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "اضافة";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.searchLookUpEdit1);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Location = new System.Drawing.Point(509, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 210);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(178, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(146, 14);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = " : اسم  و رمز النشاط التجاري";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(128, 19);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(108, 29);
            this.simpleButton3.TabIndex = 5;
            this.simpleButton3.Text = "حذف";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.simpleButton3);
            this.groupBox2.Location = new System.Drawing.Point(509, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 68);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // add_activite_fornisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 374);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_activite_fornisseur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة النشاط التجاري للممول";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forniactiviteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forniactiviteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeactivitefornisseurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource forniactiviteBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_active;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_active;
        private System.Windows.Forms.BindingSource typeactivitefornisseurBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_activite;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_activite;
        public DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        public DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource forniactiviteBindingSource1;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
    }
}