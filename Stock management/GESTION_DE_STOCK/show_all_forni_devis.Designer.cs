namespace GESTION_DE_STOCK
{
    partial class show_all_forni_devis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(show_all_forni_devis));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.devisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coln_facture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_facture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colanne_facture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstocks_in = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fornisseurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_fornisseur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_fornisseur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprenom_fornisseur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsociete_fornisseur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldevis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.stocksinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colquantite_in = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprix_article = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colles_articles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colles_articles1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_in = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprix_in_unitaire_x_quntite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornisseurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.devisBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(298, 514);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // devisBindingSource
            // 
            this.devisBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.devis);
            this.devisBindingSource.PositionChanged += new System.EventHandler(this.devisBindingSource_PositionChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coln_facture,
            this.coldate_facture,
            this.colanne_facture,
            this.colstocks_in});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // coln_facture
            // 
            this.coln_facture.Caption = "رقم الفاتورة";
            this.coln_facture.FieldName = "n_facture";
            this.coln_facture.Name = "coln_facture";
            this.coln_facture.Visible = true;
            this.coln_facture.VisibleIndex = 3;
            // 
            // coldate_facture
            // 
            this.coldate_facture.Caption = "تاريخ الفاتورة";
            this.coldate_facture.FieldName = "date_facture";
            this.coldate_facture.Name = "coldate_facture";
            this.coldate_facture.Visible = true;
            this.coldate_facture.VisibleIndex = 2;
            this.coldate_facture.Width = 73;
            // 
            // colanne_facture
            // 
            this.colanne_facture.Caption = "سنة الفاتورة";
            this.colanne_facture.FieldName = "anne_facture";
            this.colanne_facture.Name = "colanne_facture";
            this.colanne_facture.Visible = true;
            this.colanne_facture.VisibleIndex = 1;
            this.colanne_facture.Width = 66;
            // 
            // colstocks_in
            // 
            this.colstocks_in.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colstocks_in.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.colstocks_in.AppearanceCell.Options.UseFont = true;
            this.colstocks_in.AppearanceCell.Options.UseForeColor = true;
            this.colstocks_in.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colstocks_in.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.colstocks_in.AppearanceHeader.Options.UseFont = true;
            this.colstocks_in.AppearanceHeader.Options.UseForeColor = true;
            this.colstocks_in.Caption = "عدد العتاد";
            this.colstocks_in.FieldName = "stocks_in.Count";
            this.colstocks_in.Name = "colstocks_in";
            this.colstocks_in.Visible = true;
            this.colstocks_in.VisibleIndex = 0;
            this.colstocks_in.Width = 65;
            // 
            // fornisseurBindingSource
            // 
            this.fornisseurBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.fornisseur);
            this.fornisseurBindingSource.PositionChanged += new System.EventHandler(this.fornisseurBindingSource_PositionChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.checkEdit2);
            this.panelControl2.Controls.Add(this.checkEdit1);
            this.panelControl2.Controls.Add(this.simpleButton2);
            this.panelControl2.Controls.Add(this.simpleButton1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1358, 77);
            this.panelControl2.TabIndex = 2;
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(638, 38);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkEdit2.Properties.Appearance.Options.UseFont = true;
            this.checkEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.checkEdit2.Properties.Caption = "اضهـــــــــار حسب السنــــة";
            this.checkEdit2.Size = new System.Drawing.Size(201, 20);
            this.checkEdit2.TabIndex = 5;
            this.checkEdit2.CheckedChanged += new System.EventHandler(this.checkEdit2_CheckedChanged);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(142, 40);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.checkEdit1.Properties.Caption = "اضهـــــــــار حسب الصنـــــــــــف";
            this.checkEdit1.Size = new System.Drawing.Size(236, 20);
            this.checkEdit1.TabIndex = 4;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(1177, 21);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(151, 37);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Printing";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(978, 21);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(168, 39);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Export to Excel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.fornisseurBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 21);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(456, 510);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_fornisseur,
            this.colnom_fornisseur,
            this.colprenom_fornisseur,
            this.colsociete_fornisseur,
            this.coldevis});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colid_fornisseur
            // 
            this.colid_fornisseur.Caption = "الرقم";
            this.colid_fornisseur.FieldName = "id_fornisseur";
            this.colid_fornisseur.Name = "colid_fornisseur";
            this.colid_fornisseur.Visible = true;
            this.colid_fornisseur.VisibleIndex = 4;
            this.colid_fornisseur.Width = 41;
            // 
            // colnom_fornisseur
            // 
            this.colnom_fornisseur.Caption = "لفب الممول";
            this.colnom_fornisseur.FieldName = "nom_fornisseur";
            this.colnom_fornisseur.Name = "colnom_fornisseur";
            this.colnom_fornisseur.Visible = true;
            this.colnom_fornisseur.VisibleIndex = 3;
            this.colnom_fornisseur.Width = 87;
            // 
            // colprenom_fornisseur
            // 
            this.colprenom_fornisseur.Caption = "اسم الممول";
            this.colprenom_fornisseur.FieldName = "prenom_fornisseur";
            this.colprenom_fornisseur.Name = "colprenom_fornisseur";
            this.colprenom_fornisseur.Visible = true;
            this.colprenom_fornisseur.VisibleIndex = 2;
            this.colprenom_fornisseur.Width = 116;
            // 
            // colsociete_fornisseur
            // 
            this.colsociete_fornisseur.Caption = "المؤسسة / الشركة";
            this.colsociete_fornisseur.FieldName = "societe_fornisseur";
            this.colsociete_fornisseur.Name = "colsociete_fornisseur";
            this.colsociete_fornisseur.Visible = true;
            this.colsociete_fornisseur.VisibleIndex = 1;
            this.colsociete_fornisseur.Width = 121;
            // 
            // coldevis
            // 
            this.coldevis.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldevis.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.coldevis.AppearanceCell.Options.UseFont = true;
            this.coldevis.AppearanceCell.Options.UseForeColor = true;
            this.coldevis.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldevis.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.coldevis.AppearanceHeader.Options.UseFont = true;
            this.coldevis.AppearanceHeader.Options.UseForeColor = true;
            this.coldevis.Caption = "عدد الفواتير";
            this.coldevis.FieldName = "devis.Count";
            this.coldevis.Name = "coldevis";
            this.coldevis.Visible = true;
            this.coldevis.VisibleIndex = 0;
            this.coldevis.Width = 72;
            // 
            // gridControl3
            // 
            this.gridControl3.DataSource = this.stocksinBindingSource;
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(2, 21);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(590, 514);
            this.gridControl3.TabIndex = 1;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // stocksinBindingSource
            // 
            this.stocksinBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.stocks_in);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colquantite_in,
            this.colprix_article,
            this.colles_articles,
            this.colles_articles1,
            this.coldate_in,
            this.colprix_in_unitaire_x_quntite});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.IndicatorWidth = 50;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.ReadOnly = true;
            this.gridView3.OptionsPrint.AutoWidth = false;
            this.gridView3.OptionsView.ColumnAutoWidth = false;
            this.gridView3.OptionsView.ShowFooter = true;
            this.gridView3.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView3_CustomDrawRowIndicator);
            // 
            // colquantite_in
            // 
            this.colquantite_in.Caption = "العدد";
            this.colquantite_in.FieldName = "quantite_in";
            this.colquantite_in.Name = "colquantite_in";
            this.colquantite_in.Visible = true;
            this.colquantite_in.VisibleIndex = 2;
            this.colquantite_in.Width = 63;
            // 
            // colprix_article
            // 
            this.colprix_article.Caption = "سعر الوحدة";
            this.colprix_article.FieldName = "prix_article";
            this.colprix_article.Name = "colprix_article";
            this.colprix_article.Visible = true;
            this.colprix_article.VisibleIndex = 3;
            this.colprix_article.Width = 101;
            // 
            // colles_articles
            // 
            this.colles_articles.Caption = "اسم العتاد";
            this.colles_articles.FieldName = "les_articles.nom_article";
            this.colles_articles.Name = "colles_articles";
            this.colles_articles.Visible = true;
            this.colles_articles.VisibleIndex = 0;
            this.colles_articles.Width = 271;
            // 
            // colles_articles1
            // 
            this.colles_articles1.Caption = "الصنف";
            this.colles_articles1.FieldName = "les_articles.catgr.nom_catgr";
            this.colles_articles1.Name = "colles_articles1";
            this.colles_articles1.Visible = true;
            this.colles_articles1.VisibleIndex = 5;
            this.colles_articles1.Width = 258;
            // 
            // coldate_in
            // 
            this.coldate_in.Caption = "التاريخ";
            this.coldate_in.FieldName = "date_in";
            this.coldate_in.Name = "coldate_in";
            this.coldate_in.Visible = true;
            this.coldate_in.VisibleIndex = 4;
            this.coldate_in.Width = 82;
            // 
            // colprix_in_unitaire_x_quntite
            // 
            this.colprix_in_unitaire_x_quntite.Caption = "السعر الكلي";
            this.colprix_in_unitaire_x_quntite.FieldName = "prix_in_unitaire_x_quntite";
            this.colprix_in_unitaire_x_quntite.Name = "colprix_in_unitaire_x_quntite";
            this.colprix_in_unitaire_x_quntite.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "prix_in_unitaire_x_quntite", "Total={0:c2}")});
            this.colprix_in_unitaire_x_quntite.Visible = true;
            this.colprix_in_unitaire_x_quntite.VisibleIndex = 1;
            this.colprix_in_unitaire_x_quntite.Width = 158;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.groupControl1);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl4.Location = new System.Drawing.Point(896, 77);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(462, 537);
            this.panelControl4.TabIndex = 5;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.gridControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(0, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(460, 533);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "جــــــــــــــــــدول الممــــــــــولين";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl2.Location = new System.Drawing.Point(594, 77);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(302, 537);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "جـــــــــــدول الفواتيـــــــــــــر";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridControl3);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 77);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(594, 537);
            this.groupControl3.TabIndex = 7;
            this.groupControl3.Text = "جـــــــــــــــــــــــدول العتــــــــــاد الخاص بكل فاتورة";
            // 
            // show_all_forni_devis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 614);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "show_all_forni_devis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اظهــــــار جميع الممـــــــــــــولين و فواتيــــــــــــر";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornisseurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource fornisseurBindingSource;
        private System.Windows.Forms.BindingSource devisBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn coln_facture;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_facture;
        private DevExpress.XtraGrid.Columns.GridColumn colanne_facture;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colid_fornisseur;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_fornisseur;
        private DevExpress.XtraGrid.Columns.GridColumn colprenom_fornisseur;
        private DevExpress.XtraGrid.Columns.GridColumn colsociete_fornisseur;
        private DevExpress.XtraGrid.Columns.GridColumn coldevis;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.BindingSource stocksinBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colquantite_in;
        private DevExpress.XtraGrid.Columns.GridColumn colprix_article;
        private DevExpress.XtraGrid.Columns.GridColumn colles_articles;
        private DevExpress.XtraGrid.Columns.GridColumn colles_articles1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        public DevExpress.XtraGrid.GridControl gridControl3;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        public DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.Columns.GridColumn colstocks_in;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_in;
        private DevExpress.XtraGrid.Columns.GridColumn colprix_in_unitaire_x_quntite;
    }
}