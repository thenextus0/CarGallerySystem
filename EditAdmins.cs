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
    public partial class EditAdmins : Form
    {
        public EditAdmins()
        {
            InitializeComponent();
        }

        string[,] admininfo;
        public string[] activeadmin = new string[7];
        string[,] acceslevels;
        int newid = 0;

        void savefilesad()
        {
            FileStream fs = new FileStream(Application.StartupPath + @"\..\..\Logininfos\admins.csv", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("\r\n");
            sw.Write(textBoxsavenewadmin.Text);

            sw.Close();
            fs.Close();
        } //admin ekledikten sonra dosyaya kaydettik.

        void savefilesda()
        {
            File.WriteAllText(Application.StartupPath + @"\..\..\Logininfos\admins.csv", textBoxda.Text);
        } //admin sildikten sonra dosyaya kaydettik.

        void matriseaktarda()
        {
            string[] ilkparca = textBoxda.Lines[0].Split(';');
            admininfo = new string[textBoxda.Lines.Length, ilkparca.Length];//matrisi boyutlandırdık.
            for (int i = 0; i < admininfo.GetLength(0); i++)
            {
                string[] parca = textBoxda.Lines[i].Split(';');
                for (int j = 0; j < parca.Length; j++) admininfo[i, j] = parca[j];
            } //dosyadaki bilgileri matris'e aktardık.
        } //textbox'ta ki admin verilerini aldık ve matrise attık. (delete admin sekmesi.)

        void veriaktarca()
        {
            comboBoxcaselectaadmin.Items.Clear();
            comboBoxselectadminda.Items.Clear();
            for (int i = 0; i < admininfo.GetLength(0); i++)
            {
                comboBoxcaselectaadmin.Items.Add(admininfo[i, 1]); //yetkili kullanıcı adlarını combobox'a aktardık. (changeacces)
                comboBoxselectadminda.Items.Add(admininfo[i, 1]); //yetkili kullanıcı adlarını combobox'a aktardık. (delete admin)
            }
            comboBoxcaselectaadmin.SelectedIndex = 0;
            comboBoxselectadminda.SelectedIndex = 0;
        } // admin kullanıcı adlarını combobox'a aktardık. (change acces level sekmesi.)

        void acceslevelaktar()
        {
            comboBoxacceslevel.Items.Clear(); //acceslevel combobox'unu boşalttık. (addnewadmin)
            comboBoxca.Items.Clear(); //acceslevel combobox'unu boşalttık. (changeacces)
            textBoxacceslevel.Text = File.ReadAllText(Application.StartupPath + @"\..\..\Logininfos\Acceslevel\acceslevel.csv");
            string[] iparca = textBoxacceslevel.Lines[0].Split(';');
            acceslevels = new string[textBoxacceslevel.Lines.Length, iparca.Length]; //matrisi boyutlandırdık.

            for (int i = 0; i < textBoxacceslevel.Lines.Length; i++)
            {
                string[] parca = textBoxacceslevel.Lines[i].Split(';');
                comboBoxacceslevel.Items.Add(parca[1]); //yetki seviyelerini combobox'a aktardık. (addnewadmin)
                comboBoxca.Items.Add(parca[1]); //yetki seviyelerini combobox'a aktardık. (changeacces)
                for (int j = 0; j < parca.Length; j++) acceslevels[i, j] = parca[j];
            }
            comboBoxacceslevel.SelectedIndex = 0; //combobox'ın index'ini seçtirdik. (addnewadmin)
            comboBoxca.SelectedIndex = 0; //combobox'ın index'ini seçtirdik. (changeacces)
        } //acceslevel'i matrise aktardık. (add admin sekmesi.)

        private void EditAdmins_Load(object sender, EventArgs e)
        {
            textBoxda.Text = File.ReadAllText(Application.StartupPath + @"\..\..\Logininfos\admins.csv");
            acceslevelaktar(); //addnewadmin sekmesini ayarladık. (acces level'i combobox'a attık ve matrise attık.)
            matriseaktarda();
            veriaktarca(); //change acces ve delete admin sekmesinde ki acces level combobox'larını ve acceslevel matrisini ayarladık.

            labelactiveadmin.Text = "Aktif Hesap: " + activeadmin[1] + "(" + activeadmin[6] + ")"; //aktif hesabı label'e yazdırdık. (sadece güzel görünsün diye.)
        } //başlangıç değerlerini ayarladık.

        private void buttonaddadmin_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboBoxacceslevel.SelectedItem) < Convert.ToInt32(activeadmin[5]))
            {
                if (textBoxusername.Text != "" && textBoxpassword.Text != "" && textBoxadname.Text != "" && textBoxadsurname.Text != "" && textBoxjobtitle.Text != "")
                {
                    if (textBoxpassword.TextLength < 5) MessageBox.Show("Şifre 5 karakterden kısa olamaz.");
                    else if (textBoxusername.TextLength < 6) MessageBox.Show("Kullanıcı adı 6 karakterden kısa olamaz.");
                    else if (textBoxadname.TextLength < 2) MessageBox.Show("Girilen ad 2 karakterden kısa olamaz.");
                    else if (textBoxadsurname.TextLength < 2) MessageBox.Show("Girilen soyadı 2 karakterden kısa olamaz.");
                    else if (textBoxjobtitle.TextLength < 2) MessageBox.Show("Girilen iş ünvanı 2 karakterden kısa olamaz.");
                    else if (textBoxusername.Text.Contains(";")) MessageBox.Show("Kullanıcı adında ';' kullanamazsınız.");
                    else if (textBoxpassword.Text.Contains(";")) MessageBox.Show("Şifre kısmında ';' kullanamazsınız.");
                    else if (textBoxadname.Text.Contains(";")) MessageBox.Show("Ad kısmında ';' kullanamazsınız.");
                    else if (textBoxadsurname.Text.Contains(";")) MessageBox.Show("Soyadı kısmında ';' kullanamazsınız.");
                    else if (textBoxjobtitle.Text.Contains(";")) MessageBox.Show("İş ünvanı kısmında ';' kullanamazsınız.");
                    else
                    {
                        string newusername = textBoxusername.Text;
                        bool diffirentusername = true;
                        for (int i = 0; i < admininfo.GetLength(0); i++)
                            if (newusername == admininfo[i, 1])
                            {
                                diffirentusername = false;
                                break;
                            }//girilen kullanıcı adında başka bir admin var mı diye kontrol ettik.

                        if (diffirentusername == false) MessageBox.Show("Girdiğiniz kullanıcı adı kullanılmaktadır. Lütfen farklı bir kullanıcı adı deneyiniz.");
                        else
                        {
                            if (textBoxpassword.Text.Contains("#") || textBoxpassword.Text.Contains("$") || textBoxpassword.Text.Contains("*"))
                            {
                                if (newid == 0)
                                {
                                    int enb = Convert.ToInt32(admininfo[0, 0]);
                                    for (int i = 1; i < admininfo.GetLength(0); i++) if (enb < Convert.ToInt32(admininfo[i, 0])) enb = Convert.ToInt32(admininfo[i, 0]);
                                    newid = enb + 1;
                                } //id ilk defa ayarlanıyorsa en büyük id 'yi bulduk ve o id'ye göre yeni id verdik.

                                textBoxsavenewadmin.Text += newid.ToString() + ";" + textBoxusername.Text + ";" + textBoxpassword.Text + ";" + textBoxadname.Text + ";" + textBoxadsurname.Text + ";" + comboBoxacceslevel.SelectedItem.ToString() + ";" + textBoxjobtitle.Text;
                                textBoxda.Text += "\r\n" + newid.ToString() + ";" + textBoxusername.Text + ";" + textBoxpassword.Text + ";" + textBoxadname.Text + ";" + textBoxadsurname.Text + ";" + comboBoxacceslevel.SelectedItem.ToString() + ";" + textBoxjobtitle.Text;
                                newid++;

                                savefilesad();
                                matriseaktarda();
                                veriaktarca();
                                textBoxsavenewadmin.Text = ""; //textBoxsaveadmin'i temizledik.
                            }
                            else MessageBox.Show("Şifreniz '#', '$', '*' karakterlerinden en az bir tanesini içermelidir.");
                        }
                    }
                }
                else MessageBox.Show("Lütfen gerekli bilgileri eksiksiz doldurunuz.");
            }
            else MessageBox.Show("Kendi yetki düzeyinizde ya da kendi yetki düzeyinizden daha yüksek bir kullanıcıyı sisteme ekleyemezsin.");
        } //admin ekleme tuşu.

        private void buttondeleteadmin_Click(object sender, EventArgs e)
        {
            if (activeadmin[1] == comboBoxselectadminda.SelectedItem.ToString()) MessageBox.Show("Kendinizi sistemden silemezsiniz.");
            else
            {
                if (Convert.ToInt32(admininfo[comboBoxselectadminda.SelectedIndex, 5]) < Convert.ToInt32(activeadmin[5]))
                {
                    if (activeadmin[2] == textBoxpasswordda.Text)
                    {
                        int silinecekadminsatiri = comboBoxselectadminda.SelectedIndex;
                        string[] organizeinfos = textBoxda.Lines;
                        for (int i = silinecekadminsatiri; i < organizeinfos.Length - 1; i++)
                        {
                            string gcc = organizeinfos[i];
                            organizeinfos[i] = organizeinfos[i + 1];
                            organizeinfos[i + 1] = gcc;//seçilen satırdan başlıyarak seçili satırı bir sonraki satırla değiştirdik. for bittiğinde silinecek admini dizinin son elemanı olarak atanmış oldu.
                        }
                        Array.Resize(ref organizeinfos, organizeinfos.Length - 1);
                        textBoxda.Lines = organizeinfos; //bilgileri düzenledikten sonra textbox'a geri yazdırdık.
                        savefilesda();
                        matriseaktarda();
                        veriaktarca();
                    }
                    else MessageBox.Show("Şifreniz hatalı, lütfen yeniden deneyiniz.");
                }
                else MessageBox.Show("Sileceğiniz kullanıcının yetki düzeyi sizin yetki düzeyinize eşit ya da daha yüksek olamaz.");
            }
        } //admin silme tuşu.

        private void buttonchangeacceslevel_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboBoxca.SelectedItem) < Convert.ToInt32(activeadmin[5]))
            {
                if (activeadmin[1] == comboBoxcaselectaadmin.SelectedItem.ToString()) MessageBox.Show("Kendi yetki düzeyinizi değiştiremezsin.");
                else
                {
                    if (Convert.ToInt32(admininfo[comboBoxcaselectaadmin.SelectedIndex, 5]) < Convert.ToInt32(activeadmin[5]))
                    {
                        if (activeadmin[2] == textBoxcapassword.Text)
                        {
                            int degisecekadminsatiri = comboBoxcaselectaadmin.SelectedIndex;
                            File.WriteAllText(Application.StartupPath + @"\..\..\Logininfos\admins.csv", textBoxda.Text);

                            string[] infosca = textBoxda.Lines;
                            string[] degiseceksatir = infosca[degisecekadminsatiri].Split(';');
                            infosca[degisecekadminsatiri] = ""; //değişecek adminin bilgilerini sıfırladık.
                            degiseceksatir[5] = comboBoxca.SelectedItem.ToString();
                            for (int i = 0; i < degiseceksatir.Length; i++)
                            {
                                if (i == degiseceksatir.Length - 1) infosca[degisecekadminsatiri] += degiseceksatir[i];
                                else infosca[degisecekadminsatiri] += degiseceksatir[i] + ";";
                            }
                            textBoxda.Lines = infosca;

                            savefilesda(); //admin infosunu dosyaya kaydettik.
                            matriseaktarda(); //admin infosu değiştiği için matrisi güncelledik.
                        }
                        else MessageBox.Show("Şifreniz hatalı, lütfen yeniden deneyiniz.");
                    }
                    else MessageBox.Show("Kendi yetki düzeyinize eşit ya da daha yüksek yetki düzeyine sahip bir kullanıcının, yetki düzeyini değiştiremezsin.");
                }
            }
            else MessageBox.Show("Bir kullanıcıya kendi yetki düzeyinizde ya da daha yüksek bir yetki düzeyi veremezsiniz.");
        } //admin yetki seviyesi değiştirme tuşu.

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
