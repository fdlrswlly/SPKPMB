using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPKPMB_Apps
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPegawai pegawai = new FormPegawai();
            pegawai.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTest test = new FormTest();
            test.Show();
        }

        private void mahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSiswa siswa = new FormSiswa();
            siswa.Show();
        }
    }
}
