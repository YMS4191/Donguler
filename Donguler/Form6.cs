using System;
using System.Windows.Forms;

namespace Donguler
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            // Yan yana 5 adet X yazdırınız  
            for (int i = 0; i < 5; i++)
            {
                lblYaziAlani.Text += "X ";
            }
        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            // Alt alta 5 adet X yazdırınız
            for (int i = 0; i < 5; i++)
            {
                lblYaziAlani.Text += "X\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verilen değere göre X ile kare çizdiriniz
            /*
             X X X X X X X X X X
             X X X X X X X X X X
             X X X X X X X X X X
             X X X X X X X X X X
             X X X X X X X X X X
             X X X X X X X X X X
             X X X X X X X X X X  
             */

            for (int y = 0; y < 10; y++)
            {
                for (int i = 0; i < 12; i++)
                {
                    lblYaziAlani.Text += "X ";
                }
                lblYaziAlani.Text += "\n";
            }
        }

        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            // X iler dik kenar üçgen yazdırınız
            /* 
             X 
             X X
             X X X
             X X X X
             X X X X X
             X X X X X X
             X X X X X X X 
             */


            for (int i = 1; i <= 10; i++)
            {
                for (int y = 0; y < i; y++)
                {
                    lblYaziAlani.Text += "X ";
                }
                lblYaziAlani.Text += "\n";
            }
        }

        private void btnOrnekBes_Click(object sender, EventArgs e)
        {
            // Listbox'a çarpım tablosonu ekleyiniz 1 ile 10(dahil) arası

            for (int i = 1; i <= 10; i++)
            {
                for (int y = 1; y <= 10; y++)
                {
                    listBox1.Items.Add($"{i} X {y} =  {i * y}");
                }
                listBox1.Items.Add("---------------------------");
            } 
        }
    }
}
