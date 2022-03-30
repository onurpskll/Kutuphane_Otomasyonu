using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _03_03_22
{
    public partial class MainV : Form
    {
        public MainV()
        {
            InitializeComponent();
        }

        private void MainV_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }
    }
}
