
namespace thenextusgallerysystemnew
{
    partial class EditAdmins
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
            this.textBoxacceslevel = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.addnewadmin = new System.Windows.Forms.TabPage();
            this.labeljobtitle = new System.Windows.Forms.Label();
            this.textBoxjobtitle = new System.Windows.Forms.TextBox();
            this.labeladsurname = new System.Windows.Forms.Label();
            this.labeladname = new System.Windows.Forms.Label();
            this.textBoxadsurname = new System.Windows.Forms.TextBox();
            this.textBoxadname = new System.Windows.Forms.TextBox();
            this.comboBoxacceslevel = new System.Windows.Forms.ComboBox();
            this.labelacceslevel = new System.Windows.Forms.Label();
            this.buttonaddadmin = new System.Windows.Forms.Button();
            this.labelpassword = new System.Windows.Forms.Label();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.labelusername = new System.Windows.Forms.Label();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.removeadmin = new System.Windows.Forms.TabPage();
            this.textBoxpasswordda = new System.Windows.Forms.TextBox();
            this.labelenterpasswordda = new System.Windows.Forms.Label();
            this.comboBoxselectadminda = new System.Windows.Forms.ComboBox();
            this.buttondeleteadmin = new System.Windows.Forms.Button();
            this.labelselectaadmin = new System.Windows.Forms.Label();
            this.changeacceslevel = new System.Windows.Forms.TabPage();
            this.comboBoxca = new System.Windows.Forms.ComboBox();
            this.labelcaacceslevel = new System.Windows.Forms.Label();
            this.textBoxcapassword = new System.Windows.Forms.TextBox();
            this.labelcaenterpassword = new System.Windows.Forms.Label();
            this.comboBoxcaselectaadmin = new System.Windows.Forms.ComboBox();
            this.buttonchangeacceslevel = new System.Windows.Forms.Button();
            this.labelcaselectaadmin = new System.Windows.Forms.Label();
            this.labelactiveadmin = new System.Windows.Forms.Label();
            this.textBoxsavenewadmin = new System.Windows.Forms.TextBox();
            this.textBoxda = new System.Windows.Forms.TextBox();
            this.buttonexit = new System.Windows.Forms.Button();
            this.buttonmainmenu = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.addnewadmin.SuspendLayout();
            this.removeadmin.SuspendLayout();
            this.changeacceslevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxacceslevel
            // 
            this.textBoxacceslevel.Location = new System.Drawing.Point(788, 41);
            this.textBoxacceslevel.Multiline = true;
            this.textBoxacceslevel.Name = "textBoxacceslevel";
            this.textBoxacceslevel.ReadOnly = true;
            this.textBoxacceslevel.Size = new System.Drawing.Size(212, 314);
            this.textBoxacceslevel.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addnewadmin);
            this.tabControl1.Controls.Add(this.removeadmin);
            this.tabControl1.Controls.Add(this.changeacceslevel);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(524, 223);
            this.tabControl1.TabIndex = 5;
            // 
            // addnewadmin
            // 
            this.addnewadmin.Controls.Add(this.labeljobtitle);
            this.addnewadmin.Controls.Add(this.textBoxjobtitle);
            this.addnewadmin.Controls.Add(this.labeladsurname);
            this.addnewadmin.Controls.Add(this.labeladname);
            this.addnewadmin.Controls.Add(this.textBoxadsurname);
            this.addnewadmin.Controls.Add(this.textBoxadname);
            this.addnewadmin.Controls.Add(this.comboBoxacceslevel);
            this.addnewadmin.Controls.Add(this.labelacceslevel);
            this.addnewadmin.Controls.Add(this.buttonaddadmin);
            this.addnewadmin.Controls.Add(this.labelpassword);
            this.addnewadmin.Controls.Add(this.textBoxpassword);
            this.addnewadmin.Controls.Add(this.labelusername);
            this.addnewadmin.Controls.Add(this.textBoxusername);
            this.addnewadmin.Location = new System.Drawing.Point(4, 22);
            this.addnewadmin.Name = "addnewadmin";
            this.addnewadmin.Padding = new System.Windows.Forms.Padding(3);
            this.addnewadmin.Size = new System.Drawing.Size(516, 197);
            this.addnewadmin.TabIndex = 0;
            this.addnewadmin.Text = "Yeni Yetkili Ekle";
            this.addnewadmin.UseVisualStyleBackColor = true;
            // 
            // labeljobtitle
            // 
            this.labeljobtitle.AutoSize = true;
            this.labeljobtitle.Location = new System.Drawing.Point(292, 107);
            this.labeljobtitle.Name = "labeljobtitle";
            this.labeljobtitle.Size = new System.Drawing.Size(55, 13);
            this.labeljobtitle.TabIndex = 13;
            this.labeljobtitle.Text = "İş Ünvanı:";
            // 
            // textBoxjobtitle
            // 
            this.textBoxjobtitle.Location = new System.Drawing.Point(353, 104);
            this.textBoxjobtitle.MaxLength = 30;
            this.textBoxjobtitle.Name = "textBoxjobtitle";
            this.textBoxjobtitle.Size = new System.Drawing.Size(145, 20);
            this.textBoxjobtitle.TabIndex = 12;
            // 
            // labeladsurname
            // 
            this.labeladsurname.AutoSize = true;
            this.labeladsurname.Location = new System.Drawing.Point(292, 70);
            this.labeladsurname.Name = "labeladsurname";
            this.labeladsurname.Size = new System.Drawing.Size(40, 13);
            this.labeladsurname.TabIndex = 11;
            this.labeladsurname.Text = "Soyad:";
            // 
            // labeladname
            // 
            this.labeladname.AutoSize = true;
            this.labeladname.Location = new System.Drawing.Point(292, 35);
            this.labeladname.Name = "labeladname";
            this.labeladname.Size = new System.Drawing.Size(23, 13);
            this.labeladname.TabIndex = 10;
            this.labeladname.Text = "Ad:";
            // 
            // textBoxadsurname
            // 
            this.textBoxadsurname.Location = new System.Drawing.Point(353, 67);
            this.textBoxadsurname.MaxLength = 30;
            this.textBoxadsurname.Name = "textBoxadsurname";
            this.textBoxadsurname.Size = new System.Drawing.Size(145, 20);
            this.textBoxadsurname.TabIndex = 9;
            // 
            // textBoxadname
            // 
            this.textBoxadname.Location = new System.Drawing.Point(353, 28);
            this.textBoxadname.MaxLength = 30;
            this.textBoxadname.Name = "textBoxadname";
            this.textBoxadname.Size = new System.Drawing.Size(145, 20);
            this.textBoxadname.TabIndex = 8;
            // 
            // comboBoxacceslevel
            // 
            this.comboBoxacceslevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxacceslevel.FormattingEnabled = true;
            this.comboBoxacceslevel.Location = new System.Drawing.Point(119, 104);
            this.comboBoxacceslevel.Name = "comboBoxacceslevel";
            this.comboBoxacceslevel.Size = new System.Drawing.Size(145, 21);
            this.comboBoxacceslevel.TabIndex = 7;
            // 
            // labelacceslevel
            // 
            this.labelacceslevel.AutoSize = true;
            this.labelacceslevel.Location = new System.Drawing.Point(23, 107);
            this.labelacceslevel.Name = "labelacceslevel";
            this.labelacceslevel.Size = new System.Drawing.Size(73, 13);
            this.labelacceslevel.TabIndex = 6;
            this.labelacceslevel.Text = "Yetki Seviyesi";
            // 
            // buttonaddadmin
            // 
            this.buttonaddadmin.Location = new System.Drawing.Point(6, 149);
            this.buttonaddadmin.Name = "buttonaddadmin";
            this.buttonaddadmin.Size = new System.Drawing.Size(87, 23);
            this.buttonaddadmin.TabIndex = 4;
            this.buttonaddadmin.Text = "Sisteme Ekle";
            this.buttonaddadmin.UseVisualStyleBackColor = true;
            this.buttonaddadmin.Click += new System.EventHandler(this.buttonaddadmin_Click);
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Location = new System.Drawing.Point(23, 70);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(28, 13);
            this.labelpassword.TabIndex = 3;
            this.labelpassword.Text = "Şifre";
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Location = new System.Drawing.Point(119, 67);
            this.textBoxpassword.MaxLength = 8;
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(145, 20);
            this.textBoxpassword.TabIndex = 2;
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Location = new System.Drawing.Point(23, 28);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(67, 13);
            this.labelusername.TabIndex = 1;
            this.labelusername.Text = "Kullanıcı Adı:";
            // 
            // textBoxusername
            // 
            this.textBoxusername.Location = new System.Drawing.Point(119, 25);
            this.textBoxusername.MaxLength = 15;
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(145, 20);
            this.textBoxusername.TabIndex = 0;
            // 
            // removeadmin
            // 
            this.removeadmin.Controls.Add(this.textBoxpasswordda);
            this.removeadmin.Controls.Add(this.labelenterpasswordda);
            this.removeadmin.Controls.Add(this.comboBoxselectadminda);
            this.removeadmin.Controls.Add(this.buttondeleteadmin);
            this.removeadmin.Controls.Add(this.labelselectaadmin);
            this.removeadmin.Location = new System.Drawing.Point(4, 22);
            this.removeadmin.Name = "removeadmin";
            this.removeadmin.Padding = new System.Windows.Forms.Padding(3);
            this.removeadmin.Size = new System.Drawing.Size(516, 197);
            this.removeadmin.TabIndex = 1;
            this.removeadmin.Text = "Yetkili Sil";
            this.removeadmin.UseVisualStyleBackColor = true;
            // 
            // textBoxpasswordda
            // 
            this.textBoxpasswordda.Location = new System.Drawing.Point(250, 85);
            this.textBoxpasswordda.MaxLength = 8;
            this.textBoxpasswordda.Name = "textBoxpasswordda";
            this.textBoxpasswordda.Size = new System.Drawing.Size(121, 20);
            this.textBoxpasswordda.TabIndex = 11;
            // 
            // labelenterpasswordda
            // 
            this.labelenterpasswordda.AutoSize = true;
            this.labelenterpasswordda.Location = new System.Drawing.Point(126, 89);
            this.labelenterpasswordda.Name = "labelenterpasswordda";
            this.labelenterpasswordda.Size = new System.Drawing.Size(108, 13);
            this.labelenterpasswordda.TabIndex = 10;
            this.labelenterpasswordda.Text = "Llütfen şifrenizi giriniz:";
            // 
            // comboBoxselectadminda
            // 
            this.comboBoxselectadminda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxselectadminda.FormattingEnabled = true;
            this.comboBoxselectadminda.Location = new System.Drawing.Point(250, 48);
            this.comboBoxselectadminda.Name = "comboBoxselectadminda";
            this.comboBoxselectadminda.Size = new System.Drawing.Size(121, 21);
            this.comboBoxselectadminda.TabIndex = 9;
            // 
            // buttondeleteadmin
            // 
            this.buttondeleteadmin.Location = new System.Drawing.Point(271, 129);
            this.buttondeleteadmin.Name = "buttondeleteadmin";
            this.buttondeleteadmin.Size = new System.Drawing.Size(75, 23);
            this.buttondeleteadmin.TabIndex = 8;
            this.buttondeleteadmin.Text = "Tamam";
            this.buttondeleteadmin.UseVisualStyleBackColor = true;
            this.buttondeleteadmin.Click += new System.EventHandler(this.buttondeleteadmin_Click);
            // 
            // labelselectaadmin
            // 
            this.labelselectaadmin.AutoSize = true;
            this.labelselectaadmin.Location = new System.Drawing.Point(126, 51);
            this.labelselectaadmin.Name = "labelselectaadmin";
            this.labelselectaadmin.Size = new System.Drawing.Size(118, 13);
            this.labelselectaadmin.TabIndex = 5;
            this.labelselectaadmin.Text = "Lütfen bir yetkili seçiniz.";
            // 
            // changeacceslevel
            // 
            this.changeacceslevel.Controls.Add(this.comboBoxca);
            this.changeacceslevel.Controls.Add(this.labelcaacceslevel);
            this.changeacceslevel.Controls.Add(this.textBoxcapassword);
            this.changeacceslevel.Controls.Add(this.labelcaenterpassword);
            this.changeacceslevel.Controls.Add(this.comboBoxcaselectaadmin);
            this.changeacceslevel.Controls.Add(this.buttonchangeacceslevel);
            this.changeacceslevel.Controls.Add(this.labelcaselectaadmin);
            this.changeacceslevel.Location = new System.Drawing.Point(4, 22);
            this.changeacceslevel.Name = "changeacceslevel";
            this.changeacceslevel.Size = new System.Drawing.Size(516, 197);
            this.changeacceslevel.TabIndex = 2;
            this.changeacceslevel.Text = "Yetki Düzeyi Değiştir";
            this.changeacceslevel.UseVisualStyleBackColor = true;
            // 
            // comboBoxca
            // 
            this.comboBoxca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxca.FormattingEnabled = true;
            this.comboBoxca.Location = new System.Drawing.Point(254, 64);
            this.comboBoxca.Name = "comboBoxca";
            this.comboBoxca.Size = new System.Drawing.Size(121, 21);
            this.comboBoxca.TabIndex = 18;
            // 
            // labelcaacceslevel
            // 
            this.labelcaacceslevel.AutoSize = true;
            this.labelcaacceslevel.Location = new System.Drawing.Point(130, 67);
            this.labelcaacceslevel.Name = "labelcaacceslevel";
            this.labelcaacceslevel.Size = new System.Drawing.Size(73, 13);
            this.labelcaacceslevel.TabIndex = 17;
            this.labelcaacceslevel.Text = "Yetki Seviyesi";
            // 
            // textBoxcapassword
            // 
            this.textBoxcapassword.Location = new System.Drawing.Point(254, 96);
            this.textBoxcapassword.MaxLength = 8;
            this.textBoxcapassword.Name = "textBoxcapassword";
            this.textBoxcapassword.Size = new System.Drawing.Size(121, 20);
            this.textBoxcapassword.TabIndex = 16;
            // 
            // labelcaenterpassword
            // 
            this.labelcaenterpassword.AutoSize = true;
            this.labelcaenterpassword.Location = new System.Drawing.Point(130, 103);
            this.labelcaenterpassword.Name = "labelcaenterpassword";
            this.labelcaenterpassword.Size = new System.Drawing.Size(106, 13);
            this.labelcaenterpassword.TabIndex = 15;
            this.labelcaenterpassword.Text = "Lütfen şifrenizi giriniz:";
            // 
            // comboBoxcaselectaadmin
            // 
            this.comboBoxcaselectaadmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxcaselectaadmin.FormattingEnabled = true;
            this.comboBoxcaselectaadmin.Location = new System.Drawing.Point(254, 32);
            this.comboBoxcaselectaadmin.Name = "comboBoxcaselectaadmin";
            this.comboBoxcaselectaadmin.Size = new System.Drawing.Size(121, 21);
            this.comboBoxcaselectaadmin.TabIndex = 14;
            // 
            // buttonchangeacceslevel
            // 
            this.buttonchangeacceslevel.Location = new System.Drawing.Point(275, 141);
            this.buttonchangeacceslevel.Name = "buttonchangeacceslevel";
            this.buttonchangeacceslevel.Size = new System.Drawing.Size(75, 23);
            this.buttonchangeacceslevel.TabIndex = 13;
            this.buttonchangeacceslevel.Text = "Tamam";
            this.buttonchangeacceslevel.UseVisualStyleBackColor = true;
            this.buttonchangeacceslevel.Click += new System.EventHandler(this.buttonchangeacceslevel_Click);
            // 
            // labelcaselectaadmin
            // 
            this.labelcaselectaadmin.AutoSize = true;
            this.labelcaselectaadmin.Location = new System.Drawing.Point(130, 35);
            this.labelcaselectaadmin.Name = "labelcaselectaadmin";
            this.labelcaselectaadmin.Size = new System.Drawing.Size(118, 13);
            this.labelcaselectaadmin.TabIndex = 12;
            this.labelcaselectaadmin.Text = "Lütfen bir yetkili seçiniz.";
            // 
            // labelactiveadmin
            // 
            this.labelactiveadmin.AutoSize = true;
            this.labelactiveadmin.Location = new System.Drawing.Point(13, 9);
            this.labelactiveadmin.Name = "labelactiveadmin";
            this.labelactiveadmin.Size = new System.Drawing.Size(108, 13);
            this.labelactiveadmin.TabIndex = 7;
            this.labelactiveadmin.Text = "Aktif Hesap: Unkown";
            // 
            // textBoxsavenewadmin
            // 
            this.textBoxsavenewadmin.Location = new System.Drawing.Point(946, 15);
            this.textBoxsavenewadmin.Name = "textBoxsavenewadmin";
            this.textBoxsavenewadmin.ReadOnly = true;
            this.textBoxsavenewadmin.Size = new System.Drawing.Size(212, 20);
            this.textBoxsavenewadmin.TabIndex = 8;
            // 
            // textBoxda
            // 
            this.textBoxda.Location = new System.Drawing.Point(865, 41);
            this.textBoxda.Multiline = true;
            this.textBoxda.Name = "textBoxda";
            this.textBoxda.ReadOnly = true;
            this.textBoxda.Size = new System.Drawing.Size(293, 314);
            this.textBoxda.TabIndex = 9;
            // 
            // buttonexit
            // 
            this.buttonexit.Location = new System.Drawing.Point(378, 9);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(75, 23);
            this.buttonexit.TabIndex = 10;
            this.buttonexit.Text = "Çıkış";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // buttonmainmenu
            // 
            this.buttonmainmenu.Location = new System.Drawing.Point(459, 9);
            this.buttonmainmenu.Name = "buttonmainmenu";
            this.buttonmainmenu.Size = new System.Drawing.Size(75, 23);
            this.buttonmainmenu.TabIndex = 11;
            this.buttonmainmenu.Text = "Ana Menü";
            this.buttonmainmenu.UseVisualStyleBackColor = true;
            this.buttonmainmenu.Click += new System.EventHandler(this.buttonmainmenu_Click);
            // 
            // EditAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 282);
            this.ControlBox = false;
            this.Controls.Add(this.buttonmainmenu);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.textBoxda);
            this.Controls.Add(this.textBoxsavenewadmin);
            this.Controls.Add(this.labelactiveadmin);
            this.Controls.Add(this.textBoxacceslevel);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(562, 321);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(562, 321);
            this.Name = "EditAdmins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetkilileri Düzenle";
            this.Load += new System.EventHandler(this.EditAdmins_Load);
            this.tabControl1.ResumeLayout(false);
            this.addnewadmin.ResumeLayout(false);
            this.addnewadmin.PerformLayout();
            this.removeadmin.ResumeLayout(false);
            this.removeadmin.PerformLayout();
            this.changeacceslevel.ResumeLayout(false);
            this.changeacceslevel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxacceslevel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addnewadmin;
        private System.Windows.Forms.ComboBox comboBoxacceslevel;
        private System.Windows.Forms.Label labelacceslevel;
        private System.Windows.Forms.Button buttonaddadmin;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.TabPage removeadmin;
        private System.Windows.Forms.TextBox textBoxpasswordda;
        private System.Windows.Forms.Label labelenterpasswordda;
        private System.Windows.Forms.ComboBox comboBoxselectadminda;
        private System.Windows.Forms.Button buttondeleteadmin;
        private System.Windows.Forms.Label labelselectaadmin;
        private System.Windows.Forms.TabPage changeacceslevel;
        private System.Windows.Forms.Label labelactiveadmin;
        private System.Windows.Forms.TextBox textBoxadsurname;
        private System.Windows.Forms.TextBox textBoxadname;
        private System.Windows.Forms.Label labeladsurname;
        private System.Windows.Forms.Label labeladname;
        private System.Windows.Forms.Label labeljobtitle;
        private System.Windows.Forms.TextBox textBoxjobtitle;
        private System.Windows.Forms.TextBox textBoxsavenewadmin;
        private System.Windows.Forms.TextBox textBoxda;
        private System.Windows.Forms.TextBox textBoxcapassword;
        private System.Windows.Forms.Label labelcaenterpassword;
        private System.Windows.Forms.ComboBox comboBoxcaselectaadmin;
        private System.Windows.Forms.Button buttonchangeacceslevel;
        private System.Windows.Forms.Label labelcaselectaadmin;
        private System.Windows.Forms.ComboBox comboBoxca;
        private System.Windows.Forms.Label labelcaacceslevel;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button buttonmainmenu;
    }
}
