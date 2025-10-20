namespace GESTION_DE_STOCK
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.marqueeProgressBarControl1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.defaultLookAndFeel2 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // marqueeProgressBarControl1
            // 
            this.marqueeProgressBarControl1.EditValue = 0;
            this.marqueeProgressBarControl1.Location = new System.Drawing.Point(76, 223);
            this.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1";
            this.marqueeProgressBarControl1.Size = new System.Drawing.Size(436, 10);
            this.marqueeProgressBarControl1.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Location = new System.Drawing.Point(455, 292);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(115, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Copyright © 2017-2018";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(78, 206);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Starting...";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "user_names", true));
            this.comboBox1.DataSource = this.usersBindingSource;
            this.comboBox1.DisplayMember = "user_names";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(267, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 103;
            this.comboBox1.TabStop = false;
            this.comboBox1.ValueMember = "user_names";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.users);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Location = new System.Drawing.Point(430, 148);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(66, 13);
            this.Label2.TabIndex = 102;
            this.Label2.Text = "كلمة المرور :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(430, 124);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(88, 13);
            this.Label1.TabIndex = 101;
            this.Label1.Text = "اسم المستخدم :";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(12, 269);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(78, 32);
            this.simpleButton2.TabIndex = 100;
            this.simpleButton2.Text = "اغلاق";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(101, 121);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(150, 42);
            this.simpleButton1.TabIndex = 99;
            this.simpleButton1.Text = "تسجيل الدخـــــــــول";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 98;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl3.Location = new System.Drawing.Point(135, 19);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(350, 16);
            this.labelControl3.TabIndex = 104;
            this.labelControl3.Text = "المؤسســـــة العموميـــــة للصحـــــة الجواريـــــة - الجلفة";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(10, 9);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(80, 83);
            this.pictureEdit2.TabIndex = 105;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(216, 41);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(160, 16);
            this.labelControl10.TabIndex = 108;
            this.labelControl10.Text = "برنامج تسيير المخــــــزون ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl4.Location = new System.Drawing.Point(482, 272);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(88, 14);
            this.labelControl4.TabIndex = 109;
            this.labelControl4.Text = "Bensalem Soft";
            // 
            // settingsBindingSource
            // 
            this.settingsBindingSource.DataSource = typeof(GESTION_DE_STOCK.model.settings);
            // 
            // defaultLookAndFeel2
            // 
            this.defaultLookAndFeel2.LookAndFeel.SkinName = "Office 2013";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 313);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.marqueeProgressBarControl1);
            this.Name = "login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MarqueeProgressBarControl marqueeProgressBarControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox comboBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.BindingSource settingsBindingSource;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel2;
    }
}
