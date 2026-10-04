
namespace thenextusgallerysystemnew
{
    partial class MainScreen
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
            this.buttonconfirm = new System.Windows.Forms.Button();
            this.buttonreports = new System.Windows.Forms.Button();
            this.buttonaddcar = new System.Windows.Forms.Button();
            this.labelactiveadmin = new System.Windows.Forms.Label();
            this.buttoneditadmins = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.buttonlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonconfirm
            // 
            this.buttonconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonconfirm.Location = new System.Drawing.Point(19, 44);
            this.buttonconfirm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonconfirm.Name = "buttonconfirm";
            this.buttonconfirm.Size = new System.Drawing.Size(97, 46);
            this.buttonconfirm.TabIndex = 0;
            this.buttonconfirm.Text = "Araç Satın Alımı Onayla";
            this.buttonconfirm.UseVisualStyleBackColor = true;
            this.buttonconfirm.Click += new System.EventHandler(this.buttonconfirm_Click);
            // 
            // buttonreports
            // 
            this.buttonreports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonreports.Location = new System.Drawing.Point(19, 97);
            this.buttonreports.Margin = new System.Windows.Forms.Padding(2);
            this.buttonreports.Name = "buttonreports";
            this.buttonreports.Size = new System.Drawing.Size(97, 45);
            this.buttonreports.TabIndex = 1;
            this.buttonreports.Text = "Raporlar";
            this.buttonreports.UseVisualStyleBackColor = true;
            this.buttonreports.Click += new System.EventHandler(this.buttonreports_Click);
            // 
            // buttonaddcar
            // 
            this.buttonaddcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonaddcar.Location = new System.Drawing.Point(123, 44);
            this.buttonaddcar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonaddcar.Name = "buttonaddcar";
            this.buttonaddcar.Size = new System.Drawing.Size(97, 45);
            this.buttonaddcar.TabIndex = 2;
            this.buttonaddcar.Text = "Stoğa Araç Ekle";
            this.buttonaddcar.UseVisualStyleBackColor = true;
            this.buttonaddcar.Click += new System.EventHandler(this.buttonaddcar_Click);
            // 
            // labelactiveadmin
            // 
            this.labelactiveadmin.AutoSize = true;
            this.labelactiveadmin.Location = new System.Drawing.Point(40, 9);
            this.labelactiveadmin.Name = "labelactiveadmin";
            this.labelactiveadmin.Size = new System.Drawing.Size(108, 13);
            this.labelactiveadmin.TabIndex = 3;
            this.labelactiveadmin.Text = "Aktif Hesap: Unkown";
            // 
            // buttoneditadmins
            // 
            this.buttoneditadmins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttoneditadmins.Location = new System.Drawing.Point(123, 97);
            this.buttoneditadmins.Name = "buttoneditadmins";
            this.buttoneditadmins.Size = new System.Drawing.Size(97, 45);
            this.buttoneditadmins.TabIndex = 4;
            this.buttoneditadmins.Text = "Yetkilileri Düzenle";
            this.buttoneditadmins.UseVisualStyleBackColor = true;
            this.buttoneditadmins.Click += new System.EventHandler(this.buttoneditadmins_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.Location = new System.Drawing.Point(12, 164);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(89, 23);
            this.buttonexit.TabIndex = 5;
            this.buttonexit.Text = "Çıkış";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // buttonlogout
            // 
            this.buttonlogout.Location = new System.Drawing.Point(138, 164);
            this.buttonlogout.Name = "buttonlogout";
            this.buttonlogout.Size = new System.Drawing.Size(89, 23);
            this.buttonlogout.TabIndex = 6;
            this.buttonlogout.Text = "Oturumu Kapat";
            this.buttonlogout.UseVisualStyleBackColor = true;
            this.buttonlogout.Click += new System.EventHandler(this.buttonlogout_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 189);
            this.ControlBox = false;
            this.Controls.Add(this.buttonlogout);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.buttoneditadmins);
            this.Controls.Add(this.labelactiveadmin);
            this.Controls.Add(this.buttonaddcar);
            this.Controls.Add(this.buttonreports);
            this.Controls.Add(this.buttonconfirm);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(255, 228);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(255, 228);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Menüsü";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonconfirm;
        private System.Windows.Forms.Button buttonreports;
        private System.Windows.Forms.Button buttonaddcar;
        private System.Windows.Forms.Label labelactiveadmin;
        private System.Windows.Forms.Button buttoneditadmins;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button buttonlogout;
    }
}
