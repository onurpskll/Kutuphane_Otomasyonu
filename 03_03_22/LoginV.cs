using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_03_22
{
    public partial class LoginV : Form
    {
        public LoginV()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(Connection.con);

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            bool v = BosMu(txtKullanici.Text, txtSifre.Text);
            if (v)
            {
                bool v1 = KullaniciCntrl(txtKullanici.Text, txtSifre.Text);
                if (v1)
                {
                    MainV mainV = new MainV();
                    this.Hide();
                    mainV.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Bulunamadı! Lütfen Kontrol Ediniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public static bool BosMu(params string[] value)
        {
            bool bosMu = false;
            foreach (var item in value)
            {
                if (string.IsNullOrEmpty(item) || item == "")
                {
                    MessageBox.Show("Lütfen alanları boş geçmeyiniz");
                    return false;
                }
                else
                {
                    bosMu = true;
                }
            }
            return bosMu;
        }

        bool KullaniciCntrl(string kullaniciAdi, string sifre)
        {
            bool varMi = false;

            try
            {
                Connection.ConnectionCntrl(con);

                SqlCommand cmd = new SqlCommand("SP_KULLANICI_HESAP_KONTROLU", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@KULLANICI_ADI", kullaniciAdi);
                cmd.Parameters.AddWithValue("@SIFRE", sifre);
                int sonuc = (int)cmd.ExecuteScalar();

                if (sonuc < 1)
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

        private void chkGosterGizle_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGosterGizle.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordResetV passwordReset = new PasswordResetV();
            this.Hide();
            passwordReset.ShowDialog();
        }

        private void btnRegisterEkrani_Click(object sender, EventArgs e)
        {
            RegisterV registerV = new RegisterV();
            this.Hide();
            registerV.ShowDialog();
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnGirisYap_Click(sender, e);
            }
        }

        private void LoginV_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }
    }
}
