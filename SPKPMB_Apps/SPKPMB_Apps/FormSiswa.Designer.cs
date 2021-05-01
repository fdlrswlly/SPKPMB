namespace SPKPMB_Apps
{
    partial class FormSiswa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_sekolah = new System.Windows.Forms.TextBox();
            this.cb_agama = new System.Windows.Forms.ComboBox();
            this.txt_ortu = new System.Windows.Forms.TextBox();
            this.txt_ttl = new System.Windows.Forms.TextBox();
            this.txt_telp = new System.Windows.Forms.TextBox();
            this.txt_alamat = new System.Windows.Forms.RichTextBox();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_keluar = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.dg_siswa = new System.Windows.Forms.DataGridView();
            this.db_PMBDataSet = new SPKPMB_Apps.db_PMBDataSet();
            this.tbSiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbSiswaTableAdapter = new SPKPMB_Apps.db_PMBDataSetTableAdapters.tbSiswaTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_siswa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_PMBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSiswaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA SISWA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_sekolah);
            this.groupBox1.Controls.Add(this.cb_agama);
            this.groupBox1.Controls.Add(this.txt_ortu);
            this.groupBox1.Controls.Add(this.txt_ttl);
            this.groupBox1.Controls.Add(this.txt_telp);
            this.groupBox1.Controls.Add(this.txt_alamat);
            this.groupBox1.Controls.Add(this.txt_nama);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 210);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data Siswa";
            // 
            // txt_sekolah
            // 
            this.txt_sekolah.Location = new System.Drawing.Point(376, 88);
            this.txt_sekolah.Name = "txt_sekolah";
            this.txt_sekolah.Size = new System.Drawing.Size(140, 20);
            this.txt_sekolah.TabIndex = 14;
            // 
            // cb_agama
            // 
            this.cb_agama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_agama.FormattingEnabled = true;
            this.cb_agama.Items.AddRange(new object[] {
            "Islam",
            "Kristen",
            "Hindu",
            "Budha",
            "Konghucu"});
            this.cb_agama.Location = new System.Drawing.Point(376, 55);
            this.cb_agama.Name = "cb_agama";
            this.cb_agama.Size = new System.Drawing.Size(133, 21);
            this.cb_agama.TabIndex = 13;
            // 
            // txt_ortu
            // 
            this.txt_ortu.Location = new System.Drawing.Point(376, 25);
            this.txt_ortu.Name = "txt_ortu";
            this.txt_ortu.Size = new System.Drawing.Size(169, 20);
            this.txt_ortu.TabIndex = 12;
            // 
            // txt_ttl
            // 
            this.txt_ttl.Location = new System.Drawing.Point(102, 155);
            this.txt_ttl.Name = "txt_ttl";
            this.txt_ttl.Size = new System.Drawing.Size(161, 20);
            this.txt_ttl.TabIndex = 11;
            // 
            // txt_telp
            // 
            this.txt_telp.Location = new System.Drawing.Point(102, 126);
            this.txt_telp.Name = "txt_telp";
            this.txt_telp.Size = new System.Drawing.Size(162, 20);
            this.txt_telp.TabIndex = 10;
            // 
            // txt_alamat
            // 
            this.txt_alamat.Location = new System.Drawing.Point(102, 55);
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.Size = new System.Drawing.Size(165, 53);
            this.txt_alamat.TabIndex = 9;
            this.txt_alamat.Text = "";
            this.txt_alamat.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(102, 25);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(162, 20);
            this.txt_nama.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Asal Sekolah";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Agama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nama Orang Tua";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "TTL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nama Lengkap";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_keluar);
            this.groupBox2.Controls.Add(this.btn_hapus);
            this.groupBox2.Controls.Add(this.btn_tambah);
            this.groupBox2.Controls.Add(this.btn_simpan);
            this.groupBox2.Location = new System.Drawing.Point(12, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 67);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btn_keluar
            // 
            this.btn_keluar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_keluar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_keluar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_keluar.Location = new System.Drawing.Point(286, 19);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(98, 36);
            this.btn_keluar.TabIndex = 3;
            this.btn_keluar.Text = "KELUAR";
            this.btn_keluar.UseVisualStyleBackColor = false;
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_hapus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_hapus.Location = new System.Drawing.Point(200, 19);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(84, 36);
            this.btn_hapus.TabIndex = 2;
            this.btn_hapus.Text = "HAPUS";
            this.btn_hapus.UseVisualStyleBackColor = false;
            // 
            // btn_tambah
            // 
            this.btn_tambah.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_tambah.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tambah.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_tambah.Location = new System.Drawing.Point(104, 19);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(93, 36);
            this.btn_tambah.TabIndex = 1;
            this.btn_tambah.Text = "TAMBAH";
            this.btn_tambah.UseVisualStyleBackColor = false;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_simpan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_simpan.Location = new System.Drawing.Point(14, 19);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(84, 36);
            this.btn_simpan.TabIndex = 0;
            this.btn_simpan.Text = "SIMPAN";
            this.btn_simpan.UseVisualStyleBackColor = false;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // dg_siswa
            // 
            this.dg_siswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_siswa.Location = new System.Drawing.Point(16, 386);
            this.dg_siswa.Name = "dg_siswa";
            this.dg_siswa.Size = new System.Drawing.Size(596, 186);
            this.dg_siswa.TabIndex = 3;
            // 
            // db_PMBDataSet
            // 
            this.db_PMBDataSet.DataSetName = "db_PMBDataSet";
            this.db_PMBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbSiswaBindingSource
            // 
            this.tbSiswaBindingSource.DataMember = "tbSiswa";
            this.tbSiswaBindingSource.DataSource = this.db_PMBDataSet;
            // 
            // tbSiswaTableAdapter
            // 
            this.tbSiswaTableAdapter.ClearBeforeFill = true;
            // 
            // FormSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 584);
            this.Controls.Add(this.dg_siswa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormSiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siswa";
            this.Load += new System.EventHandler(this.FormSiswa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_siswa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_PMBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSiswaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txt_alamat;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_sekolah;
        private System.Windows.Forms.ComboBox cb_agama;
        private System.Windows.Forms.TextBox txt_ortu;
        private System.Windows.Forms.TextBox txt_ttl;
        private System.Windows.Forms.TextBox txt_telp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_keluar;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.DataGridView dg_siswa;
        private db_PMBDataSet db_PMBDataSet;
        private System.Windows.Forms.BindingSource tbSiswaBindingSource;
        private db_PMBDataSetTableAdapters.tbSiswaTableAdapter tbSiswaTableAdapter;
    }
}