using LKS_DIY_2026_12.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_DIY_2026_12
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = tb_email.Text;
            string password = tb_password.Text;

            // Logic Login
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email dan Password tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var userRepo = new Repositories.UserRepository();
                var user = userRepo.Login(email, password);
                if (user != null)
                {
                    Helpers.SessionHelper.currentUser = user;
                    MessageBox.Show("Login Berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm formAdmin = new MainForm();
                    formAdmin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email atau Password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}