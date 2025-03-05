using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_103022300109
{
    public partial class Form1 : Form
    {
        int jumlah1, jumlah2, hasil;
        bool tambahTotal = false;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!tambahTotal)
            {
                jumlah1 =  jumlah1 * 10 + 1;
            }
            else
            {
                jumlah2 = jumlah2 * 10 + 1;
            }
        }

        private void angka2_Click(object sender, EventArgs e)
        {
            if (!tambahTotal)
            {
                jumlah1 = jumlah1 * 10 + 2;
            }
            else
            {
                jumlah2 = jumlah2 * 10 + 2;
            }
        }

        private void angka3_Click(object sender, EventArgs e)
        {
            if (!tambahTotal)
            {
                jumlah1 = jumlah1 * 10 + 3;
            }
            else
            {
                jumlah2 = jumlah2 * 10 + 3;
            }
        }

        private void angka4_Click(object sender, EventArgs e)
        {
            if (!tambahTotal)
            {
                jumlah1 = jumlah1 * 10 + 4;
            }
            else
            {
                jumlah2 = jumlah2 * 10 + 4;
            }
        }

        private void angka5_Click(object sender, EventArgs e)
        {
            if (!tambahTotal)
            {
                jumlah1 = jumlah1 * 10 + 5;
            }
            else
            {
                jumlah2 = jumlah2 * 10 + 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!tambahTotal)
            {
                jumlah1 = jumlah1 * 10 + 6;
            }
            else
            {
                jumlah2 = jumlah2 * 10 + 6;
            }
        }

        private void angka7_Click(object sender, EventArgs e)
        {
            if (!tambahTotal)
            {
                jumlah1 = jumlah1 * 10 + 7;
            }
            else
            {
                jumlah2 = jumlah2 * 10 + 7;
            }
        }

        private void angka8_Click(object sender, EventArgs e)
        {
            if (!tambahTotal)
            {
                jumlah1 = jumlah1 * 10 + 8;
            }
            else
            {
                jumlah2 = jumlah2 * 10 + 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!tambahTotal)
            {
                jumlah1 = jumlah1 * 10 + 9;
            }
            else
            {
                jumlah2 = jumlah2 * 10 + 9;
            }
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            tambahTotal = true;
            hasilJumlah.Text = jumlah1 + " + " + jumlah2;
        }

        private void angka0_Click(object sender, EventArgs e)
        {
            if (!tambahTotal)
            {
                jumlah1 = jumlah1 * 10 + 0;
            }
            else
            {
                jumlah2 = jumlah2 * 10 + 0;
            }
        }

        private void hasilJumlah_Click(object sender, EventArgs e)
        {

        }

        private void samadengan_Click(object sender, EventArgs e)
        {
            hasil = jumlah1 + jumlah2;

            hasilJumlah.Text = "Hasil = " + hasil;
            jumlah1 = hasil;
            jumlah2 = 0;
        }
    }
}
