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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        string[,] infos; //bilgileri kontrol edebilmek için matrise aktaracağımız için matris oluşturduk.
        string[] activeadmin = new string[7];
        void matriseaktar()
        {
            string[] ilksatirparca = textBoxinfos.Lines[0].Split(';'); //matrisi boyutlandırmak için sütun sayısını öğrendik.
            infos = new string[textBoxinfos.Lines.Length, ilksatirparca.Length]; //matrisi boyutlandırdık.

            for (int i = 0; i < infos.GetLength(0); i++)
            {
                string satir = textBoxinfos.Lines[i];
                string[] parca = satir.Split(';');
                for (int j = 0; j < infos.GetLength(1); j++) infos[i,j] = parca[j]; //bilgileri matrise attık.
            }
        } //login'de bilgileri kontrol edeceğimiz için matris'e aktardık.

        bool bilgilerikontrolet(string username, string password)
        {
            bool userfound = false;
            bool passwordtrue = false;
            bool systementry = false;
            for (int i = 0; i < infos.GetLength(0); i++)
                if (username == infos[i, 1])
                {
                    userfound = true;
                    if (password == infos[i, 2])
                    {
                        passwordtrue = true;
                        for (int j = 0; j < activeadmin.Length; j++) activeadmin[j] = infos[i, j]; //giriş yapılan adminin bilgilerini aldık.
                        break;
                    }
                }

            if (userfound == true)
            {
                if (passwordtrue == true) systementry = true;
                else MessageBox.Show("Girilen şifre hatalı.");
            }
            else MessageBox.Show("Girdiğiniz kullanıcı adıyla uyuşan bir kullanıcı hesabı bulunamadı.");

            return systementry;
        } //login sırasında girilen bilgileri kontrol ettik, Bilgiler uyuşuyorsa sisteme giriş yaptırdık.

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            textBoxinfos.Text = File.ReadAllText(Application.StartupPath + @"\..\..\Logininfos\admins.csv");
            matriseaktar();
        } //başlangıça admin bilgilerini textbox'a yazıp matrise aktardık.

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            bool systementry = bilgilerikontrolet(textBoxloginusername.Text, textBoxloginpassword.Text);
            if (systementry == true)
            {
                MainScreen mainscreen = new MainScreen();
                mainscreen.activeadmin = activeadmin; //giriş yapan adminin bilgilerini mainscreen'e aktardık.
                mainscreen.Show();
                this.Hide();
            }
        } //admin login işlemlerini yaptık.
      
        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } //programı kapattık.
    }
}
