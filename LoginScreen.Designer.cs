
namespace thenextusgallerysystemnew
{
    partial class LoginScreen
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelloginpassword = new System.Windows.Forms.Label();
            this.labelloginusername = new System.Windows.Forms.Label();
            this.textBoxloginpassword = new System.Windows.Forms.TextBox();
            this.textBoxloginusername = new System.Windows.Forms.TextBox();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.textBoxinfos = new System.Windows.Forms.TextBox();
            this.buttonexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelloginpassword
            // 
            this.labelloginpassword.AutoSize = true;
            this.labelloginpassword.Location = new System.Drawing.Point(13, 57);
            this.labelloginpassword.Name = "labelloginpassword";
            this.labelloginpassword.Size = new System.Drawing.Size(31, 13);
            this.labelloginpassword.TabIndex = 4;
            this.labelloginpassword.Text = "Şifre:";
            // 
            // labelloginusername
            // 
            this.labelloginusername.AutoSize = true;
            this.labelloginusername.Location = new System.Drawing.Point(13, 23);
            this.labelloginusername.Name = "labelloginusername";
            this.labelloginusername.Size = new System.Drawing.Size(67, 13);
            this.labelloginusername.TabIndex = 3;
            this.labelloginusername.Text = "Kullanıcı Adı:";
            // 
            // textBoxloginpassword
            // 
            this.textBoxloginpassword.Location = new System.Drawing.Point(90, 50);
            this.textBoxloginpassword.MaxLength = 8;
            this.textBoxloginpassword.Name = "textBoxloginpassword";
            this.textBoxloginpassword.PasswordChar = '*';
            this.textBoxloginpassword.Size = new System.Drawing.Size(142, 20);
            this.textBoxloginpassword.TabIndex = 2;
            this.textBoxloginpassword.Text = "$the0732";
            // 
            // textBoxloginusername
            // 
            this.textBoxloginusername.Location = new System.Drawing.Point(90, 16);
            this.textBoxloginusername.MaxLength = 15;
            this.textBoxloginusername.Name = "textBoxloginusername";
            this.textBoxloginusername.Size = new System.Drawing.Size(142, 20);
            this.textBoxloginusername.TabIndex = 1;
            this.textBoxloginusername.Text = "thenextus";
            // 
            // buttonlogin
            // 
            this.buttonlogin.Location = new System.Drawing.Point(123, 78);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(75, 23);
            this.buttonlogin.TabIndex = 0;
            this.buttonlogin.Text = "Giriş Yap";
            this.buttonlogin.UseVisualStyleBackColor = true;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // textBoxinfos
            // 
            this.textBoxinfos.Location = new System.Drawing.Point(336, 23);
            this.textBoxinfos.Multiline = true;
            this.textBoxinfos.Name = "textBoxinfos";
            this.textBoxinfos.ReadOnly = true;
            this.textBoxinfos.Size = new System.Drawing.Size(119, 100);
            this.textBoxinfos.TabIndex = 1;
            this.textBoxinfos.Visible = false;
            // 
            // buttonexit
            // 
            this.buttonexit.Location = new System.Drawing.Point(5, 109);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(68, 24);
            this.buttonexit.TabIndex = 2;
            this.buttonexit.Text = "Çıkış";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 138);
            this.ControlBox = false;
            this.Controls.Add(this.labelloginpassword);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.labelloginusername);
            this.Controls.Add(this.textBoxloginpassword);
            this.Controls.Add(this.textBoxinfos);
            this.Controls.Add(this.textBoxloginusername);
            this.Controls.Add(this.buttonlogin);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(265, 177);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(265, 177);
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "thenextus Gallery Giriş Yap";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelloginpassword;
        private System.Windows.Forms.Label labelloginusername;
        private System.Windows.Forms.TextBox textBoxloginpassword;
        private System.Windows.Forms.TextBox textBoxloginusername;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.TextBox textBoxinfos;
        private System.Windows.Forms.Button buttonexit;
    }
}

