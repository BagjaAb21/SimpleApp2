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
    public partial class FormBiodata : Form
    {
        public FormBiodata()
        {
            InitializeComponent();
        }

        void addProdi()
        {

            cmbProdi.Items.Clear();
            if (cmbFakultas.SelectedItem.ToString() == "Ilmu Komputer")
            {
                cmbProdi.Items.Add("D3 Teknik Informatika");
                cmbProdi.Items.Add("D3 Manajemen Informatika");
                cmbProdi.Items.Add("S1 Informatika");
                cmbProdi.Items.Add("S1 Teknik Komputer");
                cmbProdi.Items.Add("S1 Sistem Informasi");
                cmbProdi.Items.Add("S1 Teknologi Informasi");
            }
            else if (cmbFakultas.SelectedItem.ToString() == "Ekonomi dan Sosial")
            {
                cmbProdi.Items.Add("S1 Akuntansi");
                cmbProdi.Items.Add("S1 Ilmu Komunikasi");
                cmbProdi.Items.Add("S1 Ekonomi");
                cmbProdi.Items.Add("S1 Hubungan Internasional");
                cmbProdi.Items.Add("S1 Ilmu Pemerintahan");
                cmbProdi.Items.Add("S1 Kewirausahaan");
            }
            else if (cmbFakultas.SelectedItem.ToString() == "Sains dan Teknologi")
            {
                cmbProdi.Items.Add("S1 Arsitektur");
                cmbProdi.Items.Add("S1 Geografi");
                cmbProdi.Items.Add("S1 Perencanaan Wilayah dan Kota");
            }
            else
            {
                cmbProdi.Items.Add(" ");
            }
        }

        private void cmbFakultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //call function
            addProdi();
        }

        String Favorit()
        {
            String matkul = "";
            if (checkBox1.Checked)
            {
                matkul = matkul + " " + checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                matkul = matkul + " " + checkBox2.Text;
            }
            if (checkBox3.Checked)
            {
                matkul = matkul + " " + checkBox3.Text;
            }
            if (checkBox4.Checked)
            {
                matkul = matkul + " " + checkBox4.Text;
            }
            if (checkBox5.Checked)
            {
                matkul = matkul + " " + checkBox5.Text;
            }
            if (checkBox6.Checked)
            {
                matkul = matkul + " " + checkBox6.Text;
            }
            if (checkBox7.Checked)
            {
                matkul = matkul + " " + checkBox7.Text;
            }
            if (checkBox8.Checked)
            {
                matkul = matkul + " " + checkBox8.Text;
            }
            if (checkBox9.Checked)
            {
                matkul = matkul + " " + checkBox9.Text;
            }
            if (checkBox10.Checked)
            {
                matkul = matkul + " " + checkBox10.Text;
            }
            return matkul;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            String jk = "";
            if (rdb_laki.Checked)
            {
                jk = rdb_laki.Text;
            }
            else
            {
                jk = rdb_prp.Text;
            }

            labelNim.Text = masktboxNim.Text;
            labelNama.Text = tboxNama.Text;
            labelJk.Text = jk;
            labelTtl.Text = dtpTanggalLahir.Text;
            labelFakultas.Text = cmbFakultas.SelectedItem.ToString();
            labelProdi.Text = cmbProdi.SelectedItem.ToString();
            labelSemester.Text = numericSemester.Value.ToString();
            tboxFavmatkul.Text = Favorit();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
