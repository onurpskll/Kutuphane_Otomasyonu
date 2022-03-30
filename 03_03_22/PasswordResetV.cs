using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _03_03_22
{
    public partial class PasswordResetV : Form
    {
        public PasswordResetV()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(Connection.con);

        bool KullaniciVarMi(string kullaniciAdi)
        {
            bool varMi = false;

            try
            {
                Connection.ConnectionCntrl(con);

                SqlCommand cmdKullaniciVarMi = new SqlCommand("SP_KULLANICI_VARMI", con);
                cmdKullaniciVarMi.CommandType = CommandType.StoredProcedure;
                cmdKullaniciVarMi.Parameters.AddWithValue("@KULLANICI_ADI", txtKullanici.Text);

                int degerCntrl = (int)cmdKullaniciVarMi.ExecuteScalar();

                if (degerCntrl < 1)
                    varMi = false;
                else
                    varMi = true;
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

            return varMi;
        }

        private void btnKullaniciKontrol_Click(object sender, EventArgs e)
        {
            bool v1 = KullaniciVarMi(txtKullanici.Text);

            if (!v1)
            {
                MessageBox.Show("Sistemde böyle bir kullanıcıya ait hesap bulunamadı!");
            }
            else
            {
                cboGuvenlikSorusu.Enabled = true;
                txtCevap.Enabled = true;
                txtSifre.Enabled = true;
                txtSifreTekrar.Enabled = true;
                btnSifreGuncelle.Enabled = true;
            }
        }

        private void btnSifreGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.ConnectionCntrl(con);

                SoruCevapCntrl();
                SifreSifirla();

                LoginV loginV = new LoginV();
                this.Hide();
                loginV.ShowDialog();
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

        private void SoruCevapCntrl()
        {
            SqlCommand cmdBilgiler = new SqlCommand($@"SELECT COUNT(*) FROM KULLANICILAR_TBL WHERE (KULLANICI_ADI = '{txtKullanici.Text}' OR KULLANICI_MAIL = '{txtKullanici.Text}') AND GUVENLIK_SORUSU = '{cboGuvenlikSorusu.Text}' AND CEVAP = '{txtCevap.Text.Trim().ToUpper()}'", con);
            int sonuc = (int)cmdBilgiler.ExecuteScalar();
            if (sonuc < 1)
            {
                MessageBox.Show("Cevabınız bu kullanıcıya ait değil!");
            }
            else
            {
                txtSifre.Enabled = true;
                txtSifreTekrar.Enabled = true;
            }
        }

        private void SifreSifirla()
        {
            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Girdiğiniz şifre kısımları birbiriyle uyuşmuyor!");
                txtSifre.Clear(); txtSifreTekrar.Clear();
                txtSifre.Focus();
            }
            else
            {
                SqlCommand cmdSifreSifirla = new SqlCommand("SP_SIFRE_GUNCELLE", con);
                cmdSifreSifirla.CommandType = CommandType.StoredProcedure;
                cmdSifreSifirla.Parameters.AddWithValue("@KULLANICI_ADI", txtKullanici.Text);
                cmdSifreSifirla.Parameters.AddWithValue("@SIFRE", txtSifre.Text);
                cmdSifreSifirla.ExecuteNonQuery();

                MessageBox.Show("Şifreniz başarıyla güncellendi!");
                LoginV loginV = new LoginV();
                loginV.ShowDialog();
            }
        }

        private void PasswordReset_Load(object sender, EventArgs e)
        {
            foreach (var item in RegisterV.SoruGetir())
            {
                cboGuvenlikSorusu.Items.Add(item);
            }
        }

        private void PasswordReset_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            LoginV loginV = new LoginV();
            loginV.ShowDialog();
        }
    }
}
