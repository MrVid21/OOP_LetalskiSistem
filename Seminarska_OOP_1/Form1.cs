using System;
using LetalskiModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Seminarska_OOP_1
{
    public partial class Form1 : Form
    {
        private Let trenutniLet;

        public Form1()
        {
            InitializeComponent();
            buttonDodajPotnika.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonUstvariLet_Click(object sender, EventArgs e)
        {
            Letalo letalo = new Letalo("Boeing 707", "S-001", 5);

            trenutniLet = new Let(textBoxOznakaLeta.Text, textBoxDestinacija.Text, DateTime.Now, letalo);

            buttonDodajPotnika.Enabled = true;
            MessageBox.Show("Let uspešno ustvarjen");
        }

        private void buttonDodajPotnika_Click(object sender, EventArgs e)
        {
            Potnik potnik = new Potnik(textBoxIme.Text, textBoxPriimek.Text, textBoxPotniList.Text, Convert.ToInt32(textBoxPrtljaga.Text));

            if (trenutniLet.DodajOsebo(potnik))
            {
                listBoxPotniki.Items.Clear();
                listBoxPotniki.Items.AddRange(trenutniLet.SeznamOseb());
            }
            else
            {
                MessageBox.Show("Let je poln.");
            }
        }
    }
}
