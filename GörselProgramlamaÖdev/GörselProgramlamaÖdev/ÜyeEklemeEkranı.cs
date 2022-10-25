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
    public partial class ÜyeEklemeEkranı : Form
    {
        AnaEkran anaEkran;
        public ÜyeEklemeEkranı(AnaEkran parametredenGelenAnaEkran)
        {
            InitializeComponent();
            anaEkran = parametredenGelenAnaEkran;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaEkran.üyeEkle(textBox1.Text);
            textBox1.Clear();
            this.Close();
        }
    }
}
