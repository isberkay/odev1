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
    public partial class KitapEklemeEkranı : Form
    {
        AnaEkran anaEkran;
        public KitapEklemeEkranı(AnaEkran parametredenGelenAnaEkran)
        {
            InitializeComponent();
            anaEkran = parametredenGelenAnaEkran;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaEkran.kitapEkle(textBox1.Text);
            textBox1.Clear();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
