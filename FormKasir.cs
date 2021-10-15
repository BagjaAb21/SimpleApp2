using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleApp2
{
    public partial class FormKasir : Form
    {
        public FormKasir()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            int row = 0, subtotal = 0;
            dgvBarang.Rows.Add();
            row = dgvBarang.Rows.Count - 2;

            dgvBarang[0, row].Value = dgvBarang.Rows.Count - 1;
            dgvBarang[1, row].Value = tboxNamabrg.Text;
            dgvBarang[2, row].Value = tboxHargabrg.Text;
            dgvBarang[3, row].Value = tboxJumlah.Text;

            subtotal = (int)(long.Parse(tboxHargabrg.Text) * long.Parse(tboxJumlah.Text));
            dgvBarang[4, row].Value = subtotal;

            tboxTotal.Text = (long.Parse(tboxTotal.Text) + subtotal).ToString(); 

            tboxNamabrg.Text = "";
            tboxHargabrg.Text = "";
            tboxJumlah.Text = "";
            tboxNamabrg.Focus();
        }

        private void tboxBayar_TextChanged(object sender, EventArgs e)
        {
            if (tboxBayar.Text != "")
            {
                long kembali = long.Parse(tboxBayar.Text) - long.Parse(tboxTotal.Text);
                tboxKembalian.Text = kembali.ToString();
            }
        }

        private void tboxBayar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (long.Parse(tboxKembalian.Text) >= 0)
                {
                    MessageBox.Show("Kembali : " + tboxKembalian.Text + "\n" +
                                    "Terimakasih banyak");
                    dgvBarang.Rows.Clear();
                    tboxTotal.Text = "0";
                    tboxBayar.Text = "0";
                    tboxKembalian.Text = "0";
                    tboxNamabrg.Focus();
                }
                else
                {
                    MessageBox.Show("Maaf uang yang anda kurang gaes");
                    tboxBayar.Focus();
                    tboxBayar.SelectAll();
                }
            }
        }
    }
}
