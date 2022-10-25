using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GörselProgramlamaÖdev
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void eKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEklemeEkranı kitapEklemeEkranı = new KitapEklemeEkranı(this);
            kitapEklemeEkranı.Show();
        }
        public void kitapEkle(object kitapAdi)
        {
            listBox1.Items.Add(kitapAdi);
        }

        private void eKLEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            YazarEklemeEkranı yazarEklemeEkranı = new YazarEklemeEkranı(this);
            yazarEklemeEkranı.Show();
        }
        public void yazarEkle(object yazarAdi)
        {
            listBox2.Items.Add(yazarAdi);
        }

        private void eKLEToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ÜyeEklemeEkranı üyeEklemeEkranı = new ÜyeEklemeEkranı(this);
            üyeEklemeEkranı.Show();
        }
        public void üyeEkle(object üyeAdi)
        {
            listBox3.Items.Add(üyeAdi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cıktı;
            cıktı = MessageBox.Show("SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ?", "uyarı", MessageBoxButtons.OKCancel);
            if (cıktı == DialogResult.OK)
            {
                int secim = listBox1.SelectedIndex;
                if (secim != -1)
                    listBox1.Items.RemoveAt(secim);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cıktı;
            cıktı = MessageBox.Show("SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ?","uyarı",MessageBoxButtons.OKCancel);
            if (cıktı == DialogResult.OK)
            {
                int secim = listBox2.SelectedIndex;
                if (secim != -1)
                listBox2.Items.RemoveAt(secim);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult cıktı;
            cıktı = MessageBox.Show("SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ?", "uyarı", MessageBoxButtons.OKCancel);
            if (cıktı == DialogResult.OK)
            {
                int secim = listBox3.SelectedIndex;
                if (secim != -1)
                    listBox3.Items.RemoveAt(secim);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DüzenlemeEkranı düzenlemeEkranı = new DüzenlemeEkranı(this);
            düzenlemeEkranı.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DüzenlemeEkranı düzenlemeEkranı = new DüzenlemeEkranı(this);
            düzenlemeEkranı.Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DüzenlemeEkranı düzenlemeEkranı = new DüzenlemeEkranı(this);
            düzenlemeEkranı.Show(this);          
        }
        public void düzenleEkle(object isim)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
             listBox1.Items.Add(isim);
            
            
        }
        public void düzenleEkle1(object isim)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
            listBox2.Items.Add(isim);
           
        }

            public void düzenleEkle2(object isim)
            {
            listBox3.Items.Remove(listBox3.SelectedItem);
                listBox3.Items.Add(isim);
                
            }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button4.Enabled=true;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled=true;
            button5.Enabled=true;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            button3.Enabled=true;
            button6.Enabled=true;
        }
    }
    } 

