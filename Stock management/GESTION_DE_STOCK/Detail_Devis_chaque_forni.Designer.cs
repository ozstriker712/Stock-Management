namespace GESTION_DE_STOCK
{
    partial class Detail_Devis_chaque_forni
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
            DevExpress.XtraGrid.Columns.GridColumn coldevis_id_devis;
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detail_Devis_chaque_forni));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.fornisseurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.stocksinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldevis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldevis1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldevis2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.devisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            coldevis_id_devis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornisseurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // coldevis_id_devis
            // 
            coldevis_id_devis.Caption = "معلومات الفاتورة";
            coldevis_id_devis.FieldName = "devis_id_devis";
            coldevis_id_devis.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            coldevis_id_devis.Name = "coldevis_id_devis";
            coldevis_id_devis.Visible = true;
            coldevis_id_devis.VisibleIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textEdit1);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.textEdit5);
            this.groupBox1.Controls.Add(this.textEdit4);
            this.groupBox1.Controls.Add(this.textEdit3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(838, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fornisseurBindingSource, "id_fornisseur", true));
            this.textEdit1.Location = new System.Drawing.Point(626, 22);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit1.Properties.Mask.EditMask = "00000";
            this.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit1.Size = new System.Drawing.Size(63, 22);
            this.textEdit1.TabIndex = 15;
            this.textEdit1.TabStop = false;
            // 
            // fornisseurBindingSource
            // 
            this.fornisseurBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.fornisseur);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(705, 26);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(81, 13);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "  :  الممـــــــــــول";
            // 
            // textEdit5
            // 
            this.textEdit5.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fornisseurBindingSource, "societe_fornisseur", true));
            this.textEdit5.Location = new System.Drawing.Point(27, 22);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit5.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textEdit5.Properties.Appearance.Options.UseFont = true;
            this.textEdit5.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit5.Properties.ReadOnly = true;
            this.textEdit5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit5.Size = new System.Drawing.Size(214, 22);
            this.textEdit5.TabIndex = 11;
            this.textEdit5.TabStop = false;
            // 
            // textEdit4
            // 
            this.textEdit4.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fornisseurBindingSource, "prenom_fornisseur", true));
            this.textEdit4.Location = new System.Drawing.Point(280, 22);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textEdit4.Properties.Appearance.Options.UseFont = true;
            this.textEdit4.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit4.Properties.ReadOnly = true;
            this.textEdit4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit4.Size = new System.Drawing.Size(152, 22);
            this.textEdit4.TabIndex = 12;
            this.textEdit4.TabStop = false;
            // 
            // textEdit3
            // 
            this.textEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fornisseurBindingSource, "nom_fornisseur", true));
            this.textEdit3.Location = new System.Drawing.Point(463, 22);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textEdit3.Properties.Appearance.Options.UseFont = true;
            this.textEdit3.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit3.Properties.ReadOnly = true;
            this.textEdit3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit3.Size = new System.Drawing.Size(134, 22);
            this.textEdit3.TabIndex = 13;
            this.textEdit3.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.stocksinBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(351, 516);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stocksinBindingSource
            // 
            this.stocksinBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.stocks_in);
            this.stocksinBindingSource.PositionChanged += new System.EventHandler(this.stocksinBindingSource_PositionChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldevis,
            this.coldevis1,
            this.coldevis2,
            coldevis_id_devis});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.AllowCellMerge = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(coldevis_id_devis, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // coldevis
            // 
            this.coldevis.Caption = "anne facture";
            this.coldevis.FieldName = "devis.anne_facture";
            this.coldevis.Name = "coldevis";
            this.coldevis.Visible = true;
            this.coldevis.VisibleIndex = 2;
            this.coldevis.Width = 71;
            // 
            // coldevis1
            // 
            this.coldevis1.Caption = "date facture";
            this.coldevis1.FieldName = "devis.date_facture";
            this.coldevis1.Name = "coldevis1";
            this.coldevis1.Visible = true;
            this.coldevis1.VisibleIndex = 1;
            this.coldevis1.Width = 76;
            // 
            // coldevis2
            // 
            this.coldevis2.Caption = "n facture";
            this.coldevis2.FieldName = "devis.n_facture";
            this.coldevis2.Name = "coldevis2";
            this.coldevis2.Visible = true;
            this.coldevis2.VisibleIndex = 0;
            this.coldevis2.Width = 55;
            // 
            // devisBindingSource
            // 
            this.devisBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.devis);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(876, 100);
            this.panelControl1.TabIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 100);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(355, 520);
            this.panelControl2.TabIndex = 3;
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Location = new System.Drawing.Point(359, 175);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(383, 70);
            this.filterControl1.TabIndex = 4;
            this.filterControl1.Text = "filterControl1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textEdit2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textEdit6);
            this.groupBox2.Location = new System.Drawing.Point(366, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 285);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[         تفاصيل حسب مجال التاريخ المحدد       ]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "دج";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = ": السعر الكلي لجميع الفواتير ";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(213, 199);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit2.Size = new System.Drawing.Size(257, 22);
            this.textEdit2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = " : العدد الكلي للعتاد في كل الفواتير";
            // 
            // textEdit6
            // 
            this.textEdit6.Location = new System.Drawing.Point(372, 96);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit6.Properties.Appearance.Options.UseFont = true;
            this.textEdit6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit6.Size = new System.Drawing.Size(98, 22);
            this.textEdit6.TabIndex = 7;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(748, 194);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(110, 39);
            this.simpleButton4.TabIndex = 6;
            this.simpleButton4.Text = "بحــــث";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(595, 117);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(270, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "احصائيات حسب المجــــــــــــــال الزمنـــــــــي المحدد";
            // 
            // Detail_Devis_chaque_forni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 620);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.filterControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Detail_Devis_chaque_forni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تفاصيــــــل أكثر - ممول / فاتورة";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornisseurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.BindingSource fornisseurBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.BindingSource devisBindingSource;
        private System.Windows.Forms.BindingSource stocksinBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn coldevis;
        private DevExpress.XtraGrid.Columns.GridColumn coldevis1;
        private DevExpress.XtraGrid.Columns.GridColumn coldevis2;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public DevExpress.XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.Label label3;
        public DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}