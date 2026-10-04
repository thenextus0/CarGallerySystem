
namespace thenextusgallerysystemnew
{
    partial class Reports
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
            this.buttonlastmonth = new System.Windows.Forms.Button();
            this.buttonall = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelmostpopularcarbrand = new System.Windows.Forms.Label();
            this.labelmostprofitablecarbrand = new System.Windows.Forms.Label();
            this.labeltopsellingemployee = new System.Windows.Forms.Label();
            this.labelmostprofitableemployee = new System.Windows.Forms.Label();
            this.labelmostprofitablecarmodel = new System.Windows.Forms.Label();
            this.labelmostpopularcarmodel = new System.Windows.Forms.Label();
            this.textBoxreport = new System.Windows.Forms.TextBox();
            this.textBoxreportdetails = new System.Windows.Forms.TextBox();
            this.textBoxadmininfo = new System.Windows.Forms.TextBox();
            this.textBoxinfos = new System.Windows.Forms.TextBox();
            this.buttonlastyear = new System.Windows.Forms.Button();
            this.buttonlastweek = new System.Windows.Forms.Button();
            this.buttontoday = new System.Windows.Forms.Button();
            this.buttonlastwoday = new System.Windows.Forms.Button();
            this.labelrange = new System.Windows.Forms.Label();
            this.buttonrangeok = new System.Windows.Forms.Button();
            this.labeltarih = new System.Windows.Forms.Label();
            this.textBoxrange = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttontarihok = new System.Windows.Forms.Button();
            this.labelfitre = new System.Windows.Forms.Label();
            this.groupBoxfilter = new System.Windows.Forms.GroupBox();
            this.buttontarihok2 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.labeltarih2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labeltopmenu = new System.Windows.Forms.Label();
            this.buttonexit = new System.Windows.Forms.Button();
            this.buttonmainmenu = new System.Windows.Forms.Button();
            this.labelprofit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxfilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonlastmonth
            // 
            this.buttonlastmonth.Location = new System.Drawing.Point(28, 53);
            this.buttonlastmonth.Name = "buttonlastmonth";
            this.buttonlastmonth.Size = new System.Drawing.Size(75, 23);
            this.buttonlastmonth.TabIndex = 0;
            this.buttonlastmonth.Text = "Son 30 Gün";
            this.buttonlastmonth.UseVisualStyleBackColor = true;
            this.buttonlastmonth.Click += new System.EventHandler(this.buttonlastmonth_Click);
            // 
            // buttonall
            // 
            this.buttonall.Location = new System.Drawing.Point(28, 24);
            this.buttonall.Name = "buttonall";
            this.buttonall.Size = new System.Drawing.Size(75, 23);
            this.buttonall.TabIndex = 1;
            this.buttonall.Text = "Tümü";
            this.buttonall.UseVisualStyleBackColor = true;
            this.buttonall.Click += new System.EventHandler(this.buttonall_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 11);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(653, 426);
            this.dataGridView1.TabIndex = 2;
            // 
            // labelmostpopularcarbrand
            // 
            this.labelmostpopularcarbrand.AutoSize = true;
            this.labelmostpopularcarbrand.Location = new System.Drawing.Point(14, 39);
            this.labelmostpopularcarbrand.Name = "labelmostpopularcarbrand";
            this.labelmostpopularcarbrand.Size = new System.Drawing.Size(183, 13);
            this.labelmostpopularcarbrand.TabIndex = 3;
            this.labelmostpopularcarbrand.Text = "En çok satılan araç markası: Unkown";
            // 
            // labelmostprofitablecarbrand
            // 
            this.labelmostprofitablecarbrand.AutoSize = true;
            this.labelmostprofitablecarbrand.Location = new System.Drawing.Point(14, 99);
            this.labelmostprofitablecarbrand.Name = "labelmostprofitablecarbrand";
            this.labelmostprofitablecarbrand.Size = new System.Drawing.Size(199, 13);
            this.labelmostprofitablecarbrand.TabIndex = 4;
            this.labelmostprofitablecarbrand.Text = "En çok kar edilen araç markası: Unkown";
            // 
            // labeltopsellingemployee
            // 
            this.labeltopsellingemployee.AutoSize = true;
            this.labeltopsellingemployee.Location = new System.Drawing.Point(14, 162);
            this.labeltopsellingemployee.Name = "labeltopsellingemployee";
            this.labeltopsellingemployee.Size = new System.Drawing.Size(180, 13);
            this.labeltopsellingemployee.TabIndex = 5;
            this.labeltopsellingemployee.Text = "En çok satış yapan eleman: Unkown";
            // 
            // labelmostprofitableemployee
            // 
            this.labelmostprofitableemployee.AutoSize = true;
            this.labelmostprofitableemployee.Location = new System.Drawing.Point(14, 194);
            this.labelmostprofitableemployee.Name = "labelmostprofitableemployee";
            this.labelmostprofitableemployee.Size = new System.Drawing.Size(182, 13);
            this.labelmostprofitableemployee.TabIndex = 6;
            this.labelmostprofitableemployee.Text = "En çok kar yaptıran eleman: Unkown";
            // 
            // labelmostprofitablecarmodel
            // 
            this.labelmostprofitablecarmodel.AutoSize = true;
            this.labelmostprofitablecarmodel.Location = new System.Drawing.Point(14, 130);
            this.labelmostprofitablecarmodel.Name = "labelmostprofitablecarmodel";
            this.labelmostprofitablecarmodel.Size = new System.Drawing.Size(193, 13);
            this.labelmostprofitablecarmodel.TabIndex = 7;
            this.labelmostprofitablecarmodel.Text = "En çok kar edilen araç modeli: Unkown";
            // 
            // labelmostpopularcarmodel
            // 
            this.labelmostpopularcarmodel.AutoSize = true;
            this.labelmostpopularcarmodel.Location = new System.Drawing.Point(14, 68);
            this.labelmostpopularcarmodel.Name = "labelmostpopularcarmodel";
            this.labelmostpopularcarmodel.Size = new System.Drawing.Size(177, 13);
            this.labelmostpopularcarmodel.TabIndex = 8;
            this.labelmostpopularcarmodel.Text = "En çok satılan araç modeli: Unkown";
            // 
            // textBoxreport
            // 
            this.textBoxreport.Location = new System.Drawing.Point(1353, 77);
            this.textBoxreport.Multiline = true;
            this.textBoxreport.Name = "textBoxreport";
            this.textBoxreport.Size = new System.Drawing.Size(233, 257);
            this.textBoxreport.TabIndex = 9;
            // 
            // textBoxreportdetails
            // 
            this.textBoxreportdetails.Location = new System.Drawing.Point(1379, 77);
            this.textBoxreportdetails.Multiline = true;
            this.textBoxreportdetails.Name = "textBoxreportdetails";
            this.textBoxreportdetails.Size = new System.Drawing.Size(233, 257);
            this.textBoxreportdetails.TabIndex = 10;
            // 
            // textBoxadmininfo
            // 
            this.textBoxadmininfo.Location = new System.Drawing.Point(1408, 77);
            this.textBoxadmininfo.Multiline = true;
            this.textBoxadmininfo.Name = "textBoxadmininfo";
            this.textBoxadmininfo.Size = new System.Drawing.Size(233, 257);
            this.textBoxadmininfo.TabIndex = 12;
            // 
            // textBoxinfos
            // 
            this.textBoxinfos.Location = new System.Drawing.Point(1441, 77);
            this.textBoxinfos.Multiline = true;
            this.textBoxinfos.Name = "textBoxinfos";
            this.textBoxinfos.Size = new System.Drawing.Size(233, 257);
            this.textBoxinfos.TabIndex = 13;
            // 
            // buttonlastyear
            // 
            this.buttonlastyear.Location = new System.Drawing.Point(109, 24);
            this.buttonlastyear.Name = "buttonlastyear";
            this.buttonlastyear.Size = new System.Drawing.Size(75, 23);
            this.buttonlastyear.TabIndex = 14;
            this.buttonlastyear.Text = "Bütün Yıl";
            this.buttonlastyear.UseVisualStyleBackColor = true;
            this.buttonlastyear.Click += new System.EventHandler(this.buttonlastyear_Click);
            // 
            // buttonlastweek
            // 
            this.buttonlastweek.Location = new System.Drawing.Point(109, 53);
            this.buttonlastweek.Name = "buttonlastweek";
            this.buttonlastweek.Size = new System.Drawing.Size(75, 23);
            this.buttonlastweek.TabIndex = 15;
            this.buttonlastweek.Text = "Son Hafta";
            this.buttonlastweek.UseVisualStyleBackColor = true;
            this.buttonlastweek.Click += new System.EventHandler(this.buttonlastweek_Click);
            // 
            // buttontoday
            // 
            this.buttontoday.Location = new System.Drawing.Point(109, 82);
            this.buttontoday.Name = "buttontoday";
            this.buttontoday.Size = new System.Drawing.Size(75, 23);
            this.buttontoday.TabIndex = 16;
            this.buttontoday.Text = "Bugün";
            this.buttontoday.UseVisualStyleBackColor = true;
            this.buttontoday.Click += new System.EventHandler(this.buttontoday_Click);
            // 
            // buttonlastwoday
            // 
            this.buttonlastwoday.Location = new System.Drawing.Point(28, 82);
            this.buttonlastwoday.Name = "buttonlastwoday";
            this.buttonlastwoday.Size = new System.Drawing.Size(75, 23);
            this.buttonlastwoday.TabIndex = 17;
            this.buttonlastwoday.Text = "Son 2 Gün";
            this.buttonlastwoday.UseVisualStyleBackColor = true;
            this.buttonlastwoday.Click += new System.EventHandler(this.buttonyesterday_Click);
            // 
            // labelrange
            // 
            this.labelrange.AutoSize = true;
            this.labelrange.Location = new System.Drawing.Point(22, 123);
            this.labelrange.Name = "labelrange";
            this.labelrange.Size = new System.Drawing.Size(163, 13);
            this.labelrange.TabIndex = 19;
            this.labelrange.Text = "Belirli bir gün sayısına göre filtrele:";
            // 
            // buttonrangeok
            // 
            this.buttonrangeok.Location = new System.Drawing.Point(173, 144);
            this.buttonrangeok.Name = "buttonrangeok";
            this.buttonrangeok.Size = new System.Drawing.Size(32, 23);
            this.buttonrangeok.TabIndex = 20;
            this.buttonrangeok.Text = "Ok";
            this.buttonrangeok.UseVisualStyleBackColor = true;
            this.buttonrangeok.Click += new System.EventHandler(this.buttonrangeok_Click);
            // 
            // labeltarih
            // 
            this.labeltarih.AutoSize = true;
            this.labeltarih.Location = new System.Drawing.Point(23, 184);
            this.labeltarih.Name = "labeltarih";
            this.labeltarih.Size = new System.Drawing.Size(155, 13);
            this.labeltarih.TabIndex = 21;
            this.labeltarih.Text = "Belirli bir tarihten bugüne filtrele:";
            // 
            // textBoxrange
            // 
            this.textBoxrange.Location = new System.Drawing.Point(11, 146);
            this.textBoxrange.Name = "textBoxrange";
            this.textBoxrange.Size = new System.Drawing.Size(156, 20);
            this.textBoxrange.TabIndex = 18;
            this.textBoxrange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 214);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // buttontarihok
            // 
            this.buttontarihok.Location = new System.Drawing.Point(172, 211);
            this.buttontarihok.Name = "buttontarihok";
            this.buttontarihok.Size = new System.Drawing.Size(32, 23);
            this.buttontarihok.TabIndex = 23;
            this.buttontarihok.Text = "Ok";
            this.buttontarihok.UseVisualStyleBackColor = true;
            this.buttontarihok.Click += new System.EventHandler(this.buttontarihok_Click);
            // 
            // labelfitre
            // 
            this.labelfitre.AutoSize = true;
            this.labelfitre.Location = new System.Drawing.Point(69, 2);
            this.labelfitre.Name = "labelfitre";
            this.labelfitre.Size = new System.Drawing.Size(70, 13);
            this.labelfitre.TabIndex = 24;
            this.labelfitre.Text = "Filtre Menüsü";
            // 
            // groupBoxfilter
            // 
            this.groupBoxfilter.Controls.Add(this.buttontarihok2);
            this.groupBoxfilter.Controls.Add(this.dateTimePicker2);
            this.groupBoxfilter.Controls.Add(this.labeltarih2);
            this.groupBoxfilter.Controls.Add(this.labelfitre);
            this.groupBoxfilter.Controls.Add(this.buttontarihok);
            this.groupBoxfilter.Controls.Add(this.dateTimePicker1);
            this.groupBoxfilter.Controls.Add(this.labeltarih);
            this.groupBoxfilter.Controls.Add(this.buttonrangeok);
            this.groupBoxfilter.Controls.Add(this.labelrange);
            this.groupBoxfilter.Controls.Add(this.textBoxrange);
            this.groupBoxfilter.Controls.Add(this.buttonlastwoday);
            this.groupBoxfilter.Controls.Add(this.buttontoday);
            this.groupBoxfilter.Controls.Add(this.buttonlastweek);
            this.groupBoxfilter.Controls.Add(this.buttonlastyear);
            this.groupBoxfilter.Controls.Add(this.buttonall);
            this.groupBoxfilter.Controls.Add(this.buttonlastmonth);
            this.groupBoxfilter.Location = new System.Drawing.Point(686, 11);
            this.groupBoxfilter.Name = "groupBoxfilter";
            this.groupBoxfilter.Size = new System.Drawing.Size(215, 323);
            this.groupBoxfilter.TabIndex = 25;
            this.groupBoxfilter.TabStop = false;
            // 
            // buttontarihok2
            // 
            this.buttontarihok2.Location = new System.Drawing.Point(172, 279);
            this.buttontarihok2.Name = "buttontarihok2";
            this.buttontarihok2.Size = new System.Drawing.Size(32, 23);
            this.buttontarihok2.TabIndex = 27;
            this.buttontarihok2.Text = "Ok";
            this.buttontarihok2.UseVisualStyleBackColor = true;
            this.buttontarihok2.Click += new System.EventHandler(this.buttontarihok2_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(14, 282);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(152, 20);
            this.dateTimePicker2.TabIndex = 26;
            // 
            // labeltarih2
            // 
            this.labeltarih2.AutoSize = true;
            this.labeltarih2.Location = new System.Drawing.Point(31, 253);
            this.labeltarih2.Name = "labeltarih2";
            this.labeltarih2.Size = new System.Drawing.Size(129, 13);
            this.labeltarih2.TabIndex = 25;
            this.labeltarih2.Text = "Belirli bir güne göre filtrele:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelprofit);
            this.groupBox1.Controls.Add(this.labeltopmenu);
            this.groupBox1.Controls.Add(this.labelmostpopularcarmodel);
            this.groupBox1.Controls.Add(this.labelmostprofitablecarmodel);
            this.groupBox1.Controls.Add(this.labelmostprofitableemployee);
            this.groupBox1.Controls.Add(this.labeltopsellingemployee);
            this.groupBox1.Controls.Add(this.labelmostprofitablecarbrand);
            this.groupBox1.Controls.Add(this.labelmostpopularcarbrand);
            this.groupBox1.Location = new System.Drawing.Point(921, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 264);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // labeltopmenu
            // 
            this.labeltopmenu.AutoSize = true;
            this.labeltopmenu.Location = new System.Drawing.Point(112, 0);
            this.labeltopmenu.Name = "labeltopmenu";
            this.labeltopmenu.Size = new System.Drawing.Size(67, 13);
            this.labeltopmenu.TabIndex = 28;
            this.labeltopmenu.Text = "Genel Rapor";
            // 
            // buttonexit
            // 
            this.buttonexit.Location = new System.Drawing.Point(697, 414);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(75, 23);
            this.buttonexit.TabIndex = 27;
            this.buttonexit.Text = "Çıkış";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // buttonmainmenu
            // 
            this.buttonmainmenu.Location = new System.Drawing.Point(778, 414);
            this.buttonmainmenu.Name = "buttonmainmenu";
            this.buttonmainmenu.Size = new System.Drawing.Size(75, 23);
            this.buttonmainmenu.TabIndex = 28;
            this.buttonmainmenu.Text = "Ana Menü";
            this.buttonmainmenu.UseVisualStyleBackColor = true;
            this.buttonmainmenu.Click += new System.EventHandler(this.buttonmainmenu_Click);
            // 
            // labelprofit
            // 
            this.labelprofit.AutoSize = true;
            this.labelprofit.Location = new System.Drawing.Point(14, 226);
            this.labelprofit.Name = "labelprofit";
            this.labelprofit.Size = new System.Drawing.Size(187, 13);
            this.labelprofit.TabIndex = 29;
            this.labelprofit.Text = "Toplamda yapılan kar miktarı: Unkown";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 449);
            this.ControlBox = false;
            this.Controls.Add(this.buttonmainmenu);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxfilter);
            this.Controls.Add(this.textBoxinfos);
            this.Controls.Add(this.textBoxadmininfo);
            this.Controls.Add(this.textBoxreportdetails);
            this.Controls.Add(this.textBoxreport);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1254, 488);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1254, 488);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapor Sistemi";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxfilter.ResumeLayout(false);
            this.groupBoxfilter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonlastmonth;
        private System.Windows.Forms.Button buttonall;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelmostpopularcarbrand;
        private System.Windows.Forms.Label labelmostprofitablecarbrand;
        private System.Windows.Forms.Label labeltopsellingemployee;
        private System.Windows.Forms.Label labelmostprofitableemployee;
        private System.Windows.Forms.Label labelmostprofitablecarmodel;
        private System.Windows.Forms.Label labelmostpopularcarmodel;
        private System.Windows.Forms.TextBox textBoxreport;
        private System.Windows.Forms.TextBox textBoxreportdetails;
        private System.Windows.Forms.TextBox textBoxadmininfo;
        private System.Windows.Forms.TextBox textBoxinfos;
        private System.Windows.Forms.Button buttonlastyear;
        private System.Windows.Forms.Button buttonlastweek;
        private System.Windows.Forms.Button buttontoday;
        private System.Windows.Forms.Button buttonlastwoday;
        private System.Windows.Forms.Label labelrange;
        private System.Windows.Forms.Button buttonrangeok;
        private System.Windows.Forms.Label labeltarih;
        private System.Windows.Forms.TextBox textBoxrange;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttontarihok;
        private System.Windows.Forms.Label labelfitre;
        private System.Windows.Forms.GroupBox groupBoxfilter;
        private System.Windows.Forms.Label labeltarih2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button buttontarihok2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labeltopmenu;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button buttonmainmenu;
        private System.Windows.Forms.Label labelprofit;
    }
}
