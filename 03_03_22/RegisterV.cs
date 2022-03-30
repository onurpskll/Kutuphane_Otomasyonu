using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _03_03_22
{
    public partial class RegisterV : Form
    {
        public RegisterV()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(Connection.con);

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            SayisalDegerKontrol(e);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            SayisalDegerKontrol(e);
        }
        private void SayisalDegerKontrol(KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
        }
        private void AlfaNumerikKontrol(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            bool bosCntrl = LoginV.BosMu(txtAd.Text, txtSoyad.Text, txtMail.Text, txtKullaniciAdi.Text, txtSifre.Text, txtSifreTekrar.Text, cboGuvenlikSorusu.Text);

            if (bosCntrl)
            {
                try
                {
                    Connection.ConnectionCntrl(con);

                    if (txtSifre.Text != txtSifreTekrar.Text)
                    {
                        MessageBox.Show("Şifreler uyuşmuyor!");
                        txtSifre.Focus();
                    }
                    else
                    {
                        KullaniciKaydet(txtAd.Text, txtSoyad.Text, txtMail.Text, txtKullaniciAdi.Text, txtSifre.Text, cboGuvenlikSorusu.Text, cevap);

                        AlanTemizle(txtAd, txtSoyad, txtMail, txtKullaniciAdi, txtSifre, txtSifreTekrar, cboGuvenlikSorusu, txtCevap);

                        LoginV loginV = new LoginV();
                        this.Hide();
                        loginV.ShowDialog();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Dispose();
                    con.Close();
                }
            }
        }

        public static void AlanTemizle(params Control[] value)
        {
            foreach (Control item in value)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
                else if (item is CheckBox)
                {
                    CheckBox chkbox = (CheckBox)item;
                    chkbox.Checked = false;
                }
                else if (item is ComboBox)
                {
                    ComboBox cbox = (ComboBox)item;
                    cbox.SelectedIndex = -1;
                }
            }
        }

        private void KullaniciKaydet(string ad, string soyad, string kMail, string kAdi, string kSifre, string guvenlikSorusu, string cevap)
        {

            SqlCommand cmdKullaniciKaydet = new SqlCommand("SP_KULLANICI_KAYDET", con);
            cmdKullaniciKaydet.CommandType = CommandType.StoredProcedure;
            cmdKullaniciKaydet.Parameters.AddWithValue("@ADI", ad.Trim().ToUpper());
            cmdKullaniciKaydet.Parameters.AddWithValue("@SOYADI", soyad.Trim().ToUpper());
            cmdKullaniciKaydet.Parameters.AddWithValue("@MAIL", kMail);
            cmdKullaniciKaydet.Parameters.AddWithValue("@KULLANICI_ADI", kAdi);
            cmdKullaniciKaydet.Parameters.AddWithValue("@SIFRE", kSifre);
            cmdKullaniciKaydet.Parameters.AddWithValue("@GUVENLIK_SORUSU", guvenlikSorusu);
            cmdKullaniciKaydet.Parameters.AddWithValue("@CEVAP", cevap.Trim().ToUpper());
            cmdKullaniciKaydet.ExecuteNonQuery();

            MessageBox.Show("Kullanıcı başarıyla eklendi!", "KAYIT", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static bool Email_Format_Kontrol(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli bir mail adresi giriniz");
                return false;
            }
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            bool mailCntrl = Email_Format_Kontrol(txtMail.Text);

            if (mailCntrl == false)
            {
                txtMail.Clear();
            }
        }
        string secilen;
        string cevap;
        private void RegisterV_Load(object sender, EventArgs e)
        {
            foreach (var item in SoruGetir())
            {
                cboGuvenlikSorusu.Items.Add(item);
            }
        }

        public static string[] SoruGetir()
        {
            string[] sorular = new string[] { "İlk evcil hayvanınızın adı?", "İlkokul öğretmeninizin adı?" };
            return sorular;
        }

        private void cboGuvenlikSorusu_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilen = cboGuvenlikSorusu.Text;
            if (secilen != "")
            {
                cevap = Interaction.InputBox(secilen, "Güvenlik Sorusu", "", 300, 300);
                txtCevap.Text = cevap;
            }

        }

        private void RegisterV_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginV loginV = new LoginV();
            this.Hide();
            loginV.ShowDialog();
        }
    }
}
