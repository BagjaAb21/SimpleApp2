
using System;
using System.Windows.Forms;

namespace SimpleApp2
{
    partial class FormKasir
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.tboxNamabrg = new System.Windows.Forms.TextBox();
            this.tboxHargabrg = new System.Windows.Forms.TextBox();
            this.tboxJumlah = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxTotal = new System.Windows.Forms.TextBox();
            this.tboxBayar = new System.Windows.Forms.TextBox();
            this.tboxKembalian = new System.Windows.Forms.TextBox();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUPERMARKET BAGJA JAYA ABADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Harga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Jumlah";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(623, 101);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 42);
            this.btn_Ok.TabIndex = 2;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // dgvBarang
            // 
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.nama,
            this.harga,
            this.jumlah,
            this.subtotal});
            this.dgvBarang.Location = new System.Drawing.Point(19, 149);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.RowHeadersWidth = 51;
            this.dgvBarang.RowTemplate.Height = 24;
            this.dgvBarang.Size = new System.Drawing.Size(679, 283);
            this.dgvBarang.TabIndex = 3;
            this.dgvBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarang_CellContentClick);
            // 
            // tboxNamabrg
            // 
            this.tboxNamabrg.Location = new System.Drawing.Point(19, 121);
            this.tboxNamabrg.Name = "tboxNamabrg";
            this.tboxNamabrg.Size = new System.Drawing.Size(196, 22);
            this.tboxNamabrg.TabIndex = 4;
            // 
            // tboxHargabrg
            // 
            this.tboxHargabrg.Location = new System.Drawing.Point(266, 121);
            this.tboxHargabrg.Name = "tboxHargabrg";
            this.tboxHargabrg.Size = new System.Drawing.Size(152, 22);
            this.tboxHargabrg.TabIndex = 4;
            // 
            // tboxJumlah
            // 
            this.tboxJumlah.Location = new System.Drawing.Point(451, 121);
            this.tboxJumlah.Name = "tboxJumlah";
            this.tboxJumlah.Size = new System.Drawing.Size(152, 22);
            this.tboxJumlah.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bayar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 532);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Kembali";
            // 
            // tboxTotal
            // 
            this.tboxTotal.Enabled = false;
            this.tboxTotal.Location = new System.Drawing.Point(533, 449);
            this.tboxTotal.Name = "tboxTotal";
            this.tboxTotal.Size = new System.Drawing.Size(165, 22);
            this.tboxTotal.TabIndex = 6;
            this.tboxTotal.Text = "0";
            this.tboxTotal.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tboxBayar
            // 
            this.tboxBayar.Location = new System.Drawing.Point(533, 485);
            this.tboxBayar.Name = "tboxBayar";
            this.tboxBayar.Size = new System.Drawing.Size(165, 22);
            this.tboxBayar.TabIndex = 6;
            this.tboxBayar.TextChanged += new System.EventHandler(this.tboxBayar_TextChanged);
            this.tboxBayar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxBayar_KeyDown);
            // 
            // tboxKembalian
            // 
            this.tboxKembalian.Enabled = false;
            this.tboxKembalian.Location = new System.Drawing.Point(535, 527);
            this.tboxKembalian.Name = "tboxKembalian";
            this.tboxKembalian.Size = new System.Drawing.Size(165, 22);
            this.tboxKembalian.TabIndex = 6;
            this.tboxKembalian.Text = "0";
            // 
            // no
            // 
            this.no.HeaderText = "No";
            this.no.MinimumWidth = 6;
            this.no.Name = "no";
            this.no.Width = 10;
            // 
            // nama
            // 
            this.nama.HeaderText = "Nama Barang";
            this.nama.MinimumWidth = 6;
            this.nama.Name = "nama";
            this.nama.Width = 200;
            // 
            // harga
            // 
            this.harga.HeaderText = "Harga";
            this.harga.MinimumWidth = 6;
            this.harga.Name = "harga";
            this.harga.Width = 90;
            // 
            // jumlah
            // 
            this.jumlah.HeaderText = "Jumlah";
            this.jumlah.MinimumWidth = 6;
            this.jumlah.Name = "jumlah";
            this.jumlah.Width = 60;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Sub Total";
            this.subtotal.MinimumWidth = 6;
            this.subtotal.Name = "subtotal";
            // 
            // FormKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 583);
            this.Controls.Add(this.tboxKembalian);
            this.Controls.Add(this.tboxBayar);
            this.Controls.Add(this.tboxTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tboxJumlah);
            this.Controls.Add(this.tboxHargabrg);
            this.Controls.Add(this.tboxNamabrg);
            this.Controls.Add(this.dgvBarang);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKasir";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void tboxBayar_KeyDown_1(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void dgvBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.DataGridView dgvBarang;
        private System.Windows.Forms.TextBox tboxNamabrg;
        private System.Windows.Forms.TextBox tboxHargabrg;
        private System.Windows.Forms.TextBox tboxJumlah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxTotal;
        private System.Windows.Forms.TextBox tboxBayar;
        private System.Windows.Forms.TextBox tboxKembalian;
        private DataGridViewTextBoxColumn no;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn harga;
        private DataGridViewTextBoxColumn jumlah;
        private DataGridViewTextBoxColumn subtotal;
    }
}

