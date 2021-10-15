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
    public partial class FormBeliBuku : Form
    {
        public FormBeliBuku()
        {
            InitializeComponent();
        }

        private void cekboxBuku_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (cekboxBuku.CheckedItems.Count > 1)
            {
                btnBayar.Enabled = true;
                gbBayar.Enabled = true;
                return;

            }

            //Last Item is uncheked
            if (cekboxBuku.CheckedItems.Count == 1 && e.NewValue == CheckState.Unchecked)
            {
                btnBayar.Enabled = false;
                gbBayar.Enabled = false;
                return;
            }

            //First Item is checked
            if (cekboxBuku.CheckedItems.Count == 0 && e.NewValue == CheckState.Checked)
            {
                btnBayar.Enabled = true;
                gbBayar.Enabled = true;
                return;
            }
        }

        String CaraBayar()
        {
            if (rdbTunai.Checked) return rdbTunai.Text;
            else if (rdbCicil.Checked) return rdbCicil.Text;

            return "";
        }

        private void btnBayar_Click_1(object sender, EventArgs e)
        {
            int subtotal = 0;
            string namaBuku = "";
            int[] priceArray = new int[] { 65300, 42750, 50000, 85225 };

            for (int i = 0; i < cekboxBuku.Items.Count; i++)
            {
                if (cekboxBuku.GetItemChecked(i))
                {
                    string book = cekboxBuku.Items[i].ToString();

                    subtotal += priceArray[i];
                    namaBuku += $"\n\t{book}";
                }
            }

            MessageBox.Show($"You purchased: {namaBuku}" +
                $"\n\nThe total payment due is Rp{subtotal}" +
                $"\nThe selected mode of payment is : {CaraBayar()}" +
                $"\nYour comments about us are : {tboxSaran.Text}", "Order Summary");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        
    }
}
