using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thenextusgallerysystemnew
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        public string[] activeadmin = new string[7];
        string[,] reports;
        string[,] dreports;
        string[,] infos;
        string[,] admininfo;
        DataTable dt1;

        void rmatriseaktar()
        {
            if (!(textBoxinfos.Lines.Length <= 0)) //çökmeyi engellemek için önlem aldık.
            {
                string[] iparca = textBoxreport.Lines[0].Split(';');
                reports = new string[textBoxreport.Lines.Length, iparca.Length]; //matrisi boyutlandırdık.

                for (int i = 0; i < reports.GetLength(0); i++)
                {
                    string[] parca = textBoxreport.Lines[i].Split(';');
                    for (int j = 0; j < reports.GetLength(1); j++) reports[i, j] = parca[j];
                } //verileri matrise aktardık.
            }
        } //reports

        void dmatriseaktar()
        {
            if (!(textBoxinfos.Lines.Length <= 0))
            {
                string[] iparca = textBoxreportdetails.Lines[0].Split(';');
                dreports = new string[textBoxreportdetails.Lines.Length, iparca.Length]; //matrisi boyutlandırdık.

                for (int i = 0; i < dreports.GetLength(0); i++)
                {
                    string[] parca = textBoxreportdetails.Lines[i].Split(';');
                    for (int j = 0; j < dreports.GetLength(1); j++) dreports[i, j] = parca[j];
                } //verileri matrise aktardık.
            }
        } //reportsdetails

        void matriseaktar()
        {
            if (!(textBoxinfos.Lines.Length <= 0))
            {
                string[] iparca = textBoxinfos.Lines[0].Split(';');
                infos = new string[textBoxinfos.Lines.Length, iparca.Length]; //matrisi boyutlandırdık.

                for (int i = 0; i < infos.GetLength(0); i++)
                {
                    string[] parca = textBoxinfos.Lines[i].Split(';');
                    for (int j = 0; j < infos.GetLength(1); j++) infos[i, j] = parca[j];
                } //verileri matrise aktardık.
            }
        } //reportsdetailsdetails

        void admininfoaktar()
        {
            string[] iparca = textBoxadmininfo.Lines[0].Split(';');
            admininfo = new string[textBoxadmininfo.Lines.Length, iparca.Length]; //matrisi boyutlandırdık.

            for (int i = 0; i < admininfo.GetLength(0); i++)
            {
                string[] parca = textBoxadmininfo.Lines[i].Split(';');
                for (int j = 0; j < admininfo.GetLength(1); j++) admininfo[i, j] = parca[j];
            } //verileri matrise aktardık.
        } //admininfo

        void myaz()
        {
            textBoxinfos.Text = File.ReadAllText(Application.StartupPath + @"\..\..\Reports\reportsdetailsdetails.csv");
            matriseaktar();

            textBoxreport.Text = File.ReadAllText(Application.StartupPath + @"\..\..\Reports\dailyreport.csv");
            rmatriseaktar();

            textBoxreportdetails.Text = File.ReadAllText(Application.StartupPath + @"\..\..\Reports\dailyreportdetails.csv");
            dmatriseaktar();

            //textBoxadmininfo.Text = File.ReadAllText(Application.StartupPath + @"\..\..\Logininfos\admins.csv");
            //admininfoaktar();
        } //tüm satış bilgilerini tekrar textbox'a yazdırdık, daha sonra tekrar matrise attık. (en çok satış yapan eleman bilgilerini vs. gün sınırına göre bulmak için yaptık.) (böylece datagridview'den silinince matristende sildik.)

        int dataaktarelse(int i) //dataaktar, tarihdataaktar, gundataakatar void'lerinin ortak else kısmı.
        {
            if (!(textBoxinfos.Lines.Length <= 0)) //program çökmesin diye önlem, bugün'e basılınca hiç satış yoksa organised'e atama yapmaya çalışıp çözüyodu.
            {
                dt1.Rows.Clear();
                string[] organised = textBoxinfos.Lines; //yapıldı. //textboxinfos aslında reportdetailsdetails
                string[] rorganised = textBoxreport.Lines;
                string[] dorganised = textBoxreportdetails.Lines;
                //string[] aorganised = textBoxadmininfo.Lines;

                for (int j = i; j < organised.Length - 1; j++)
                {
                    string gcc = organised[j];
                    organised[j] = organised[j + 1];
                    organised[j + 1] = gcc;

                    string rgcc = rorganised[j];
                    rorganised[j] = rorganised[j + 1];
                    rorganised[j + 1] = rgcc;

                    string dgcc = dorganised[j];
                    dorganised[j] = dorganised[j + 1];
                    dorganised[j + 1] = dgcc;

                    //string agcc = aorganised[j];
                    //aorganised[j] = aorganised[j + 1];
                    //aorganised[j + 1] = agcc;
                }
                Array.Resize(ref organised, organised.Length - 1);
                Array.Resize(ref rorganised, rorganised.Length - 1);
                Array.Resize(ref dorganised, dorganised.Length - 1);
                //Array.Resize(ref aorganised, aorganised.Length - 1);
                textBoxinfos.Lines = organised;
                textBoxreport.Lines = rorganised;
                textBoxreportdetails.Lines = dorganised;
                //textBoxadmininfo.Lines = aorganised;

                matriseaktar();
                rmatriseaktar();
                dmatriseaktar();
                //admininfoaktar();
                i = -1;
            }
            return i;
        }

        void dataaktar(int range)
        {
            myaz();
            if (dataGridView1.Rows.Count != 0) dt1.Rows.Clear();
            DateTime today = DateTime.Now;
            for (int i = 0; i < infos.GetLength(0); i++)
            {
                DateTime selldate = Convert.ToDateTime(infos[i, 6]);
                TimeSpan ts = today - selldate;
                if (Convert.ToInt32(ts.Days) <= range)
                {
                    DataRow dr1 = dt1.NewRow();
                    for (int j = 0; j < infos.GetLength(1) - 1; j++) dr1[j] = infos[i, j]; //tarih bilgisini yazdırmamak için -1 verdik. sen sonda tarih bilgisi var.
                    dt1.Rows.Add(dr1);
                }
                else i = dataaktarelse(i);
            }
            topinfo();
        } //filtreleme için void (belirli bir günden bugüne filtreler.)

        void tarihdataaktar(DateTime tarih)
        {
            myaz();
            if (dataGridView1.Rows.Count != 0) dt1.Rows.Clear();
            DateTime today = DateTime.Now;
            for (int i = 0; i < infos.GetLength(0); i++)
            {
                DateTime selldate = Convert.ToDateTime(infos[i, 6]);
                TimeSpan ts = today - selldate;
                TimeSpan st = today - tarih;
                if (Convert.ToInt32(ts.Days) <= Convert.ToInt32(st.Days))
                {
                    DataRow dr1 = dt1.NewRow();
                    for (int j = 0; j < infos.GetLength(1) - 1; j++) dr1[j] = infos[i, j];
                    dt1.Rows.Add(dr1);
                }
                else i = dataaktarelse(i);
            }
            topinfo();
        } //filtreleme için void (belirli bir tarihten bugüne filtreler.)

        void gundataakatar(DateTime tarih)
        {
            myaz();
            if (dataGridView1.Rows.Count != 0) dt1.Rows.Clear();
            DateTime today = DateTime.Now;
            for (int i = 0; i < infos.GetLength(0); i++)
            {
                DateTime selldate = Convert.ToDateTime(infos[i, 6]);
                if (selldate == tarih)
                {
                    DataRow dr1 = dt1.NewRow();
                    for (int j = 0; j < infos.GetLength(1) - 1; j++) dr1[j] = infos[i, j];
                    dt1.Rows.Add(dr1);
                }
                else i = dataaktarelse(i);
            }
            topinfo();
        } //filtreleme için void (belirli bir tarihteki satışları gösterir.)

        void topinfo()
        {
            if (dataGridView1.Rows.Count == 0)
            {
                labelmostpopularcarbrand.Text = "En çok satılan araç markası: Yok";
                labelmostpopularcarmodel.Text = "En çok satılan araç modeli: Yok";

                labelmostprofitablecarbrand.Text = "En çok kar edilen araç markası: Yok";
                labelmostprofitablecarmodel.Text = "En çok kar edilen araç modeli: Yok";

                labeltopsellingemployee.Text = "En çok satış yapan eleman: Yok";
                labelmostprofitableemployee.Text = "En çok kar yaptıran eleman: Yok";

                labelprofit.Text = "Toplamda yapılan kar miktarı: Yok";
            }
            else
            {
                //id'si, kaç kere satış yaptığı, kaç tl kar yaptırdığı
                string[,] topselling = new string[textBoxadmininfo.Lines.Length, 3];
                for (int i = 0; i < topselling.GetLength(0); i++)
                {
                    topselling[i, 0] = admininfo[i, 0]; //admin id'lerini aldık.
                    topselling[i, 1] = "0";
                    topselling[i, 2] = "0"; //kaç satış yaptığı ve kar ettirdiği parayı 0'a eşitledik.
                } //admin id'lerini alıp diğer bilgileri ayarladık.

                for (int i = 0; i < reports.GetLength(0); i++) //dreports ve reports'u filtrelemeye göre tekrar ataman gerek. /yapıldı\
                    for (int j = 0; j < topselling.GetLength(0); j++)
                        if (reports[i, 0] == topselling[j, 0])
                        {
                            topselling[j, 1] = (Convert.ToInt32(topselling[j, 1]) + Convert.ToInt32(dreports[i, 2])).ToString();
                            topselling[j, 2] = (Convert.ToInt32(topselling[j, 2]) + Convert.ToInt32(dreports[i, 5])).ToString();
                        }
                //id'ye göre satış miktarlarını girdik.
                int enba = Convert.ToInt32(topselling[0, 0]); //en çok satış yapan kişinin id'si
                int enb = Convert.ToInt32(topselling[0, 1]); //en çok ne kadar satış yapıldı.

                int enbpa = Convert.ToInt32(topselling[0, 0]); //en çok satıştan kar ettiren kişinin id'si
                int enbp = Convert.ToInt32(topselling[0, 2]); //en çok satıştan kar ettiren kişinin toplam kar'ı

                for (int i = 0; i < topselling.GetLength(0); i++)
                {
                    if (enb < Convert.ToInt32(topselling[i, 1]))
                    {
                        enb = Convert.ToInt32(topselling[i, 1]);
                        enba = Convert.ToInt32(topselling[i, 0]);
                    }
                    if (enbp < Convert.ToInt32(topselling[i, 2]))
                    {
                        enbp = Convert.ToInt32(topselling[i, 2]);
                        enbpa = Convert.ToInt32(topselling[i, 0]);
                    }
                } //en çok satış yapan kişi ve en çok kar eden kişiyi bulduk.
                string topsellemp = "none";
                string topsellingempm = "zero";
                for (int i = 0; i < admininfo.GetLength(0); i++)
                {
                    if (enba.ToString() == admininfo[i, 0]) topsellemp = admininfo[i, 3] + " " + admininfo[i, 4] + " (" + admininfo[i, 1] + ")";
                    if (enbpa.ToString() == admininfo[i, 0]) topsellingempm = admininfo[i, 3] + " " + admininfo[i, 4] + " (" + admininfo[i, 1] + ")";
                } //en çok satış yapan id'yi bulduk, bu id'den en çok satış yapan id'yi bulduk.

                labeltopsellingemployee.Text = "En çok satış yapan eleman: " + topsellemp;
                labelmostprofitableemployee.Text = "En çok kar yaptıran eleman: " + topsellingempm;

                //en çok satılan araç markası, modeli || en çok kar yapılan araç markası, modelini aşağıda buluyoruz.

                ArrayList carinfo = new ArrayList();

                for (int i = 0; i < infos.GetLength(0); i++)
                {
                    string gecici = infos[i, 0] + ";" + infos[i, 1];
                    if (!carinfo.Contains(gecici)) carinfo.Add(gecici);
                } //satılan araçların marka, model bilgilerini aldık. (aynı aracı 1 kere aldık.)

                string[,] topsellingcar = new string[carinfo.Count, 4]; //bilgileri aktarmak için matrisin boyutunu ayarladık.
                for (int i = 0; i < topsellingcar.GetLength(0); i++)
                {
                    string[] pcarinfo = carinfo[i].ToString().Split(';');
                    for (int j = 0; j < pcarinfo.Length; j++) topsellingcar[i, j] = pcarinfo[j];
                    topsellingcar[i, 2] = "0";
                    topsellingcar[i, 3] = "0"; //kaç tane satıldığı ve ne kadar kar edildiğini 0'a eşitledik.
                } //araç marka ve modeli matrise atadık.
                for (int i = 0; i < infos.GetLength(0); i++)
                    for (int j = 0; j < topsellingcar.GetLength(0); j++)
                        if (infos[i, 0] + ";" + infos[i, 1] == topsellingcar[j, 0] + ";" + topsellingcar[j, 1])
                        {
                            topsellingcar[j, 2] = (Convert.ToInt32(topsellingcar[j, 2]) + Convert.ToInt32(infos[i, 5])).ToString();
                            topsellingcar[j, 3] = (Convert.ToInt32(topsellingcar[j, 3]) + Convert.ToInt32(infos[i, 4])).ToString();
                        } // marka modeldeki aracın kaç kere ne kadar satıldığını bulduk.

                ArrayList encokmarka = new ArrayList();
                ArrayList encokmodel = new ArrayList();

                for (int i = 0; i < topsellingcar.GetLength(0); i++)
                {
                    string gecici = topsellingcar[i, 0]; //marka için.
                    string gecicim = topsellingcar[i, 0] + ";" + topsellingcar[i, 1]; //model için.
                    if (!encokmarka.Contains(gecici)) encokmarka.Add(gecici);
                    if (!encokmodel.Contains(gecicim)) encokmodel.Add(gecicim);

                } // aynı markada araç varsa onu teke indirdik. (en fazla satılan markayı bulmak için.) // aynı marka, modelde araç varsa onu teke indirdik. (en fazla satılan modeli bulmak için.)
                string[,] mostsellbrand = new string[encokmarka.Count, 3]; //marka için.
                string[,] mostsellmodel = new string[encokmodel.Count, 3]; //model için.

                for (int i = 0; i < mostsellbrand.GetLength(0); i++)
                {
                    mostsellbrand[i, 0] = encokmarka[i].ToString();
                    mostsellbrand[i, 1] = "0";
                    mostsellbrand[i, 2] = "0";
                } //en çok satılan markayı bulmak için matrise attık.

                for (int i = 0; i < mostsellmodel.GetLength(0); i++)
                {
                    mostsellmodel[i, 0] = encokmodel[i].ToString();
                    mostsellmodel[i, 1] = "0";
                    mostsellmodel[i, 2] = "0";
                } //en çok satılan markayı bulmak için matrise attık.

                for (int i = 0; i < topsellingcar.GetLength(0); i++)
                {
                    for (int j = 0; j < mostsellbrand.GetLength(0); j++)
                    {
                        if (topsellingcar[i, 0] == mostsellbrand[j, 0])
                        {
                            mostsellbrand[j, 1] = (Convert.ToInt32(mostsellbrand[j, 1]) + Convert.ToInt32(topsellingcar[i, 2])).ToString();
                            mostsellbrand[j, 2] = (Convert.ToInt32(mostsellbrand[j, 2]) + Convert.ToInt32(topsellingcar[i, 3])).ToString();
                        } //yeni matrise farklı model ama aynı marka olan araçların satılma miktarını ve kar miktarını aktardık.
                    }

                    for (int j = 0; j < mostsellmodel.GetLength(0); j++)
                    {
                        if (topsellingcar[i, 0] + ";" + topsellingcar[i, 1] == mostsellmodel[j, 0])
                        {
                            mostsellmodel[j, 1] = (Convert.ToInt32(mostsellmodel[j, 1]) + Convert.ToInt32(topsellingcar[i, 2])).ToString();
                            mostsellmodel[j, 2] = (Convert.ToInt32(mostsellmodel[j, 2]) + Convert.ToInt32(topsellingcar[i, 3])).ToString();
                        }
                    } //yeni matrise aynı model olan araçların satılma miktarını ve kar miktarını aktardık.
                }

                int encoksatilanmarkarow = 0; //en çok satılan markanın satır sayısı
                int encoksatilanmarkamiktari = Convert.ToInt32(mostsellbrand[0, 1]); //en çok satılan markanın satılma miktarı

                int encokmarkakarrow = 0; //en çok kar edilen aracın satır sayısı
                int encokmarkakar = Convert.ToInt32(mostsellbrand[0, 2]); //en çok kar edilen araçtan ne kadar kar edildi

                int encoksatilanmodelrow = 0; //en çok satılan araç modelinin satır sayısı
                int encoksatilanmodelmiktari = Convert.ToInt32(mostsellmodel[0, 1]); //en çok satılan araç modelinin satılma sayısı

                int encokmodelkarrow = 0; //en çok kar edilen modelin satır sayısı
                int encokmodelkar = Convert.ToInt32(mostsellmodel[0, 2]); //en çok kar edilen modelden ne kadar kar edildi

                int totalprofit = 0; //toplam yapılan karı bulmak için integer oluşturduk.

                for (int i = 0; i < mostsellbrand.GetLength(0); i++)
                {
                    if (encoksatilanmarkamiktari <= Convert.ToInt32(mostsellbrand[i, 1]))
                    {
                        encoksatilanmarkamiktari = Convert.ToInt32(mostsellbrand[i, 1]);
                        encoksatilanmarkarow = i;
                    } // en çok satılan araç markasını bulduk.
                    if (encokmarkakar <= Convert.ToInt32(mostsellbrand[i, 2]))
                    {
                        encokmarkakar = Convert.ToInt32(mostsellbrand[i, 2]);
                        encokmarkakarrow = i;
                    } // en çok kar edilen araç markasını bulduk.
                } //en çok satılan ve en çok kar edilen araç maraksını bulduk.

                for (int i = 0; i < mostsellmodel.GetLength(0); i++)
                {
                    if (encoksatilanmodelmiktari <= Convert.ToInt32(mostsellmodel[i, 1]))
                    {
                        encoksatilanmodelmiktari = Convert.ToInt32(mostsellmodel[i, 1]);
                        encoksatilanmodelrow = i;
                    } // en çok satılan araç markasını bulduk.
                    if (encokmodelkar <= Convert.ToInt32(mostsellmodel[i, 2]))
                    {
                        encokmodelkar = Convert.ToInt32(mostsellmodel[i, 2]);
                        encokmodelkarrow = i;
                    } // en çok kar edilen araç modelini bulduk.
                    totalprofit += Convert.ToInt32(mostsellmodel[i, 2]); // toplam yapılan karı hesaplamak için topluyoruz.
                } //en çok satılan ve en çok kar edilen araç modelini bulduk.

                labelmostpopularcarbrand.Text = "En çok satılan araç markası: " + mostsellbrand[encoksatilanmarkarow, 0]; //en çok satılan araç markası
                labelmostprofitablecarbrand.Text = "En çok kar edilen araç markası: " + mostsellbrand[encokmarkakarrow, 0]; //en çok kar yapan araç markası

                string[] parcala = mostsellmodel[encoksatilanmodelrow, 0].Split(';');
                string[] bparcala = mostsellmodel[encokmodelkarrow, 0].Split(';');
                labelmostpopularcarmodel.Text = "En çok satılan araç modeli: " + parcala[1]; //en çok satılan araç modeli
                labelmostprofitablecarmodel.Text = "En çok kar edilen araç modeli: " + bparcala[1]; //en çok kar edilen araç modeli
                                                                                                    //araç marka, araç model, kaç tane satıldığı, kaç tl kar yapıldığı  //topsellingcar matrisi
                labelprofit.Text = "Toplamda yapılan kar miktarı: " + totalprofit.ToString(); //elde edilen toplam karı ekrana yazdırdık.
            }

        } //filtrelemeye göre en çok kar ettiren araba modeli, markası, en çok kar ettiren eleman, en çok satış yapan araba modeli, markası, en çok kar ettiren eleman buluyoruz.

        private void Reports_Load(object sender, EventArgs e)
        {
            textBoxinfos.Text = File.ReadAllText(Application.StartupPath + @"\..\..\Reports\reportsdetailsdetails.csv"); //satılan aracın genel bilgilerini getirdik.
            textBoxreport.Text = File.ReadAllText(Application.StartupPath + @"\..\..\Reports\dailyreport.csv");
            textBoxreportdetails.Text = File.ReadAllText(Application.StartupPath + @"\..\..\Reports\dailyreportdetails.csv");
            textBoxadmininfo.Text = File.ReadAllText(Application.StartupPath + @"\..\..\Logininfos\admins.csv");

            dt1 = new DataTable();
            dt1.Columns.Add("Araç Markası");
            dt1.Columns.Add("Araç Modeli");
            dt1.Columns.Add("Araç Türü");
            dt1.Columns.Add("Kilometre");
            dt1.Columns.Add("Kar Miktarı");
            dt1.Columns.Add("Satış Miktarı");
            dataGridView1.DataSource = dt1;
            matriseaktar(); //reportsdetailsdetails
            rmatriseaktar(); //dailyreports
            dmatriseaktar(); //reportsdetails
            admininfoaktar(); //admin.cvs
            buttonall.PerformClick(); //tüm satılan araçların bilgisini yazdırdık.
        } //ilk başta yapılacak belirli işlemler.

        private void buttonall_Click(object sender, EventArgs e)
        {
            textBoxinfos.Text = File.ReadAllText(Application.StartupPath + @"\..\..\Reports\reportsdetailsdetails.csv"); //tüm bilgileri yazcağımız için tüm bilgileri yazdık.
            matriseaktar();
            if (dataGridView1.Rows.Count != 0) dt1.Rows.Clear();
            for (int i = 0; i < infos.GetLength(0); i++)
            {
                DataRow dr1 = dt1.NewRow();
                for (int j = 0; j < infos.GetLength(1) - 1; j++) dr1[j] = infos[i, j];
                dt1.Rows.Add(dr1);
            } //araç bilgilerini dataGridView'e attık.
            topinfo();
        } //satılan tüm araçları göster

        private void buttonlastmonth_Click(object sender, EventArgs e)
        {
            dataaktar(30);
        } //son ayda satılan araçalrı göster

        private void buttonlastyear_Click(object sender, EventArgs e)
        {
            dataaktar(365);
        } //son yılda satılan araçları göster

        private void buttonlastweek_Click(object sender, EventArgs e)
        {
            dataaktar(7);
        } //son haftada satılan araçları göster

        private void buttonyesterday_Click(object sender, EventArgs e)
        {
            dataaktar(1);
        } //dünden beri satılan araçları göster

        private void buttontoday_Click(object sender, EventArgs e)
        {
            dataaktar(0);
        } //bugün satılan araçları göster

        private void buttonrangeok_Click(object sender, EventArgs e)
        {
            if (textBoxrange.Text != "") dataaktar(Convert.ToInt32(textBoxrange.Text));
            else MessageBox.Show("Bu alanı boş bırakamazsınız.");

        } //belirli bir gün sayısına göre filtrele

        private void buttontarihok_Click(object sender, EventArgs e)
        {
            string[] tarihp = dateTimePicker1.Value.ToString().Split(' ');
            tarihdataaktar(Convert.ToDateTime(tarihp[0]));
        } //belirli bir tarihten bugüne filtrele

        private void buttontarihok2_Click(object sender, EventArgs e)
        {
            string[] tarihp = dateTimePicker2.Value.ToString().Split(' ');
            gundataakatar(Convert.ToDateTime(tarihp[0]));
        } //belirli bir tarihteki satışları göster

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        } //sadece sayı girilmesini ayarladık

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } //programı kapattık.

        private void buttonmainmenu_Click(object sender, EventArgs e)
        {
            MainScreen mainscreen = new MainScreen();
            mainscreen.activeadmin = activeadmin;
            mainscreen.Show();
            this.Close();
        } //ana menüye döndük.
    }
}
