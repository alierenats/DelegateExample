using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate void islemler(int a1, int a2);

        void Toplam(int x, int y)
        {
            listBox1.Items.Add(x + y);
        }

        void Cıkar(int a, int b)
        {
            listBox1.Items.Add(a - b);
        }

        void Carp(int z, int k)
        {
            listBox1.Items.Add(z * k);

        }

        void Bol(int c, int d)
        {
            listBox1.Items.Add(c / d);
        }


        private void button1_Click(object sender, EventArgs e)
        {

            islemler islem = new islemler(Toplam);
            islem += Cıkar;
            islem += Carp;
            islem += Bol;
            islem(10, 5);
        }
    }
}

