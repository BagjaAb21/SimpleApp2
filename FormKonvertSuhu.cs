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
    public partial class FormKonvertSuhu : Form
    {
        public FormKonvertSuhu()
        {
            InitializeComponent();
        }

        private void FormKonversiSuhu_Load(object sender, EventArgs e)
        {
            tboxNilai.Clear();
        }

        private void btn_proses_Click(object sender, EventArgs e)
        {
            double a, c;
            if (rdbCtoF.Checked)
            {
                a = Convert.ToDouble(tboxNilai.Text);
                c = a * 1.8 + 32;
                labelsuhu.Text = Convert.ToString(c);
            }
            else if (rdbFtoC.Checked)
            {
                a = Convert.ToDouble(tboxNilai.Text);
                c = (a - 32) / 1.8;
                labelsuhu.Text = Convert.ToString(c);
            }
            else if (rdbCtoK.Checked)
            {
                a = Convert.ToDouble(tboxNilai.Text);
                c = a + 273.15;
                labelsuhu.Text = Convert.ToString(c);
            }
            else
            {
                a = Convert.ToDouble(tboxNilai.Text);
                c = a - 273.15;
                labelsuhu.Text = Convert.ToString(c);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            tboxNilai.Clear();
        }
    }
}
