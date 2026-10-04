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
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }

        public string[] activeadmin = new string[7];
        int newid = 0;
        string carphotofilepath;

        void savefiles()
        {
            FileStream fs = new FileStream(Application.StartupPath + @"\..\..\Storage Infos\Storage.csv", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            for (int i = 0; i < textBoxsavetostorage.Lines.Length - 1; i++)
            {
                if (i == 0) sw.WriteLine("");
                if (i == textBoxsavetostorage.Lines.Length - 2) sw.Write(textBoxsavetostorage.Lines[i]);
                else sw.WriteLine(textBoxsavetostorage.Lines[i]);
            }
            sw.Close();
            fs.Close();
        }

        private void AddCar_Load(object sender, EventArgs e)
        {
            labelactiveadmin.Text = "Aktif Hesap: " + activeadmin[1] + "(" + activeadmin[6] + ")";
        }

        private void buttonselectapicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Jpeg (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxcarpicture.Image = Image.FromFile(openFileDialog1.FileName);
                    carphotofilepath = openFileDialog1.FileName; //fotoğraf path'ini aldık.
                }
                catch
                {
                    MessageBox.Show("Lütfen bir resim formatı seçiniz.");
                }
            }
        }// Eklediğimiz araç için resim seçme alanını ayarladık.

        private void buttonaddcar_Click(object sender, EventArgs e)
        {
            if (textBoxcarbrand.Text != "" && textBoxcarmodel.Text != "" && textBoxcartype.Text != "" && textBoxcarproductionyear.Text != "" && textBoxcarcolor.Text != "" && textBoxcarkm.Text != "" && textBoxcarprice.Text != "" && textBoxcaramounth.Text != "" && pictureBoxcarpicture.Image != null)
            {
                if (newid == 0)
                {
                    textBoxinfos.Text = File.ReadAllText(Application.StartupPath + @"\..\..\Storage Infos\Storage.csv");
                    string ilksatir = textBoxinfos.Lines[0];
                    string[] ilkparca = ilksatir.Split(';');
                    string[,] infos = new string[textBoxinfos.Lines.Length, ilkparca.Length]; //matrisi boyutlandırdık.

                    for (int i = 0; i < infos.GetLength(0); i++)
                    {
                        string satir = textBoxinfos.Lines[i];
                        string[] parca = satir.Split(';');

                        for (int j = 0; j < infos.GetLength(1); j++) infos[i, j] = parca[j];
                    } //bilgileri matrise aktardık.

                    int enb = Convert.ToInt32(infos[0, 0]);
                    for (int i = 1; i < infos.GetLength(0); i++) if (enb < Convert.ToInt32(infos[i, 0])) enb = Convert.ToInt32(infos[i, 0]); //en büyük id'yi bulduk.
                    newid = enb + 1; //eklenicek araca id ayarladık.
                }

                textBoxsavetostorage.Text += newid.ToString() + ";" + textBoxcarbrand.Text + ";" + textBoxcarmodel.Text + ";" + textBoxcartype.Text + ";" + textBoxcarproductionyear.Text + ";" + textBoxcarcolor.Text + ";" + textBoxcarkm.Text + ";" + textBoxcarprice.Text + ";" + textBoxcaramounth.Text + ";" + carphotofilepath + "\r\n"; //dosyaya yazacağımız biçimde bilgileri yazıyoruz.
                newid++;
                //yeni eklenicek aracın bilgilerini aktardık.
            }
            else MessageBox.Show("Lütfen gerekli tüm bilgileri doldurduğunuzdan emin olunuz.");
        } //bilgileri aktardık.

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBoxcarbrand.Clear();
            textBoxcarmodel.Clear();
            textBoxcartype.Clear();
            textBoxcarproductionyear.Clear();
            textBoxcarcolor.Clear();
            textBoxcarkm.Clear();
            textBoxcarprice.Clear();
            textBoxcaramounth.Clear();
            pictureBoxcarpicture.Image = null;//yeni araç eklerken kolaylık olsun diye eski bilgileri temizledik.
        }

        private void textBoxcaramounth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        } //eklenecek araç miktarı olarak sadece rakam girilmesini ayarladık.

        private void textBoxcarproductionyear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        } //üretim yılına sadece rakam girilmesi için ayar yaptık.

        private void textBoxcarkm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        } //kilometre olarak sadece rakam girilmesi için ayar yaptık.

        private void textBoxcarprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        } //fiyat olarak sadece rakam girilmesini ayarladık.

        private void buttonexit_Click(object sender, EventArgs e)
        {
            savefiles();
            Application.Exit();
        } //programı kapatma düğmesi.

        private void buttonmainmenu_Click(object sender, EventArgs e)
        {
            savefiles();
            MainScreen mainscreen = new MainScreen();
            mainscreen.activeadmin = activeadmin;
            mainscreen.Show();
            this.Close();
        } //ana menüye dönme düğmesi.
    }
}
