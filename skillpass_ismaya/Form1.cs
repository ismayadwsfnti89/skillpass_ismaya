using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
  

namespace skillpass_ismaya
{
    public partial class Login : Form
    {
        public static string namaUser = "";

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!");
                return;
            }

            using (SqlConnection conn = koneksi.GetConnection())
            {
                conn.Open();

                // PERHATIKAN: Nama tabel dibungkus [user] agar tidak error "syntax near keyword 'user'"
                // Jika di database kamu namanya tbl_user, ganti [user] menjadi tbl_user
                string query = "SELECT * FROM [user] WHERE username=@user AND password=@pass";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    namaUser = reader["fullname"].ToString();
                    MessageBox.Show("Login Berhasil!");

                    FormDonasi donasi = new FormDonasi();
                    donasi.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah!");
                }

                reader.Close();
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}