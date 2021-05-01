namespace SPKPMB_Apps
{
    partial class FormTest
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_PMBDataSet = new SPKPMB_Apps.db_PMBDataSet();
            this.dbPMBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbSiswaTableAdapter = new SPKPMB_Apps.db_PMBDataSetTableAdapters.tbSiswaTableAdapter();
            this.cbKriteria = new System.Windows.Forms.ComboBox();
            this.tbKriteriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbKriteriaTableAdapter = new SPKPMB_Apps.db_PMBDataSetTableAdapters.tbKriteriaTableAdapter();
            this.txt_nilai = new System.Windows.Forms.TextBox();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.dgTest = new System.Windows.Forms.DataGridView();
            this.btn_keluar = new System.Windows.Forms.Button();
            this.cbIdMahasiswa = new System.Windows.Forms.ComboBox();
            this.tbSiswaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dg_seleksi = new System.Windows.Forms.DataGridView();
            this.btn_pilih = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbSiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_PMBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPMBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKriteriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSiswaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_seleksi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Mahasiswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Kriteria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nilai";
            // 
            // tbSiswaBindingSource
            // 
            this.tbSiswaBindingSource.DataMember = "tbSiswa";
            this.tbSiswaBindingSource.DataSource = this.db_PMBDataSet;
            // 
            // db_PMBDataSet
            // 
            this.db_PMBDataSet.DataSetName = "db_PMBDataSet";
            this.db_PMBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbPMBDataSetBindingSource
            // 
            this.dbPMBDataSetBindingSource.DataSource = this.db_PMBDataSet;
            this.dbPMBDataSetBindingSource.Position = 0;
            // 
            // tbSiswaTableAdapter
            // 
            this.tbSiswaTableAdapter.ClearBeforeFill = true;
            // 
            // cbKriteria
            // 
            this.cbKriteria.DataSource = this.tbKriteriaBindingSource;
            this.cbKriteria.DisplayMember = "NamaKriteria";
            this.cbKriteria.FormattingEnabled = true;
            this.cbKriteria.Location = new System.Drawing.Point(128, 85);
            this.cbKriteria.Name = "cbKriteria";
            this.cbKriteria.Size = new System.Drawing.Size(130, 21);
            this.cbKriteria.TabIndex = 4;
            this.cbKriteria.ValueMember = "IDKriteria";
            // 
            // tbKriteriaBindingSource
            // 
            this.tbKriteriaBindingSource.DataMember = "tbKriteria";
            this.tbKriteriaBindingSource.DataSource = this.dbPMBDataSetBindingSource;
            // 
            // tbKriteriaTableAdapter
            // 
            this.tbKriteriaTableAdapter.ClearBeforeFill = true;
            // 
            // txt_nilai
            // 
            this.txt_nilai.Location = new System.Drawing.Point(128, 138);
            this.txt_nilai.Name = "txt_nilai";
            this.txt_nilai.Size = new System.Drawing.Size(129, 20);
            this.txt_nilai.TabIndex = 5;
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(40, 196);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(101, 38);
            this.btn_simpan.TabIndex = 6;
            this.btn_simpan.Text = "SIMPAN";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // dgTest
            // 
            this.dgTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTest.Location = new System.Drawing.Point(368, 35);
            this.dgTest.Name = "dgTest";
            this.dgTest.Size = new System.Drawing.Size(405, 183);
            this.dgTest.TabIndex = 7;
            // 
            // btn_keluar
            // 
            this.btn_keluar.Location = new System.Drawing.Point(220, 196);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(101, 38);
            this.btn_keluar.TabIndex = 8;
            this.btn_keluar.Text = "KELUAR";
            this.btn_keluar.UseVisualStyleBackColor = true;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // cbIdMahasiswa
            // 
            this.cbIdMahasiswa.DataSource = this.tbSiswaBindingSource1;
            this.cbIdMahasiswa.DisplayMember = "NamaLengkap";
            this.cbIdMahasiswa.FormattingEnabled = true;
            this.cbIdMahasiswa.Location = new System.Drawing.Point(128, 33);
            this.cbIdMahasiswa.Name = "cbIdMahasiswa";
            this.cbIdMahasiswa.Size = new System.Drawing.Size(130, 21);
            this.cbIdMahasiswa.TabIndex = 9;
            this.cbIdMahasiswa.ValueMember = "ID";
            // 
            // tbSiswaBindingSource1
            // 
            this.tbSiswaBindingSource1.DataMember = "tbSiswa";
            this.tbSiswaBindingSource1.DataSource = this.db_PMBDataSet;
            // 
            // dg_seleksi
            // 
            this.dg_seleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_seleksi.Location = new System.Drawing.Point(372, 249);
            this.dg_seleksi.Name = "dg_seleksi";
            this.dg_seleksi.Size = new System.Drawing.Size(400, 133);
            this.dg_seleksi.TabIndex = 10;
            // 
            // btn_pilih
            // 
            this.btn_pilih.Location = new System.Drawing.Point(40, 249);
            this.btn_pilih.Name = "btn_pilih";
            this.btn_pilih.Size = new System.Drawing.Size(101, 38);
            this.btn_pilih.TabIndex = 11;
            this.btn_pilih.Text = "PILIH";
            this.btn_pilih.UseVisualStyleBackColor = true;
            this.btn_pilih.Click += new System.EventHandler(this.btn_pilih_Click);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 437);
            this.Controls.Add(this.btn_pilih);
            this.Controls.Add(this.dg_seleksi);
            this.Controls.Add(this.cbIdMahasiswa);
            this.Controls.Add(this.btn_keluar);
            this.Controls.Add(this.dgTest);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.txt_nilai);
            this.Controls.Add(this.cbKriteria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbSiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_PMBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPMBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKriteriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSiswaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_seleksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource dbPMBDataSetBindingSource;
        private db_PMBDataSet db_PMBDataSet;
        private System.Windows.Forms.BindingSource tbSiswaBindingSource;
        private db_PMBDataSetTableAdapters.tbSiswaTableAdapter tbSiswaTableAdapter;
        private System.Windows.Forms.ComboBox cbKriteria;
        private System.Windows.Forms.BindingSource tbKriteriaBindingSource;
        private db_PMBDataSetTableAdapters.tbKriteriaTableAdapter tbKriteriaTableAdapter;
        private System.Windows.Forms.TextBox txt_nilai;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.DataGridView dgTest;
        private System.Windows.Forms.Button btn_keluar;
        private System.Windows.Forms.ComboBox cbIdMahasiswa;
        private System.Windows.Forms.BindingSource tbSiswaBindingSource1;
        private System.Windows.Forms.DataGridView dg_seleksi;
        private System.Windows.Forms.Button btn_pilih;
    }
}