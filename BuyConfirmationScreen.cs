using System;
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
    public partial class BuyConfirmationScreen : Form
    {
        public BuyConfirmationScreen()
        {
            InitializeComponent();
        }

        string[,] cars;
        public string[] activeadmin = new string[7];
        DataTable dt;

        int newid;

        //araç satılıyo, kaydediyoruz. sorun şu aracın girilen fiyatı, satış fiyatına eşit olmayabilir. satılırken 5000 indirim yapılmış olabilir.

        void verileriaktar()
        {
            if (dataGridView1.CurrentCell != null)//tıklanan hücre başlık mı diye kontrol ettik. başlık olunca null değer dönüyor ve program çöküyordu.
            {
                int selectedrow = dataGridView1.CurrentRow.Index;
                textBoxcarid.Text = cars[selectedrow, 0];
                textBoxcarbrand.Text = cars[selectedrow, 1];
                textBoxcarmodel.Text = cars[selectedrow, 2];
                textBoxcartype.Text = cars[selectedrow, 3];
                textBoxproductionyear.Text = cars[selectedrow, 4];
                textBoxcarcolor.Text = cars[selectedrow, 5];
                textBoxcarkm.Text = cars[selectedrow, 6];
                textBoxcarprice.Text = cars[selectedrow, 7];
                miktardegisti(selectedrow);
                pictureBox1.Image = Image.FromFile(@cars[selectedrow, 9]);
            }
        } //datagridview'de seçilen satıra göre verileri textbox'a aktardık.

        void matriseaktar()
        {
            string carscolumn = textBoxinfos.Lines[0];
            string[] carcolumnparca = carscolumn.Split(';');
            cars = new string[textBoxinfos.Lines.Length, carcolumnparca.Length]; //matrisin boyutunu ayarladık.

            for (int i = 0; i < textBoxinfos.Lines.Length; i++)
            {
                string satir = textBoxinfos.Lines[i];
                string[] parca = satir.Split(';');
                for (int j = 0; j < parca.Length; j++) cars[i, j] = parca[j]; //araç bilgilerini matrise attık.
            }
        } //araç bilgilerini textbox'Tan matrise aktardık.

        void savefiles()
        {
            File.WriteAllText(Application.StartupPath + @"\..\..\Storage Infos\Storage.csv", textBoxinfos.Text);//stok dosyasını kaydediyoruz.

            //reports'u kaydediyoruz.
            FileStream fs = new FileStream(Application.StartupPath + @"\..\..\Reports\dailyreport.csv", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < textBoxreports.Lines.Length; i++) if (textBoxreports.Lines[i] != "") sw.Write("\r\n" + textBoxreports.Lines[i]);
            textBoxreports.Clear();
            sw.Close();
            fs.Close(); //reports'u kaydettik.

            //reportsdetails'i kaydediyoruz.
            FileStream dfs = new FileStream(Application.StartupPath + @"\..\..\Reports\dailyreportdetails.csv", FileMode.Append, FileAccess.Write);
            StreamWriter dsw = new StreamWriter(dfs);
            for (int i = 0; i < textBoxdreports.Lines.Length; i++) if (textBoxdreports.Lines[i] != "") dsw.Write("\r\n" + textBoxdreports.Lines[i]);
            textBoxdreports.Clear();
            dsw.Close();
            dfs.Close(); //reporsdetails'i kaydettik.

            //reportsclient'i kaydediyoruz.
            FileStream cfs = new FileStream(Application.StartupPath + @"\..\..\Reports\reportclient.csv", FileMode.Append, FileAccess.Write);
            StreamWriter csw = new StreamWriter(cfs);
            for (int i = 0; i < textBoxreportsclient.Lines.Length; i++) if (textBoxreportsclient.Lines[i] != "") csw.Write("\r\n" + textBoxreportsclient.Lines[i]);
            textBoxreportsclient.Clear();
            csw.Close();
            cfs.Close(); //reportsclient'i kaydettik.

            
            FileStream ddfs = new FileStream(Application.StartupPath + @"\..\..\Reports\reportsdetailsdetails.csv", FileMode.Append, FileAccess.Write);
            StreamWriter ddsw = new StreamWriter(ddfs);
            for (int i = 0; i < textBoxddreports.Lines.Length; i++) if (textBoxddreports.Lines[i] != "") ddsw.Write("\r\n" + textBoxddreports.Lines[i]);
            textBoxddreports.Clear();
            ddsw.Close();
            ddfs.Close(); //deportdetailsdetails'i kaydettik.
        }

        void miktardegisti(int selectedrow)
        {
            comboBoxamountreceived.Items.Clear();
            for (int i = 1; i <= Convert.ToInt32(cars[selectedrow, 8]); i++) comboBoxamountreceived.Items.Add(i);
            comboBoxamountreceived.SelectedIndex = 0;
            dataGridView1.Rows[selectedrow].Cells[7].Value = cars[selectedrow, 8];//değişen stok miktarını datagridview'de değiştirdik.
        } //bir araç stoğu değiştiğinde combobox'u ve datagridview'i güncelledik. +

        void datagridvieweaktar()
        {
            for (int i = 0; i < cars.GetLength(0); i++)
            {
                DataRow dr = dt.NewRow();
                for (int j = 1; j < cars.GetLength(1) - 1; j++) dr[j - 1] = cars[i, j];
                dt.Rows.Add(dr);
            } //araç bilgilerini dataGridView'E attık. //ilk ve son 2 bilgiyi atmadık. (tüm araçları gösterdik.)
            dataGridView1.DataSource = dt;
            verileriaktar();
        } //verileri datagridview'e aktardığımız yer.

        void searchingridview(string searchvalue, string headline)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = headline + "Like '%" + searchvalue + "%'";
            dataGridView1.DataSource = dv;
            searchtextboxclear();
        } //datagridview'de belirli bir değere göre arama yaptık.

        void searchtextboxclear()
        {
            textBoxsearchcarbrand.Clear();
            textBoxsearchcarmodel.Clear();
            textBoxsearchcartype.Clear();
            textBoxsearchcarproductionyear.Clear();
            textBoxsearchcarcolor.Clear();
        } //datagridview'de arama yaptıktan sonra search için olan textbox'ları temizledik.

        private void BuyConfirmationScreen_Load(object sender, EventArgs e)
        {
            textBoxinfos.Text = File.ReadAllText(Application.StartupPath + @"\..\..\Storage Infos\Storage.csv");//stok bilgisini bir kere yazdırdık.
            dt = new DataTable(); //tablo şeklinde data alanı oluşturduk.
            dt.Columns.Add(new DataColumn("Araç Markası"));
            dt.Columns.Add(new DataColumn("Araç Modeli"));
            dt.Columns.Add(new DataColumn("Araç Türü"));
            dt.Columns.Add(new DataColumn("Üretim Yılı"));
            dt.Columns.Add(new DataColumn("Araç Rengi"));
            dt.Columns.Add(new DataColumn("Kilometre"));
            dt.Columns.Add(new DataColumn("Fiyat"));
            dt.Columns.Add(new DataColumn("Stok Miktarı"));//tablo şeklindeki data alanının sütunlarını ekledik.

            matriseaktar(); //verileri matrise aktardığımız yer.
            datagridvieweaktar();
        } //verileri alıp matrise attık, datagridview'e ekledik. +

        private void buttonbuycar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                if (textBoxcarsellprice.Text != "" && textBoxname.Text != "" && textBoxsurname.Text != "" && textBoxtcno.Text != "" && textBoxpaymentmethod.Text != "")
                {
                    if (10 < textBoxtcno.Text.Length)
                    {
                        int selectedrow = dataGridView1.CurrentRow.Index;
                        //reports'u ayarlıyoruz.
                        string[] parca = DateTime.Now.ToString().Split(' ');
                        textBoxreports.Text += activeadmin[0] + ";" + parca[0] + ";" + parca[1] + "\r\n";
                        //reports'a eklenecek bilgileri textbox'a aktardık.

                        //reportsdetails'i ayarlıyoruz.
                        if (newid == 0)//ilk araç satımı gerçekleşiyorsa en büyük id'yi dosyadan bulacak ve yeni id'yi ayarlıyacak.
                        {
                            textBoxdreports.Text = File.ReadAllText(Application.StartupPath + @"\..\..\Reports\dailyreportdetails.csv");
                            string[] details = new string[textBoxdreports.Lines.Length];
                            details = textBoxdreports.Lines;
                            textBoxdreports.Clear();
                            int enb = 0;
                            for (int i = 0; i < details.Length; i++)
                            {
                                string[] dparca = details[i].Split(';');
                                if (enb < Convert.ToInt32(dparca[0])) enb = Convert.ToInt32(dparca[0]);
                            }
                            newid = enb + 1;
                        }//satışa yeni id vermek için kullanılan en büyük id'yi bulduk ve 1 fazlasını yeni id olarak ayarladık.

                        string toplamkar = (Convert.ToInt32(comboBoxamountreceived.SelectedItem) * (Convert.ToInt32(textBoxcarsellprice.Text) - Convert.ToInt32(cars[selectedrow, 7]))).ToString();
                        textBoxdreports.Text += newid.ToString() + ";" + cars[selectedrow, 0] + ";" + comboBoxamountreceived.SelectedItem.ToString() + ";" + cars[selectedrow, 7] + ";" + textBoxcarsellprice.Text + ";" + toplamkar + "\r\n";
                        //reportsdetails'in textbox'unu ayarladık.
                        textBoxreportsclient.Text += newid.ToString() + ";" + textBoxname.Text + ";" + textBoxsurname.Text + ";" + textBoxtcno.Text  + "\r\n";
                        //reportsclient'in textbox'unu ayarladık.
                        newid++;
                        //reportsdetails'e eklenecek bilgileri textbox'a yazdık.

                        string[] parcax = DateTime.Now.ToString().Split(' ');
                        textBoxddreports.Text += textBoxcarbrand.Text + ";" + textBoxcarmodel.Text + ";" + textBoxcartype.Text + ";" + textBoxcarkm.Text + ";" + toplamkar + ";" + comboBoxamountreceived.SelectedItem.ToString() + ";" + parcax[0] + "\r\n";
                        //reporsdetailsdetails'i ayarladık

                        //stok bilgisini güncelliyoruz.
                        bool outofstock = false;
                        cars[selectedrow, 8] = (Convert.ToInt32(cars[selectedrow, 8]) - Convert.ToInt32(comboBoxamountreceived.SelectedItem)).ToString();
                        if (Convert.ToInt32(cars[selectedrow, 8]) == 0) outofstock = true; //stok bitmiş mi ona göre işlem yapacağız.

                        string[] organizedinfos = new string[textBoxinfos.Lines.Length];
                        organizedinfos = textBoxinfos.Lines;
                        textBoxinfos.Clear();//stok bilgisini güncellemek için textbox'u temizledik.

                        if (outofstock == true) // stok bittiyse textbox'tan ve datagridview'den sildik.
                        {
                            if (1 < dataGridView1.Rows.Count)
                            {
                                for (int i = selectedrow; i < organizedinfos.Length - 1; i++)//bilgileri textbox'a yazdıracağımız için bilgileri düzenliyoruz.
                                {
                                    string gcc = organizedinfos[i];
                                    organizedinfos[i] = organizedinfos[i + 1];
                                    organizedinfos[i + 1] = gcc;//seçilen satırdan başlıyarak seçili satırı bir sonraki satırla değiştirdik. for bittiğinde stoğu biten araç dizinin son elemanı olarak atanmış oldu.
                                }
                                Array.Resize(ref organizedinfos, organizedinfos.Length - 1);//diziyi yeniden resize'layarak son eleman olan stoğu biten aracı diziden sildik.
                                textBoxinfos.Lines = organizedinfos;//bilgileri textbox'a yazdırdık.
                                matriseaktar();//yeni düzenlediğimiz bilgileri matrise aktardık.
                            } //son araç satıldığında bilgileri matrise aktarmaya çalışmasın diye yaptık. böylece çökmeyi engelledik.

                            //eğer o aracın stoğu bittiyse o satırı datagridview'den silip başka bir satırı seçili hale getiricez.
                            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index); //seçili satırı datagridview'den sildik. (stok bittiği için.)
                            if (dataGridView1.Rows.Count != 0 && selectedrow < dataGridView1.Rows.Count) dataGridView1.Rows[selectedrow].Selected = true; //seçili satırdan bir önceki satırı seçtirdik.
                            else if (dataGridView1.Rows.Count != 0) dataGridView1.Rows[selectedrow - 1].Selected = true; //sonuncu seçiliylse bu çalışacak
                                                                                                                         //alternatif çözüm:
                                                                                                                         //dataGridView1.CurrentCell = dataGridView1.Rows[selectedrow - 1].Cells[0]; //seçili satırdan bir önceki satırı seçmesi için komut verdik.
                                                                                                                         //dataGridView1.Rows[selectedrow - 1].Selected = true; //seçili satırdan bir önceki satırı seçtirdik.
                        }
                        else
                        {
                            organizedinfos[selectedrow] = ""; //selectedrow'u temizledik çünkü o satırda zaten stoğu değiştirmeden önceki bilgiler yazılıydı.
                            for (int i = 0; i < cars.GetLength(1); i++) //stok azaltmak için gerekli işlemleri yaptık.
                            {
                                if (i != cars.GetLength(1) - 1) organizedinfos[selectedrow] += cars[selectedrow, i] + ";";
                                else organizedinfos[selectedrow] += cars[selectedrow, i];
                            }
                            textBoxinfos.Lines = organizedinfos;
                            miktardegisti(selectedrow);
                        }
                        //stok bilgisini textbox'ta güncelledik.
                    }
                    else MessageBox.Show("TC Kimlik No'nu eksiksiz giriniz.");
                }
                else MessageBox.Show("Lütfen gerekli tüm bilgileri doldurunuz.");
            }
            else MessageBox.Show("Seçilebilecek bir araç kalmadı.");


        }//buttonbuycar parantezi

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            verileriaktar();
        }//datagridview'de her satır seçimi değiştiğinde araç bilgilerini textbox'a yazdırdık. +
        private void textBoxcarsellprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }//satış fiyatı olarak sadece rakam girmelerini sağladık. +

        private void textBoxsearchcarproductionyear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        } //araç üretim yılı olarak sadece rakam girilebilmesini ayarladık.
        private void textBoxtcno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        } //tc bölümüne sadece rakam girilmesini sağladık.

        private void buttonexit_Click(object sender, EventArgs e)
        {
            savefiles();
            System.Threading.Thread.Sleep(2000);
            Application.Exit();
        }//programı kapattık.
        private void buttonmainmenu_Click(object sender, EventArgs e)//bir önceki ekrana yani ana menüye döndük.
        {
            savefiles();
            System.Threading.Thread.Sleep(2000);
            MainScreen mainscreen = new MainScreen();
            mainscreen.activeadmin = activeadmin;
            mainscreen.Show();
            this.Close();
        }

        private void buttonbrandok_Click(object sender, EventArgs e)
        {
            searchingridview(textBoxsearchcarbrand.Text, "[Araç Markası]");
        } //markaya göre aramak için buton.

        private void buttonmodelok_Click(object sender, EventArgs e)
        {
            searchingridview(textBoxsearchcarmodel.Text, "[Araç Modeli]");
        } //modele göre aramak için buton.

        private void buttontypeok_Click(object sender, EventArgs e)
        {
            searchingridview(textBoxsearchcartype.Text, "[Araç Türü]");
        } //araç türüne göre aramak için buton.

        private void buttonprotuctionyearok_Click(object sender, EventArgs e)
        {
            searchingridview(textBoxsearchcarproductionyear.Text, "[Üretim Yılı]");

        } //üretim yılına göre aramak için buton.

        private void buttoncolorok_Click(object sender, EventArgs e)
        {
            searchingridview(textBoxsearchcarcolor.Text, "[Araç Rengi]");
        } //renge göre aramak için buton.
    }
}
