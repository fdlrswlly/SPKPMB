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
    public partial class FormPegawai : Form
    {
        public FormPegawai()
        {
            InitializeComponent();
        }
        private void FormNonaktif()
        {
            txt_namaPegawai.Enabled = false;
            txt_jabatan.Enabled = false;
            txt_username.Enabled = false;
            txt_password.Enabled = false;
            txt_divisi.Enabled = false;
        }
        private void FormAktif()
        {
            txt_namaPegawai.Enabled = true;
            txt_jabatan.Enabled = true;
            txt_username.Enabled = true;
            txt_password.Enabled = true;
            txt_divisi.Enabled = true;
        }
        private void FormClear()
        {
            txt_namaPegawai.Clear();
            txt_jabatan.Clear();
            txt_username.Clear();
            txt_password.Clear();
            txt_divisi.Clear();

        }
        private void Normal()
        {
            FormClear();
            FormNonaktif();
            btn_hapus.Enabled = true;
            btn_hapus.Text = "&HAPUS";
            btn_simpan.Text = "&SIMPAN";
            btn_simpan.Enabled = false;
            btn_simpan.BackColor = Color.Red;
            btn_hapus.BackColor = Color.Red;
            btn_keluar.Text = "&KELUAR";
        }
        private void DisplayPegawai()
        {
            DataSet dsPegawai = new DataSet();

            Koneksi.Connect.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("Select * from tbPegawai", Koneksi.Connect);
            sqlda.SelectCommand.ExecuteNonQuery();
            sqlda.Fill(dsPegawai,"tbPegawai");
            DG_Pegawai.DataSource = dsPegawai.Tables["tbPegawai"];
            Koneksi.Connect.Close();
        }
        private void Display()
        {
            Koneksi.Connect.Open();
            DataSet dsPegawai = new DataSet();
            SqlDataAdapter sqlda = new SqlDataAdapter("Select * from tbPegawai", Koneksi.Connect);
            sqlda.SelectCommand.Parameters.AddWithValue("@NamaPegawai", txt_namaPegawai.Text);
            sqlda.SelectCommand.ExecuteNonQuery();
            sqlda.Fill(dsPegawai,"tbPegawai");
            DG_Pegawai.DataSource = dsPegawai.Tables["tbPegawai"];
            Koneksi.Connect.Close();
        }
         
        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void btn_simpan_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.Conn.Open();
                SqlCommand sqlInsert = new SqlCommand("INSERT INTO tbPegawai values(@NamaPegawai, @jabatan, @username, @password, @divisi)", Koneksi.Conn);
                //sqlInsert.Parameters.AddWithValue("@IDPegawai", txt_idpegawai.Text);
                sqlInsert.Parameters.AddWithValue("@namapegawai", txt_namaPegawai.Text);
                sqlInsert.Parameters.AddWithValue("@jabatan", txt_jabatan.Text);
                sqlInsert.Parameters.AddWithValue("@username", txt_username.Text);
                sqlInsert.Parameters.AddWithValue("@password", txt_password.Text);
                sqlInsert.Parameters.AddWithValue("@divisi", txt_divisi.Text);
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

        private void FormPegawai_Load(object sender, EventArgs e)
        {
            FormNonaktif();
            Display();
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            if (btn_keluar.Text == "&KELUAR")
            {
                this.Close();
            }
            else
            {
                Normal();
                FormNonaktif();
                btn_tambah.Enabled = true;
                btn_tambah.BackColor = Color.CornflowerBlue;
                btn_hapus.Enabled = true;
                btn_hapus.BackColor = Color.CornflowerBlue;
            }
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            FormAktif();
            btn_simpan.Enabled = true;
            txt_namaPegawai.Focus();
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
 
    
