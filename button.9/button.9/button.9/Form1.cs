using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntopla_Click(object sender, EventArgs e)
        {
            int sayi1,sayi2,sonuc;
            sayi1=Convert.ToInt32(txtsayi1.Text);
            sayi2=Convert.ToInt32(txtsayi2.Text);
            sonuc = sayi1 + sayi2;

            lblsonuc.Text=sonuc.ToString();
        }

        private void btncikar_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(txtsayi1.Text);
            sayi2 = Convert.ToInt32(txtsayi2.Text);
            sonuc = sayi1 - sayi2;

            lblsonuc.Text = sonuc.ToString();
        }

        private void btncarp_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(txtsayi1.Text);
            sayi2 = Convert.ToInt32(txtsayi2.Text);
            sonuc = sayi1 * sayi2;

            lblsonuc.Text = sonuc.ToString();
        }

        private void btnböl_Click(object sender, EventArgs e)
        {
            float sayi1, sayi2, sonuc;
            sayi1 = Convert.ToSingle(txtsayi1.Text);
            sayi2 = Convert.ToSingle(txtsayi2.Text);
            sonuc = sayi1 / sayi2;

            lblsonuc.Text = sonuc.ToString();
        }
    }
}
