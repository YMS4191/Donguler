using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            //Asagidaki dizide yer alan her bir elemani, listbox icerisine ekleyiniz...
            string[] takimlar = { "Galatasaray", "Fenerbahce", "Besiktas", "Trabzonspor", "Bursaspor", "Ankaragücü" };
        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            //Sayisal bir dizi tanimlayin ve Array sınıfını kullanmadan o dizinin en buyuk elemanini gosterin...
        }

        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            //Asagidaki dizide kac tane cift kac tane tek sayi vardir kullaniciyi bilgilendiriniz..
            int[] sayisal = { 12, 45, 23, 76, 119, 85, 46, 223, 4, 6, 25 };
        }

        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            //asagidaki "adim" degiskeninde yer alan metni tersten isterseniz formun tepesine, isterseniz MessageBox'la yazdiriniz...

            //NOT => STRING'LER BİRER CHAR DİZİSİDİR...
            string adim = "bilgeadam";
        }

        private void btnOrnekBes_Click(object sender, EventArgs e)
        {
            //Karmasik 10 adet sayiyi listbox icerisine ekleyiniz...
        }

        private void btnOrnekAlti_Click(object sender, EventArgs e)
        {
            //Form uzerinde yer alan tum butonlarin arkaplan renkleri kırmızı, yazi renkleri ise sarı olsun...

        }
         
        private void btnOrnekYedi_Click(object sender, EventArgs e)
        {
            //Disaridan girilen sayisal ifadenin rakam degerleri toplamini gosteriniz...
            //Ornegin 123 girilirse 1+2+3 = 6 sonucu donmelidir...
        }
    }
}
