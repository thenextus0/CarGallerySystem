using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thenextusgallerysystemnew
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        public string[] activeadmin = new string[7];
        private void MainScreen_Load(object sender, EventArgs e)
        {
            labelactiveadmin.Text = "Aktif Hesap : " + activeadmin[1] + "(" + activeadmin[6] + ")";
            //bu kısımda acces level'a göre buttonlar gözükecek ya da gözükmeyecek.
        }

        private void buttonaddcar_Click(object sender, EventArgs e)
        {
            if (1  <= Convert.ToInt32(activeadmin[5]))
            {
                AddCar addcar = new AddCar();
                addcar.activeadmin = activeadmin; //aktif hesap bilgilerini aktardık.
                addcar.Show();
                this.Close();
            }
            else MessageBox.Show("Stajyer hesaplarının bu işlemi gerçekleştirme yetkisi bulunmamaktadır, Lütfen Yöneticinizle konuşunuz.");
        } //araç ekleme formunu açtık.

        private void buttonconfirm_Click(object sender, EventArgs e)
        {
            if (1 <= Convert.ToInt32(activeadmin[5]))
            {
                BuyConfirmationScreen buyconfirmationscreen = new BuyConfirmationScreen();
                buyconfirmationscreen.activeadmin = activeadmin; //aktif admin bilgilerini diğer forma aktardık.
                buyconfirmationscreen.Show();
                this.Close();
            } //aktif hesabın acceslevel'i 0'sa işlemi yapamıyor.
            else MessageBox.Show("Bu işlemi gerçekleştirebilmek için yetkiniz bulunmuyor.");
        } //araç satış onay formunu açtık.

        private void buttoneditadmins_Click(object sender, EventArgs e)
        {
            if (5 <= Convert.ToInt32(activeadmin[5]))
            {
                EditAdmins editadmins = new EditAdmins();
                editadmins.activeadmin = activeadmin;
                editadmins.Show();
                this.Close();
            }
            else MessageBox.Show("Bu işlemi gerçekleştirebilmek için yetkiniz bulunmuyor.");
        } //admin düzenleme formunu açtık.

        private void buttonreports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.activeadmin = activeadmin;
            reports.Show();
            this.Close();
        } //rapor ekranı formunu açtık.

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } //programı kapattık.

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            LoginScreen loginscreen = new LoginScreen();
            loginscreen.Show();
            this.Close();
        } //giriş yapma ekranına döndük.
    }
}
