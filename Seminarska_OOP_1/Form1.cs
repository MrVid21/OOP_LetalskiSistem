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

        /// <summary>
        /// Ustvari nov let in ga doda v seznam letov v uporabniškem vmesniku.
        /// </summary>
        /// <param name="sender">Pošiljatelj dogodka.</param>
        /// <param name="e">Podatki dogodka.</param>
        private void buttonUstvariLet_Click(object sender, EventArgs e)
        {


            Letalo letalo = new Letalo(textBoxModel.Text, textBoxSifra.Text, int.Parse(textBoxKapaciteta.Text));

            Let novLet = new Let(textBoxOznakaLeta.Text, textBoxDestinacija.Text, DateTime.Now, letalo);

            novLet.OsebaDodana += (o) =>
            {
                MessageBox.Show($"Dodana oseba: {o.Opis()}");
            };

            novLet.LetPoln += (ime) =>
            {
                MessageBox.Show($"Let {ime} je POLN!");
            };


            leti[steviloLetov] = novLet;
            steviloLetov++;

            comboBoxLeti.Items.Add(novLet);
            comboBoxLeti.SelectedIndex = comboBoxLeti.Items.Count - 1;



            comboBox1.Items.Add(novLet);
            comboBox2.Items.Add(novLet);

            buttonDodajPotnika.Enabled = true;

            labelStLetal.Text = Letalo.VrniSteviloLetal().ToString();
            MessageBox.Show("Let ustvarjen");
        }

        /// <summary>
        /// Doda novo osebo na trenutno izbrani let.
        /// </summary>
        /// <param name="sender">Pošiljatelj dogodka.</param>
        /// <param name="e">Podatki dogodka.</param>
        private void buttonDodajPotnika_Click(object sender, EventArgs e)
        {
            if (izbranLet == null)
            {
                MessageBox.Show("Izberi let!");
                return;
            }

            Oseba novaOseba = null;

            if (radioButtonPotnik.Checked)
            {
                novaOseba = new Potnik(
                    textBoxIme.Text,
                    textBoxPriimek.Text,
                    textBoxPotniList.Text,
                    Convert.ToInt32(textBoxPrtljaga.Text));
            }
            else if (radioButtonZaposleni.Checked)
            {
                novaOseba = new Zaposleni(
                    textBoxIme.Text,
                    textBoxPriimek.Text,
                    comboBoxVloga.Text,
                    Guid.NewGuid().ToString());
            }

            if (!Potnik.JeVeljavenPotniList(textBoxPotniList.Text))
            {
                MessageBox.Show("Neveljaven potni list!");
                return;
            }

            if (novaOseba != null)
            {
                if (izbranLet.DodajOsebo(novaOseba))
                {
                    OsveziSeznamOseb();
                    labelStPotnikov.Text = izbranLet.Zasedenost.ToString();
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

        /// <summary>
        /// Posodobi prikaz podatkov, ko uporabnik izbere drug let.
        /// </summary>
        /// <param name="sender">Pošiljatelj dogodka.</param>
        /// <param name="e">Podatki dogodka.</param>
        private void comboBoxLeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLeti.SelectedIndex == -1)
                return;

            izbranLet = (Let)comboBoxLeti.SelectedItem;

            OsveziSeznamOseb();

            labelStPotnikov.Text = izbranLet.Zasedenost.ToString();

            labelPodatkiLeta.Text = izbranLet.OpisLeta();
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

        

        private void buttonFiltrirajPotnike_Click_1(object sender, EventArgs e)
        {
            if (izbranLet == null) return;

            var potniki = izbranLet.Filtriraj(o => o is Potnik);

            listBoxPotniki.Items.Clear();

            foreach (var p in potniki)
            {
                listBoxPotniki.Items.Add(p.Opis());
            }
        }

        private void buttonFiltrirajZaposlene_Click_1(object sender, EventArgs e)
        {
            if (izbranLet == null) return;

            var zaposleni = izbranLet.Filtriraj(o => o is Zaposleni);

            listBoxPotniki.Items.Clear();

            foreach (var z in zaposleni)
            {
                listBoxPotniki.Items.Add(z.Opis());
            }
        }
    }
}
