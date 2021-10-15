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
    public partial class FormKalkulatorr : Form
    {
        public FormKalkulatorr()
        {
            InitializeComponent();
        }

        private void FormKalkulatorr_Load(object sender, EventArgs e)
        {
            tboxNilai1.Clear();
            tboxNilai2.Clear();
            tboxHasil.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tboxNilai1.Text) || string.IsNullOrEmpty(tboxNilai2.Text))
            {
                MessageBox.Show("Nilai 1 dan Nilai 2 harus di isi !!!");
            }
            else
            {
                int a, b, c;
                a = int.Parse(this.tboxNilai1.Text);
                b = int.Parse(this.tboxNilai2.Text);
                c = a + b;
                this.tboxHasil.Text = c.ToString();
            }     
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tboxNilai1.Text) || string.IsNullOrEmpty(tboxNilai2.Text))
            {
                MessageBox.Show("Nilai 1 dan Nilai 2 harus di isi !!!");
            }
            else
            {
                int a, b, c;
                a = int.Parse(this.tboxNilai1.Text);
                b = int.Parse(this.tboxNilai2.Text);
                c = a * b;
                this.tboxHasil.Text = c.ToString();
            }
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tboxNilai1.Text) || string.IsNullOrEmpty(tboxNilai2.Text))
            {
                MessageBox.Show("Nilai 1 dan Nilai 2 harus di isi !!!");
            }
            else
            {
                int a, b, c;
                a = int.Parse(this.tboxNilai1.Text);
                b = int.Parse(this.tboxNilai2.Text);
                c = a - b;
                this.tboxHasil.Text = c.ToString();
            }
        }

        private void btnBagi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tboxNilai1.Text) || string.IsNullOrEmpty(tboxNilai2.Text))
            {
                MessageBox.Show("Nilai 1 dan Nilai 2 harus di isi !!!");
            }
            else
            {
                int a, b, c;
                a = int.Parse(this.tboxNilai1.Text);
                b = int.Parse(this.tboxNilai2.Text);
                c = a / b;
                this.tboxHasil.Text = c.ToString();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            tboxNilai1.Clear();
            tboxNilai2.Clear();
            tboxHasil.Clear();
        }
    }
}