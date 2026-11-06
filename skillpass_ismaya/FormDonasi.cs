using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace skillpass_ismaya
{
    public partial class FormDonasi : Form
    {
        string idTerpilih = "";

        public FormDonasi()
        {
            InitializeComponent();
        }

        private void FormDonasi_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Selamat Datang, " + Login.namaUser;
            TampilData();
            BersihkanForm();
        }

        // ================= TAMPIL DATA (READ) =================
        void TampilData()
        {
            using (SqlConnection conn = koneksi.GetConnection())
            {
                conn.Open();
                // Pastikan nama tabel di database kamu adalah "donasi"
                string query = "SELECT * FROM donasi";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDonasi.DataSource = dt;
            }
        }

        // ================= PENCARIAN (SEARCH) =================
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = koneksi.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM donasi WHERE nama_donatur LIKE @cari";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cari", "%" + txtSearch.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDonasi.DataSource = dt;
            }
        }

        // ================= KLIK TABEL =================
        private void dgvDonasi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDonasi.Rows[e.RowIndex];

                // Pastikan nama kolom di database sama dengan yang ada di dalam kurung kurawal ini
                idTerpilih = row.Cells["id_donasi"].Value.ToString();
                txtNamaDonatur.Text = row.Cells["nama_donatur"].Value.ToString();
                txtProgram.Text = row.Cells["program"].Value.ToString();
                txtNominal.Text = row.Cells["nominal"].Value.ToString();
                dtpTanggal.Value = Convert.ToDateTime(row.Cells["tanggal"].Value);
                txtKeterangan.Text = row.Cells["keterangan"].Value.ToString();
            }
        }

        // ================= BERSIHKAN FORM =================
        void BersihkanForm()
        {
            txtNamaDonatur.Text = "";
            txtProgram.Text = "";
            txtNominal.Text = "";
            txtKeterangan.Text = "";
            dtpTanggal.Value = DateTime.Now;
            idTerpilih = "";
            txtNamaDonatur.Focus();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            BersihkanForm();
        }

        // ================= SIMPAN (CREATE) =================
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi kosong
            if (txtNamaDonatur.Text == "" || txtProgram.Text == "" || txtNominal.Text == "")
            {
                MessageBox.Show("Semua kolom wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi nominal (harus angka & tidak negatif)
            int nominal;
            if (!int.TryParse(txtNominal.Text, out nominal) || nominal < 0)
            {
                MessageBox.Show("Nominal harus angka dan tidak negatif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = koneksi.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO donasi (nama_donatur, program, nominal, tanggal, keterangan) " +
                               "VALUES (@nama, @program, @nominal, @tanggal, @ket)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", txtNamaDonatur.Text);
                cmd.Parameters.AddWithValue("@program", txtProgram.Text);
                cmd.Parameters.AddWithValue("@nominal", nominal);
                cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.Date);
                cmd.Parameters.AddWithValue("@ket", txtKeterangan.Text);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Data berhasil disimpan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TampilData();
            BersihkanForm();
        }

        // ================= UBAH (UPDATE) =================
        private void btnUbah_Click(object sender, EventArgs e)
        {
            // Validasi kosong
            if (txtNamaDonatur.Text == "" || txtProgram.Text == "" || txtNominal.Text == "")
            {
                MessageBox.Show("Semua kolom wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi nominal
            int nominal;
            if (!int.TryParse(txtNominal.Text, out nominal) || nominal < 0)
            {
                MessageBox.Show("Nominal harus angka dan tidak negatif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (idTerpilih == "")
            {
                MessageBox.Show("Pilih data di tabel dulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = koneksi.GetConnection())
            {
                conn.Open();
                string query = "UPDATE donasi SET nama_donatur=@nama, program=@program, " +
                               "nominal=@nominal, tanggal=@tanggal, keterangan=@ket WHERE id_donasi=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", txtNamaDonatur.Text);
                cmd.Parameters.AddWithValue("@program", txtProgram.Text);
                cmd.Parameters.AddWithValue("@nominal", nominal);
                cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.Date);
                cmd.Parameters.AddWithValue("@ket", txtKeterangan.Text);
                cmd.Parameters.AddWithValue("@id", idTerpilih);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Data berhasil diubah!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TampilData();
            BersihkanForm();
        }

        // ================= HAPUS (DELETE) =================
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idTerpilih == "")
            {
                MessageBox.Show("Pilih data di tabel dulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult hasil = MessageBox.Show("Yakin mau hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (hasil == DialogResult.Yes)
            {
                using (SqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM donasi WHERE id_donasi=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", idTerpilih);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data berhasil dihapus!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
                BersihkanForm();
            }
        }

        // ================= LOGOUT =================
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show("Yakin mau logout?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (hasil == DialogResult.Yes)
            {
                Login.namaUser = "";
                Login formLogin = new Login();
                formLogin.Show();
                this.Close();
            }
        }
    }
}