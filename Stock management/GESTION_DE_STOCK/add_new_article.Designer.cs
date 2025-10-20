namespace GESTION_DE_STOCK
{
    partial class add_new_article
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_new_article));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.lesarticlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catgrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_catgr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_catgr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.searchLookUpEdit2 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.lesarticlesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_article = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_article = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcatgr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesarticlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catgrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesarticlesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(13, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(754, 151);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.searchLookUpEdit1);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.simpleButton2);
            this.xtraTabPage1.Controls.Add(this.simpleButton1);
            this.xtraTabPage1.Controls.Add(this.textEdit1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(748, 123);
            this.xtraTabPage1.Text = "اضــــــــــافة الى القائمة";
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lesarticlesBindingSource, "catgr_id_catgr", true));
            this.searchLookUpEdit1.EditValue = "اختر الصنف الخاص بالعتاد";
            this.searchLookUpEdit1.Location = new System.Drawing.Point(326, 30);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.DataSource = this.catgrBindingSource;
            this.searchLookUpEdit1.Properties.DisplayMember = "nom_catgr";
            this.searchLookUpEdit1.Properties.ValueMember = "id_catgr";
            this.searchLookUpEdit1.Properties.View = this.searchLookUpEdit1View;
            this.searchLookUpEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchLookUpEdit1.Size = new System.Drawing.Size(296, 22);
            this.searchLookUpEdit1.TabIndex = 2;
            // 
            // lesarticlesBindingSource
            // 
            this.lesarticlesBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.les_articles);
            // 
            // catgrBindingSource
            // 
            this.catgrBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.catgr);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_catgr,
            this.colnom_catgr});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid_catgr
            // 
            this.colid_catgr.FieldName = "id_catgr";
            this.colid_catgr.Name = "colid_catgr";
            this.colid_catgr.Visible = true;
            this.colid_catgr.VisibleIndex = 0;
            this.colid_catgr.Width = 146;
            // 
            // colnom_catgr
            // 
            this.colnom_catgr.FieldName = "nom_catgr";
            this.colnom_catgr.Name = "colnom_catgr";
            this.colnom_catgr.Visible = true;
            this.colnom_catgr.VisibleIndex = 1;
            this.colnom_catgr.Width = 896;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(628, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(88, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = " : اسم العتــــــــاد";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(628, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = " : الصنـــــــــــف ";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(31, 69);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(121, 40);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "تأكيـــــد";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(30, 15);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(122, 40);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "اضافـــة";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lesarticlesBindingSource, "nom_article", true));
            this.textEdit1.Location = new System.Drawing.Point(235, 66);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit1.Size = new System.Drawing.Size(387, 22);
            this.textEdit1.TabIndex = 3;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.searchLookUpEdit2);
            this.xtraTabPage2.Controls.Add(this.labelControl3);
            this.xtraTabPage2.Controls.Add(this.labelControl4);
            this.xtraTabPage2.Controls.Add(this.simpleButton3);
            this.xtraTabPage2.Controls.Add(this.simpleButton4);
            this.xtraTabPage2.Controls.Add(this.textEdit2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(748, 123);
            this.xtraTabPage2.Text = "تعديـــل او حذف من القائمة";
            // 
            // searchLookUpEdit2
            // 
            this.searchLookUpEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lesarticlesBindingSource1, "catgr_id_catgr", true));
            this.searchLookUpEdit2.EditValue = "اختر الصنف الخاص بالعتاد";
            this.searchLookUpEdit2.Location = new System.Drawing.Point(332, 33);
            this.searchLookUpEdit2.Name = "searchLookUpEdit2";
            this.searchLookUpEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLookUpEdit2.Properties.Appearance.Options.UseFont = true;
            this.searchLookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit2.Properties.DataSource = this.catgrBindingSource;
            this.searchLookUpEdit2.Properties.DisplayMember = "nom_catgr";
            this.searchLookUpEdit2.Properties.ValueMember = "id_catgr";
            this.searchLookUpEdit2.Properties.View = this.gridView2;
            this.searchLookUpEdit2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchLookUpEdit2.Size = new System.Drawing.Size(296, 22);
            this.searchLookUpEdit2.TabIndex = 9;
            // 
            // lesarticlesBindingSource1
            // 
            this.lesarticlesBindingSource1.DataSource = typeof(GESTION_DE_STOCK.model.les_articles);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "id_catgr";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 146;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "nom_catgr";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 896;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(634, 72);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = " : اسم العتــــــــاد";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(634, 36);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(80, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = " : الصنـــــــــــف ";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(26, 72);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(129, 40);
            this.simpleButton3.TabIndex = 5;
            this.simpleButton3.Text = "حــــــذف";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(26, 17);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(129, 40);
            this.simpleButton4.TabIndex = 4;
            this.simpleButton4.Text = "تعـــديل";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lesarticlesBindingSource1, "nom_article", true));
            this.textEdit2.Location = new System.Drawing.Point(237, 69);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Size = new System.Drawing.Size(391, 22);
            this.textEdit2.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.lesarticlesBindingSource1;
            this.gridControl1.Location = new System.Drawing.Point(13, 169);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(753, 525);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.TabStop = false;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_article,
            this.colnom_article,
            this.colcatgr});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            // 
            // colid_article
            // 
            this.colid_article.Caption = "الرقم";
            this.colid_article.FieldName = "id_article";
            this.colid_article.Name = "colid_article";
            this.colid_article.Visible = true;
            this.colid_article.VisibleIndex = 0;
            this.colid_article.Width = 70;
            // 
            // colnom_article
            // 
            this.colnom_article.Caption = "اســـــــــــــم العتــــــــــــاد";
            this.colnom_article.FieldName = "nom_article";
            this.colnom_article.Name = "colnom_article";
            this.colnom_article.Visible = true;
            this.colnom_article.VisibleIndex = 1;
            this.colnom_article.Width = 372;
            // 
            // colcatgr
            // 
            this.colcatgr.Caption = "صنــــــــــف العتاد";
            this.colcatgr.FieldName = "catgr.nom_catgr";
            this.colcatgr.Name = "colcatgr";
            this.colcatgr.Visible = true;
            this.colcatgr.VisibleIndex = 2;
            this.colcatgr.Width = 293;
            // 
            // checkEdit1
            // 
            this.checkEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkEdit1.Location = new System.Drawing.Point(573, 178);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.checkEdit1.Properties.Caption = "اضهـــــــــار حسب الصنف";
            this.checkEdit1.Size = new System.Drawing.Size(177, 20);
            this.checkEdit1.TabIndex = 6;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // add_new_article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 706);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.xtraTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_new_article";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضــــــــــــــــافة  / تعديـــــــــــل/ حــــــــــذف : عتــــــــاد";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesarticlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catgrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesarticlesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton simpleButton2;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource lesarticlesBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_article;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_article;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colcatgr;
        private System.Windows.Forms.BindingSource catgrBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid_catgr;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_catgr;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.BindingSource lesarticlesBindingSource1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        public DevExpress.XtraEditors.TextEdit textEdit1;
        public DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
    }
}