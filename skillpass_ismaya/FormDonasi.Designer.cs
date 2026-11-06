namespace skillpass_ismaya
{
    partial class FormDonasi
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblNama, lblProgram, lblNominal, lblTanggal, lblKet, lblCari;
        private System.Windows.Forms.TextBox txtNamaDonatur, txtProgram, txtNominal, txtKeterangan, txtSearch;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Button btnSimpan, btnUbah, btnHapus, btnBatal, btnLogout;
        private System.Windows.Forms.DataGridView dgvDonasi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNamaDonatur = new System.Windows.Forms.TextBox();
            this.lblProgram = new System.Windows.Forms.Label();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.lblNominal = new System.Windows.Forms.Label();
            this.txtNominal = new System.Windows.Forms.TextBox();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.lblKet = new System.Windows.Forms.Label();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblCari = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvDonasi = new System.Windows.Forms.DataGridView();
            this.SuspendLayout();

            // lblWelcome
            this.lblWelcome.Text = "Selamat Datang, ...";
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(20, 15);
            this.lblWelcome.Size = new System.Drawing.Size(600, 25);

            // lblNama
            this.lblNama.Text = "Nama Donatur";
            this.lblNama.Location = new System.Drawing.Point(20, 60);
            this.lblNama.Size = new System.Drawing.Size(100, 25);

            // txtNamaDonatur
            this.txtNamaDonatur.Location = new System.Drawing.Point(130, 58);
            this.txtNamaDonatur.Size = new System.Drawing.Size(200, 25);

            // lblProgram
            this.lblProgram.Text = "Program";
            this.lblProgram.Location = new System.Drawing.Point(20, 95);
            this.lblProgram.Size = new System.Drawing.Size(100, 25);

            // txtProgram
            this.txtProgram.Location = new System.Drawing.Point(130, 93);
            this.txtProgram.Size = new System.Drawing.Size(200, 25);

            // lblNominal
            this.lblNominal.Text = "Nominal";
            this.lblNominal.Location = new System.Drawing.Point(20, 130);
            this.lblNominal.Size = new System.Drawing.Size(100, 25);

            // txtNominal
            this.txtNominal.Location = new System.Drawing.Point(130, 128);
            this.txtNominal.Size = new System.Drawing.Size(200, 25);

            // lblTanggal
            this.lblTanggal.Text = "Tanggal";
            this.lblTanggal.Location = new System.Drawing.Point(20, 165);
            this.lblTanggal.Size = new System.Drawing.Size(100, 25);

            // dtpTanggal
            this.dtpTanggal.Location = new System.Drawing.Point(130, 163);
            this.dtpTanggal.Size = new System.Drawing.Size(200, 25);
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // lblKet
            this.lblKet.Text = "Keterangan";
            this.lblKet.Location = new System.Drawing.Point(20, 200);
            this.lblKet.Size = new System.Drawing.Size(100, 25);

            // txtKeterangan
            this.txtKeterangan.Location = new System.Drawing.Point(130, 198);
            this.txtKeterangan.Size = new System.Drawing.Size(200, 60);
            this.txtKeterangan.Multiline = true;

            // btnSimpan
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.Location = new System.Drawing.Point(360, 58);
            this.btnSimpan.Size = new System.Drawing.Size(90, 35);
            this.btnSimpan.BackColor = System.Drawing.Color.LightGreen;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);

            // btnUbah
            this.btnUbah.Text = "UBAH";
            this.btnUbah.Location = new System.Drawing.Point(360, 100);
            this.btnUbah.Size = new System.Drawing.Size(90, 35);
            this.btnUbah.BackColor = System.Drawing.Color.LightYellow;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);

            // btnHapus
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.Location = new System.Drawing.Point(360, 142);
            this.btnHapus.Size = new System.Drawing.Size(90, 35);
            this.btnHapus.BackColor = System.Drawing.Color.LightCoral;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);

            // btnBatal
            this.btnBatal.Text = "BATAL";
            this.btnBatal.Location = new System.Drawing.Point(360, 184);
            this.btnBatal.Size = new System.Drawing.Size(90, 35);
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);

            // btnLogout
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.Location = new System.Drawing.Point(700, 15);
            this.btnLogout.Size = new System.Drawing.Size(90, 30);
            this.btnLogout.BackColor = System.Drawing.Color.Salmon;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // lblCari
            this.lblCari.Text = "Cari Data :";
            this.lblCari.Location = new System.Drawing.Point(480, 60);
            this.lblCari.Size = new System.Drawing.Size(80, 25);

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(560, 58);
            this.txtSearch.Size = new System.Drawing.Size(230, 25);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            // dgvDonasi
            this.dgvDonasi.Location = new System.Drawing.Point(20, 280);
            this.dgvDonasi.Size = new System.Drawing.Size(780, 250);
            this.dgvDonasi.AllowUserToAddRows = false;
            this.dgvDonasi.ReadOnly = true;
            this.dgvDonasi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonasi_CellClick);

            // FormDonasi
            this.ClientSize = new System.Drawing.Size(820, 550);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.txtNamaDonatur);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.txtProgram);
            this.Controls.Add(this.lblNominal);
            this.Controls.Add(this.txtNominal);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.lblKet);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblCari);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvDonasi);
            this.Text = "Form Donasi (CRUD)";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormDonasi_Load);
            this.ResumeLayout(false);
        }
    }
}