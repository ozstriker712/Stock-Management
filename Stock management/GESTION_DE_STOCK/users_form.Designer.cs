namespace GESTION_DE_STOCK
{
    partial class users_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(users_form));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_names = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpasswords = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpermissions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.usersBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 16);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(664, 218);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.users);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_user,
            this.coluser_names,
            this.colpasswords,
            this.colpermissions});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_user
            // 
            this.colid_user.Caption = "الرقم";
            this.colid_user.FieldName = "id_user";
            this.colid_user.Name = "colid_user";
            this.colid_user.Visible = true;
            this.colid_user.VisibleIndex = 0;
            this.colid_user.Width = 64;
            // 
            // coluser_names
            // 
            this.coluser_names.Caption = "اسم المستخدم";
            this.coluser_names.FieldName = "user_names";
            this.coluser_names.Name = "coluser_names";
            this.coluser_names.Visible = true;
            this.coluser_names.VisibleIndex = 1;
            this.coluser_names.Width = 205;
            // 
            // colpasswords
            // 
            this.colpasswords.Caption = "كملة السر";
            this.colpasswords.FieldName = "passwords";
            this.colpasswords.Name = "colpasswords";
            this.colpasswords.Visible = true;
            this.colpasswords.VisibleIndex = 2;
            this.colpasswords.Width = 306;
            // 
            // colpermissions
            // 
            this.colpermissions.Caption = "الترخيص";
            this.colpermissions.FieldName = "permissions";
            this.colpermissions.Name = "colpermissions";
            this.colpermissions.Visible = true;
            this.colpermissions.VisibleIndex = 3;
            this.colpermissions.Width = 108;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(568, 135);
            this.xtraTabControl1.TabIndex = 64;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.comboBoxEdit1);
            this.xtraTabPage1.Controls.Add(this.simpleButton1);
            this.xtraTabPage1.Controls.Add(this.simpleButton2);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Controls.Add(this.textEdit3);
            this.xtraTabPage1.Controls.Add(this.textEdit2);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(562, 107);
            this.xtraTabPage1.Text = "اضافــــــــــة مستخـــــــدم جديد";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.usersBindingSource, "permissions", true));
            this.comboBoxEdit1.Location = new System.Drawing.Point(477, 53);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit1.Size = new System.Drawing.Size(61, 20);
            this.comboBoxEdit1.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(19, 60);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(128, 38);
            this.simpleButton1.TabIndex = 30;
            this.simpleButton1.Text = "تأكـــــــــــيد ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(19, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(128, 38);
            this.simpleButton2.TabIndex = 39;
            this.simpleButton2.Text = "اضافة مستخدم";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "اسم المستخدم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "نوع الترخيص";
            // 
            // textEdit3
            // 
            this.textEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.usersBindingSource, "passwords", true));
            this.textEdit3.Location = new System.Drawing.Point(322, 53);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(129, 20);
            this.textEdit3.TabIndex = 2;
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.usersBindingSource, "user_names", true));
            this.textEdit2.Location = new System.Drawing.Point(170, 53);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(133, 20);
            this.textEdit2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "كلمة المرور";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.simpleButton4);
            this.xtraTabPage2.Controls.Add(this.simpleButton3);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(562, 107);
            this.xtraTabPage2.Text = "تغييـر  كلمة مرور المستخدم ";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(94, 35);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(152, 37);
            this.simpleButton4.TabIndex = 53;
            this.simpleButton4.Text = "تعديــــــــــــــــل";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(324, 35);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(155, 38);
            this.simpleButton3.TabIndex = 52;
            this.simpleButton3.Text = "حذف المستخدم";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(586, 36);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(97, 101);
            this.pictureEdit1.TabIndex = 63;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 237);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "                                                                      [       تعد" +
    "يل المعلومات على مستوى الجدول      ]";
            // 
            // users_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 396);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.pictureEdit1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "users_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المستخدمين";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        public DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.Label label2;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid_user;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_names;
        private DevExpress.XtraGrid.Columns.GridColumn colpasswords;
        private DevExpress.XtraGrid.Columns.GridColumn colpermissions;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}