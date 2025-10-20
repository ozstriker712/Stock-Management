namespace GESTION_DE_STOCK
{
    partial class Setting_Prices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting_Prices));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(293, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 13);
            this.labelControl1.TabIndex = 120;
            this.labelControl1.Text = " : اسم المستخدم";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(118, 22);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit1.Size = new System.Drawing.Size(169, 20);
            this.textEdit1.TabIndex = 119;
            this.textEdit1.TabStop = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(29, 49);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(79, 23);
            this.simpleButton2.TabIndex = 118;
            this.simpleButton2.Text = "فتح";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.checkEdit2);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.checkEdit1);
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 155);
            this.groupBox1.TabIndex = 117;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[     يرجى ادخال كلمة المرور للتعديل   ]";
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(246, 48);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit2.Properties.Appearance.Options.UseFont = true;
            this.checkEdit2.Properties.Caption = "متوســــط السعــــر";
            this.checkEdit2.Size = new System.Drawing.Size(147, 20);
            this.checkEdit2.TabIndex = 109;
            this.checkEdit2.CheckedChanged += new System.EventHandler(this.checkEdit2_CheckedChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(118, 96);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(172, 37);
            this.simpleButton1.TabIndex = 110;
            this.simpleButton1.Text = "حفــــظ اعدادات السعـــــر";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(34, 48);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "السعــــر الأعلــــى";
            this.checkEdit1.Size = new System.Drawing.Size(155, 20);
            this.checkEdit1.TabIndex = 108;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 115;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Location = new System.Drawing.Point(293, 52);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(66, 13);
            this.Label2.TabIndex = 116;
            this.Label2.Text = "كلمة المرور :";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.users);
            // 
            // settingsBindingSource
            // 
            this.settingsBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.settings);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.simpleButton2);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Controls.Add(this.Label2);
            this.groupBox2.Controls.Add(this.textEdit1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 94);
            this.groupBox2.TabIndex = 121;
            this.groupBox2.TabStop = false;
            // 
            // Setting_Prices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 283);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setting_Prices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعـــدادت السعــــــــر";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        public System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        public System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private System.Windows.Forms.BindingSource settingsBindingSource;
        public System.Windows.Forms.GroupBox groupBox2;
    }
}