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
        Let[] leti = new Let[10];
        int steviloLetov = 0;
        Let izbranLet = null;

        private void OsveziSeznamOseb()
        {
            listBoxPotniki.Items.Clear();

            if (izbranLet != null) listBoxPotniki.Items.AddRange(izbranLet.SeznamOseb());
        }

        public Form1()
        {
            InitializeComponent();
            buttonDodajPotnika.Enabled = false;
            comboBoxVloga.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonUstvariLet_Click(object sender, EventArgs e)
        {
            Letalo letalo = new Letalo(textBoxModel.Text, textBoxSifra.Text, int.Parse(textBoxKapaciteta.Text));

            Let novLet = new Let(textBoxOznakaLeta.Text, textBoxDestinacija.Text, DateTime.Now, letalo);

            leti[steviloLetov] = novLet;
            steviloLetov++;

            comboBoxLeti.Items.Add(novLet);
            comboBoxLeti.SelectedIndex = comboBoxLeti.Items.Count - 1;

            comboBox1.Items.Add(novLet);
            comboBox2.Items.Add(novLet);

            buttonDodajPotnika.Enabled = true;
            MessageBox.Show("Let uspešno ustvarjen");
            labelStLetal.Text = (Letalo.steviloLetal++).ToString();
        }

        private void buttonDodajPotnika_Click(object sender, EventArgs e)
        {
            Oseba novaOseba = null;

            if (radioButtonPotnik.Checked)
            {
                novaOseba = new Potnik(textBoxIme.Text, textBoxPriimek.Text, textBoxPotniList.Text, Convert.ToInt32(textBoxPrtljaga.Text));
            }
            else if (radioButtonZaposleni.Checked)
            {
                novaOseba = new Zaposleni(textBoxIme.Text, textBoxPriimek.Text, comboBoxVloga.Text);
            }

            if (novaOseba != null)
            {
                if (izbranLet.DodajOsebo(novaOseba))
                {
                    listBoxPotniki.Items.Clear();
                    listBoxPotniki.Items.AddRange(izbranLet.SeznamOseb());
                    
                    labelStPotnikov.Text = listBoxPotniki.Items.Count.ToString();
                }
                else
                {
                    MessageBox.Show("Let je poln.");
                }
            }
            
        }

        private void radioButtonZaposleni_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonZaposleni.Checked)
            {
                comboBoxVloga.Enabled = true;
                textBoxPrtljaga.Enabled = false;
                textBoxPotniList.Enabled = false;
            }
            if (radioButtonPotnik.Checked)
            {
                comboBoxVloga.Enabled = false;
                textBoxPrtljaga.Enabled = true;
                textBoxPotniList.Enabled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxLeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLeti.SelectedIndex == -1) 
                return;

            izbranLet = leti[comboBoxLeti.SelectedIndex];
            OsveziSeznamOseb();
            
        }

        private void buttonPrimarjaj_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Izberi oba leta.");
                return;
            }
            Let let1 = (Let)comboBox1.SelectedItem;
            Let let2 = (Let)comboBox2.SelectedItem;

            if (let1 > let2)
            {
                MessageBox.Show($"{let1.Ime_Leta} > {let2.Ime_Leta}");
            }
            else if (let1 < let2)
            {
                MessageBox.Show($"{let2.Ime_Leta} > {let1.Ime_Leta}");
            }
            else
            {
                MessageBox.Show("Oba leta imata enako kapaciteto.");
            }
        }
    }
}
