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
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_PMBDataSet.tbKriteria' table. You can move, or remove it, as needed.
            this.tbKriteriaTableAdapter.Fill(this.db_PMBDataSet.tbKriteria);
            // TODO: This line of code loads data into the 'db_PMBDataSet.tbSiswa' table. You can move, or remove it, as needed.
            this.tbSiswaTableAdapter.Fill(this.db_PMBDataSet.tbSiswa);

            Display();

        }
        private void Display()
        {
            DataSet dsTest = new DataSet();

            Koneksi.Connect.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("Select * from tbTest", Koneksi.Connect);
            sqlda.SelectCommand.Parameters.AddWithValue("@ID", cbIdMahasiswa.SelectedValue.ToString());
            sqlda.SelectCommand.ExecuteNonQuery();
            sqlda.Fill(dsTest, "tbTest");
            dgTest.DataSource = dsTest.Tables["tbTest"];
            Koneksi.Connect.Close();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.Conn.Open();
                SqlCommand sqlInsert = new SqlCommand("INSERT INTO tbTest values(@ID, @IDKriteria, @Nilai)", Koneksi.Conn);
                sqlInsert.Parameters.AddWithValue("@ID", cbIdMahasiswa.SelectedValue.ToString());
                sqlInsert.Parameters.AddWithValue("@IDKriteria", cbKriteria.SelectedValue.ToString());
                sqlInsert.Parameters.AddWithValue("@Nilai", Convert.ToDouble(txt_nilai.Text));
                sqlInsert.ExecuteNonQuery();
                
                
                Display();
                
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

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_pilih_Click(object sender, EventArgs e)
        {
            DataSet dsTest = new DataSet();

            Koneksi.Connect.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("SELECT A.ID, A.NamaLengkap, AVG(NULLIF(B.NILAI,0)) AS NILAI FROM tbSiswa A INNER JOIN tbTest B ON A.ID = B.ID GROUP BY A.ID, A.NamaLengkap ORDER BY NILAI DESC", Koneksi.Connect);
            sqlda.SelectCommand.Parameters.AddWithValue("@ID", cbIdMahasiswa.SelectedValue.ToString());
            sqlda.SelectCommand.ExecuteNonQuery();
            sqlda.Fill(dsTest, "tbTest");
            dg_seleksi.DataSource = dsTest.Tables["tbTest"];
            Koneksi.Connect.Close();

        }

      
        }
    }

