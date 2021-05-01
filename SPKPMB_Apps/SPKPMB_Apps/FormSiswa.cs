using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SPKPMB_Apps
{
    public partial class FormSiswa : Form
    {
        public FormSiswa()
        {
            InitializeComponent();
        }

        private void FormClear()
        {
            txt_nama.Clear();
            txt_alamat.Clear();
            txt_telp.Clear();
            txt_ttl.Clear();
            txt_ortu.Clear();
            cb_agama.Items.Clear();
            txt_sekolah.Clear();

        }

        private void FormNonaktif()
        {
            txt_nama.Enabled = false;
            txt_alamat.Enabled = false;
            txt_telp.Enabled = false;
            txt_ttl.Enabled = false;
            txt_ortu.Enabled = false;
            cb_agama.Enabled = false;
            txt_sekolah.Enabled = false;
        }
        private void FormAktif()
        {
            txt_nama.Enabled = true;
            txt_alamat.Enabled = true;
            txt_telp.Enabled = true;
            txt_ttl.Enabled = true;
            txt_ortu.Enabled = true;
            cb_agama.Enabled = true;
            txt_sekolah.Enabled = true;
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormSiswa_Load(object sender, EventArgs e)
        {
            FormNonaktif();
            Display();
            this.tbSiswaTableAdapter.Fill(this.db_PMBDataSet.tbSiswa);

        }

        private void Display()
        {
            Koneksi.Connect.Open();
            DataSet dsPegawai = new DataSet();
            SqlDataAdapter sqlda = new SqlDataAdapter("Select * from tbSiswa", Koneksi.Connect);
            sqlda.SelectCommand.Parameters.AddWithValue("@NamaLengkap", txt_nama.Text);
            sqlda.SelectCommand.ExecuteNonQuery();
            sqlda.Fill(dsPegawai, "tbSiswa");
            dg_siswa.DataSource = dsPegawai.Tables["tbSiswa"];
            Koneksi.Connect.Close();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.Conn.Open();
                SqlCommand sqlInsert = new SqlCommand("INSERT INTO tbSiswa values(@NamaLengkap, @Alamat, @Telp, @TTL, @NamaOrangTua, @Agama, @AsalSekolah)", Koneksi.Conn);
                //sqlInsert.Parameters.AddWithValue("@IDPegawai", txt_idpegawai.Text);
                sqlInsert.Parameters.AddWithValue("@NamaLengkap", txt_nama.Text);
                sqlInsert.Parameters.AddWithValue("@Alamat", txt_alamat.Text);
                sqlInsert.Parameters.AddWithValue("@Telp", txt_telp.Text);
                sqlInsert.Parameters.AddWithValue("@TTL", txt_ttl.Text);
                sqlInsert.Parameters.AddWithValue("@NamaOrangTua", txt_ortu.Text);
                sqlInsert.Parameters.AddWithValue("@Agama", cb_agama.Text);
                sqlInsert.Parameters.AddWithValue("@AsalSekolah", txt_sekolah.Text);
                sqlInsert.ExecuteNonQuery();
                //DisplayPegawai();
                Display();
                FormNonaktif();
                btn_simpan.Enabled = false;
                btn_simpan.BackColor = Color.Red;
                btn_tambah.Enabled = true;
                btn_tambah.BackColor = Color.CornflowerBlue;
                FormClear();
                FormNonaktif();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                Koneksi.Conn.Close();

            }
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            FormAktif();
            btn_simpan.Enabled = true;
            txt_nama.Focus();
            btn_tambah.Enabled = false;
            btn_tambah.BackColor = Color.Red;
            btn_simpan.Text = "&SIMPAN";
            btn_simpan.BackColor = Color.CornflowerBlue;
            btn_hapus.Enabled = false;
            btn_hapus.BackColor = Color.Red;
            btn_keluar.Text = "&BATAL";
        }
    }
}
