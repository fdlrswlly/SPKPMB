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
    public partial class FormLogin : Form
    {
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtpassword;
        private TextBox txtusername;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Button btn_keluar;
        private Button btn_login;
    
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_keluar = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.txtusername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(161, 48);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '●';
            this.txtpassword.Size = new System.Drawing.Size(178, 22);
            this.txtpassword.TabIndex = 2;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(161, 16);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(178, 20);
            this.txtusername.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "PASSWORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "USERNAME";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_keluar);
            this.groupBox2.Controls.Add(this.btn_login);
            this.groupBox2.Location = new System.Drawing.Point(36, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 58);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btn_keluar
            // 
            this.btn_keluar.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.btn_keluar.Location = new System.Drawing.Point(226, 15);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(109, 37);
            this.btn_keluar.TabIndex = 1;
            this.btn_keluar.Text = "KELUAR";
            this.btn_keluar.UseVisualStyleBackColor = true;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.btn_login.Location = new System.Drawing.Point(51, 15);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(109, 37);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // FormLogin
            // 
            this.ClientSize = new System.Drawing.Size(467, 339);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string msg = "Harap Masukkan Username dan Password!";
            string title = "Attention";
            if (txtusername.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusername.Focus();
            }
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            string q = "Apakah anda yakin ingin keluar ?";
            string title = "Konfirmasi";
            MessageBox.Show(q, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
