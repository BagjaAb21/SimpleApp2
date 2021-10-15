
using System;

namespace SimpleApp2
{
    partial class FormBeliBuku
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxSaran = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cekboxBuku = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbBayar = new System.Windows.Forms.GroupBox();
            this.rdbTunai = new System.Windows.Forms.RadioButton();
            this.rdbCicil = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBayar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbBayar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toko Buku Abdul";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Saran dan Masukan Anda";
            // 
            // tboxSaran
            // 
            this.tboxSaran.Location = new System.Drawing.Point(12, 341);
            this.tboxSaran.Multiline = true;
            this.tboxSaran.Name = "tboxSaran";
            this.tboxSaran.Size = new System.Drawing.Size(500, 134);
            this.tboxSaran.TabIndex = 12;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(526, 435);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 40);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cekboxBuku);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 233);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menyediakan Buku";
            // 
            // cekboxBuku
            // 
            this.cekboxBuku.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cekboxBuku.ForeColor = System.Drawing.Color.Black;
            this.cekboxBuku.FormattingEnabled = true;
            this.cekboxBuku.Items.AddRange(new object[] {
            "Programming C#",
            "Basic Programming Java",
            "SQL Server For Store Apps",
            "SEO E-Commerce"});
            this.cekboxBuku.Location = new System.Drawing.Point(9, 34);
            this.cekboxBuku.Name = "cekboxBuku";
            this.cekboxBuku.Size = new System.Drawing.Size(271, 89);
            this.cekboxBuku.TabIndex = 3;
            this.cekboxBuku.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cekboxBuku_ItemCheck);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Menyediakan Berbagai Buku";
            // 
            // gbBayar
            // 
            this.gbBayar.Controls.Add(this.label3);
            this.gbBayar.Controls.Add(this.rdbCicil);
            this.gbBayar.Controls.Add(this.rdbTunai);
            this.gbBayar.Enabled = false;
            this.gbBayar.Location = new System.Drawing.Point(399, 93);
            this.gbBayar.Name = "gbBayar";
            this.gbBayar.Size = new System.Drawing.Size(284, 174);
            this.gbBayar.TabIndex = 15;
            this.gbBayar.TabStop = false;
            this.gbBayar.Text = "Cara Pembayaran";
            // 
            // rdbTunai
            // 
            this.rdbTunai.AutoSize = true;
            this.rdbTunai.Location = new System.Drawing.Point(24, 37);
            this.rdbTunai.Name = "rdbTunai";
            this.rdbTunai.Size = new System.Drawing.Size(109, 21);
            this.rdbTunai.TabIndex = 0;
            this.rdbTunai.TabStop = true;
            this.rdbTunai.Text = "Tunai / Cash";
            this.rdbTunai.UseVisualStyleBackColor = true;
            // 
            // rdbCicil
            // 
            this.rdbCicil.AutoSize = true;
            this.rdbCicil.Location = new System.Drawing.Point(24, 74);
            this.rdbCicil.Name = "rdbCicil";
            this.rdbCicil.Size = new System.Drawing.Size(103, 21);
            this.rdbCicil.TabIndex = 0;
            this.rdbCicil.TabStop = true;
            this.rdbCicil.Text = "Cicil / Kredit";
            this.rdbCicil.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Silahkan pilih metode pembayaran anda";
            // 
            // btnBayar
            // 
            this.btnBayar.Enabled = false;
            this.btnBayar.Location = new System.Drawing.Point(399, 273);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(284, 41);
            this.btnBayar.TabIndex = 16;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = true;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click_1);
            // 
            // FormBeliBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(695, 515);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.gbBayar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tboxSaran);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FormBeliBuku";
            this.Text = "FormBeliBuku";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbBayar.ResumeLayout(false);
            this.gbBayar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
       //     throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxSaran;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox cekboxBuku;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbBayar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbCicil;
        private System.Windows.Forms.RadioButton rdbTunai;
        private System.Windows.Forms.Button btnBayar;
    }
}