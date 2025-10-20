namespace GESTION_DE_STOCK
{
    partial class save_data_base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(save_data_base));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 266);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 13);
            this.labelControl2.TabIndex = 74;
            this.labelControl2.Text = "Chargement ...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(16, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 73;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(22, 28);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(168, 57);
            this.simpleButton1.TabIndex = 72;
            this.simpleButton1.Text = "BDD  حفـــــــــــــظ ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(12, 285);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Size = new System.Drawing.Size(664, 18);
            this.progressBarControl1.TabIndex = 71;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(1, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(155, 139);
            this.pictureEdit1.TabIndex = 75;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(219, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(296, 21);
            this.comboBox1.TabIndex = 76;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(65, 29);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(126, 32);
            this.simpleButton2.TabIndex = 77;
            this.simpleButton2.Text = "اتصــــال";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textEdit2);
            this.groupBox2.Controls.Add(this.simpleButton4);
            this.groupBox2.Controls.Add(this.simpleButton1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(12, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(676, 112);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[   حفظ  قاعدة البيانات   ]";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(369, 51);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.ReadOnly = true;
            this.textEdit2.Size = new System.Drawing.Size(286, 20);
            this.textEdit2.TabIndex = 6;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Appearance.Options.UseForeColor = true;
            this.simpleButton4.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(248, 34);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(115, 37);
            this.simpleButton4.TabIndex = 7;
            this.simpleButton4.Text = "تحديد مكان الحفظ";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Location = new System.Drawing.Point(162, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(526, 100);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[   الاتصال بقاعدة البيانات   ]";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // save_data_base
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "save_data_base";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حفــــــــــــــظ قاعـــــــــــــدة البيانــــــات";
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public DevExpress.XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private System.Windows.Forms.Timer timer1;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        public DevExpress.XtraEditors.SimpleButton simpleButton4;
        public DevExpress.XtraEditors.SimpleButton simpleButton2;
        public DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
    }
}