using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LKS_DIY_2026_12.Models;      
using LKS_DIY_2026_12.Repositories;

namespace LKS_DIY_2026_12.Forms
{
    public partial class FormLogin : Form
    {
       
        private readonly UserRepository _userRepo;
        private readonly LogRepository _logRepo;

        public FormLogin()
        {
            InitializeComponent();

      
            _userRepo = new UserRepository();
            _logRepo = new LogRepository();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }

  
        private void btn_login_Click(object sender, EventArgs e)
        {
            
            string email = tb_email.Text;
            string password = tb_password.Text;


            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Email atau password yang anda masukkan tidak sesuai !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
                users user = _userRepo.Login(email, password);

                if (user != null)
                {

                    tbl_log newLog = new tbl_log
                    {
                        waktu = DateTime.Now,
                        aktivitas = "Login",
                        id_user = user.id
                    };
                    _logRepo.TambahLog(newLog);

                  
                    this.Hide();

                 
                    string role = user.tipe_user.ToLower();

                    if (role == "admin")
                    {
                        FormAdmin formAdmin = new FormAdmin(user.nama);
                        formAdmin.Show();
                    }
                    else if (role == "gudang")
                    {
                        FormGudang formGudang = new FormGudang(user.nama);
                        formGudang.Show();
                    }
                    else if (role == "kasir")
                    {
                        FormKasir formKasir = new FormKasir(user.nama);
                        formKasir.Show();
                    }
                }
                else
                { 
                    MessageBox.Show("Email atau password yang anda masukkan tidak sesuai !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Tambahkan Event Click untuk Tombol Reset ---
        private void btn_reset_Clic(object sender, EventArgs e)
        {
            tb_email.Clear();
            tb_password.Clear();
            tb_email.Focus();
        }
    }
}