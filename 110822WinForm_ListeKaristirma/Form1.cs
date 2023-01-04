using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _110822WinForm_ListeKaristirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
           
            string isim = textBox1.Text;
            if(listBox1.Items.Contains(isim)==true)
            {
                MessageBox.Show("Girilen isim listede vardır.Lütfen farklı bir isim giriniz.");
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                listBox1.Items.Add(isim);
                textBox1.Clear();
                textBox1.Focus();
            }
            
        }

        private void btnKarıstır_Click(object sender, EventArgs e)
        {
            string[] isimler =new string[listBox1.Items.Count];
            Random rnd = new Random();

            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                int sayi = rnd.Next(0,listBox1.Items.Count);
                string rastgele = listBox1.Items[sayi].ToString();
                
                if(isimler.Contains(rastgele)==false)
                {
                    isimler[i] = rastgele;
                }
                else
                {
                    i--;         
                }
                
            }
            listBox1.Items.Clear();
            foreach (string item in isimler)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
           
            DialogResult sonuc= MessageBox.Show("Silmek istediğinize emin misiniz?(Are you sure delete)", "Silme Formu",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(sonuc==DialogResult.Yes)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            

        }
    }
}
