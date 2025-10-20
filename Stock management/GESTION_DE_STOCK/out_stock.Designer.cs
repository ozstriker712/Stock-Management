namespace GESTION_DE_STOCK
{
    partial class out_stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(out_stock));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.stockoutBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldate_out = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquantite_out = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colles_articles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprix_article_out = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprix_out_unitaire_x_quantite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stockoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.lesbonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.lesservicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.lesarticlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_article = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_article = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquantite_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcatgr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockoutBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockoutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesbonBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesservicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesarticlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.stockoutBindingSource1;
            this.gridControl1.Location = new System.Drawing.Point(30, 262);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1069, 417);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stockoutBindingSource1
            // 
            this.stockoutBindingSource1.DataSource = typeof(GESTION_DE_STOCK.model.stock_out);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldate_out,
            this.colquantite_out,
            this.colles_articles,
            this.colprix_article_out,
            this.colprix_out_unitaire_x_quantite});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 50;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // coldate_out
            // 
            this.coldate_out.Caption = "التاريخ";
            this.coldate_out.FieldName = "date_out";
            this.coldate_out.Name = "coldate_out";
            this.coldate_out.Visible = true;
            this.coldate_out.VisibleIndex = 1;
            this.coldate_out.Width = 85;
            // 
            // colquantite_out
            // 
            this.colquantite_out.Caption = "العدد";
            this.colquantite_out.FieldName = "quantite_out";
            this.colquantite_out.Name = "colquantite_out";
            this.colquantite_out.Visible = true;
            this.colquantite_out.VisibleIndex = 2;
            this.colquantite_out.Width = 91;
            // 
            // colles_articles
            // 
            this.colles_articles.Caption = "اسم العتــــــــاد";
            this.colles_articles.FieldName = "les_articles.nom_article";
            this.colles_articles.Name = "colles_articles";
            this.colles_articles.Visible = true;
            this.colles_articles.VisibleIndex = 0;
            this.colles_articles.Width = 471;
            // 
            // colprix_article_out
            // 
            this.colprix_article_out.Caption = "سعر الوحدة";
            this.colprix_article_out.FieldName = "prix_article_out";
            this.colprix_article_out.Name = "colprix_article_out";
            this.colprix_article_out.Visible = true;
            this.colprix_article_out.VisibleIndex = 3;
            this.colprix_article_out.Width = 128;
            // 
            // colprix_out_unitaire_x_quantite
            // 
            this.colprix_out_unitaire_x_quantite.Caption = "السعر الكلي";
            this.colprix_out_unitaire_x_quantite.FieldName = "prix_out_unitaire_x_quantite";
            this.colprix_out_unitaire_x_quantite.Name = "colprix_out_unitaire_x_quantite";
            this.colprix_out_unitaire_x_quantite.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "prix_out_unitaire_x_quantite", "Total={0:c2}")});
            this.colprix_out_unitaire_x_quantite.Visible = true;
            this.colprix_out_unitaire_x_quantite.VisibleIndex = 4;
            this.colprix_out_unitaire_x_quantite.Width = 242;
            // 
            // stockoutBindingSource
            // 
            this.stockoutBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.stock_out);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(30, 144);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(122, 43);
            this.simpleButton1.TabIndex = 16;
            this.simpleButton1.Text = "اضـــافة";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(30, 198);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(122, 39);
            this.simpleButton2.TabIndex = 15;
            this.simpleButton2.Text = "حفـــــظ";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.stockoutBindingSource, "quantite_out", true));
            this.textEdit1.Location = new System.Drawing.Point(300, 58);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit1.Size = new System.Drawing.Size(100, 26);
            this.textEdit1.TabIndex = 18;
            this.textEdit1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit1_KeyPress);
            // 
            // dateEdit1
            // 
            this.dateEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lesbonBindingSource, "date_bon", true));
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(150, 58);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.ReadOnly = true;
            this.dateEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateEdit1.Size = new System.Drawing.Size(100, 26);
            this.dateEdit1.TabIndex = 19;
            // 
            // lesbonBindingSource
            // 
            this.lesbonBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.les_bon);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textEdit2);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.textEdit7);
            this.groupBox1.Controls.Add(this.textEdit6);
            this.groupBox1.Controls.Add(this.textEdit3);
            this.groupBox1.Location = new System.Drawing.Point(397, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(702, 109);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[  معلومات الممول و الفاتورة     ]";
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lesservicesBindingSource, "id_service", true));
            this.textEdit2.Location = new System.Drawing.Point(535, 30);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit2.Properties.Mask.EditMask = "00";
            this.textEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit2.Properties.ReadOnly = true;
            this.textEdit2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit2.Size = new System.Drawing.Size(49, 22);
            this.textEdit2.TabIndex = 13;
            // 
            // lesservicesBindingSource
            // 
            this.lesservicesBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.les_services);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(590, 74);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(64, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = " : رقم الوصــل";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(231, 74);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(77, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = " : تاريــخ الوصـــل";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(590, 33);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "  : الملحقة";
            // 
            // textEdit7
            // 
            this.textEdit7.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lesbonBindingSource, "date_bon", true));
            this.textEdit7.Location = new System.Drawing.Point(150, 69);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit7.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textEdit7.Properties.Appearance.Options.UseFont = true;
            this.textEdit7.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit7.Properties.Mask.EditMask = "\\d?\\d?/\\d?\\d?/\\d\\d\\d\\d";
            this.textEdit7.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.textEdit7.Properties.ReadOnly = true;
            this.textEdit7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit7.Size = new System.Drawing.Size(75, 22);
            this.textEdit7.TabIndex = 4;
            // 
            // textEdit6
            // 
            this.textEdit6.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lesbonBindingSource, "n_bon", true));
            this.textEdit6.Location = new System.Drawing.Point(486, 70);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit6.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textEdit6.Properties.Appearance.Options.UseFont = true;
            this.textEdit6.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit6.Properties.ReadOnly = true;
            this.textEdit6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit6.Size = new System.Drawing.Size(98, 22);
            this.textEdit6.TabIndex = 3;
            // 
            // textEdit3
            // 
            this.textEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lesservicesBindingSource, "nom_service", true));
            this.textEdit3.Location = new System.Drawing.Point(150, 30);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textEdit3.Properties.Appearance.Options.UseFont = true;
            this.textEdit3.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit3.Properties.ReadOnly = true;
            this.textEdit3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit3.Size = new System.Drawing.Size(379, 22);
            this.textEdit3.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.searchLookUpEdit1);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.dateEdit1);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Location = new System.Drawing.Point(170, 127);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(929, 120);
            this.groupControl1.TabIndex = 25;
            this.groupControl1.Tag = "";
            this.groupControl1.Text = "[         معلومـــــات المنتج       ]";
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.stockoutBindingSource, "les_articles_id_article", true));
            this.searchLookUpEdit1.EditValue = "";
            this.searchLookUpEdit1.Location = new System.Drawing.Point(442, 58);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.DataSource = this.lesarticlesBindingSource;
            this.searchLookUpEdit1.Properties.DisplayMember = "nom_article";
            this.searchLookUpEdit1.Properties.ValueMember = "id_article";
            this.searchLookUpEdit1.Properties.View = this.searchLookUpEdit1View;
            this.searchLookUpEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchLookUpEdit1.Size = new System.Drawing.Size(400, 26);
            this.searchLookUpEdit1.TabIndex = 21;
            this.searchLookUpEdit1.EditValueChanged += new System.EventHandler(this.searchLookUpEdit1_EditValueChanged_1);
            // 
            // lesarticlesBindingSource
            // 
            this.lesarticlesBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.les_articles);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_article,
            this.colnom_article,
            this.colquantite_total,
            this.colcatgr});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid_article
            // 
            this.colid_article.Caption = "الرقم";
            this.colid_article.FieldName = "id_article";
            this.colid_article.Name = "colid_article";
            this.colid_article.Visible = true;
            this.colid_article.VisibleIndex = 0;
            this.colid_article.Width = 103;
            // 
            // colnom_article
            // 
            this.colnom_article.Caption = "اسم المنتج";
            this.colnom_article.FieldName = "nom_article";
            this.colnom_article.Name = "colnom_article";
            this.colnom_article.Visible = true;
            this.colnom_article.VisibleIndex = 1;
            this.colnom_article.Width = 584;
            // 
            // colquantite_total
            // 
            this.colquantite_total.Caption = "الكمية";
            this.colquantite_total.FieldName = "quantite_total";
            this.colquantite_total.Name = "colquantite_total";
            this.colquantite_total.Visible = true;
            this.colquantite_total.VisibleIndex = 2;
            this.colquantite_total.Width = 94;
            // 
            // colcatgr
            // 
            this.colcatgr.Caption = "الصنف";
            this.colcatgr.FieldName = "catgr.nom_catgr";
            this.colcatgr.Name = "colcatgr";
            this.colcatgr.Visible = true;
            this.colcatgr.VisibleIndex = 3;
            this.colcatgr.Width = 212;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(216, 34);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 13);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "التاريخ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(371, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "العدد";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(170, 34);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(178, 47);
            this.simpleButton3.TabIndex = 34;
            this.simpleButton3.TabStop = false;
            this.simpleButton3.Text = "طبــــــاعة الوصـــــــــــل";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(760, 34);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(82, 13);
            this.labelControl7.TabIndex = 22;
            this.labelControl7.Text = "اســـــم العتــــاد";
            // 
            // out_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 688);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "out_stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضــــــــــــــــافة    :  وصل تسليم  المنتج";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockoutBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockoutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesbonBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesservicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesarticlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        public DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.BindingSource stockoutBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_out;
        private DevExpress.XtraGrid.Columns.GridColumn colquantite_out;
        private DevExpress.XtraGrid.Columns.GridColumn colles_articles;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource lesservicesBindingSource;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private System.Windows.Forms.BindingSource lesbonBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.BindingSource stockoutBindingSource1;
        public DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private System.Windows.Forms.BindingSource lesarticlesBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid_article;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_article;
        private DevExpress.XtraGrid.Columns.GridColumn colquantite_total;
        private DevExpress.XtraGrid.Columns.GridColumn colcatgr;
        private DevExpress.XtraGrid.Columns.GridColumn colprix_article_out;
        private DevExpress.XtraGrid.Columns.GridColumn colprix_out_unitaire_x_quantite;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        public DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}