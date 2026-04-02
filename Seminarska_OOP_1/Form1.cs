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
using System.IO;

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
            NaloziPodatke();
        }

        public void ShraniPodatke()
        {
            using (StreamWriter sw = new StreamWriter("podatki.txt"))
            {
                for (int i = 0; i < steviloLetov; i++)
                {
                    Let let = leti[i];

                    sw.WriteLine($"LET|{let.Ime_Leta}|{let.Destinacija}|{let.Kapaciteta}");

                    for (int j = 0; j < let.Zasedenost; j++)
                    {
                        if (let[j] is Potnik p)
                        {
                            sw.WriteLine($"POTNIK|{p.Ime}|{p.Priimek}|{p.Potni_list}|{p.Prtljaga}");
                        }
                        else if (let[j] is Zaposleni z)
                        {
                            sw.WriteLine($"ZAPOSLENI|{z.Ime}|{z.Priimek}|{z.Vloga}|{z.Id}");
                        }
                    }
                }
            }
        }

        public void NaloziPodatke()
        {
            if (!File.Exists("podatki.txt")) return;

            comboBoxLeti.Items.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            steviloLetov = 0;

            using (StreamReader sr = new StreamReader("podatki.txt"))
            {
                Let trenutniLet = null;

                while (!sr.EndOfStream)
                {
                    string vrstica = sr.ReadLine();
                    string[] deli = vrstica.Split('|');

                    if (deli[0] == "LET")
                    {
                        Letalo letalo = new Letalo("Model", "X", int.Parse(deli[3]));
                        trenutniLet = new Let(deli[1], deli[2], DateTime.Now, letalo);

                        leti[steviloLetov++] = trenutniLet;
                        comboBoxLeti.Items.Add(trenutniLet);
                        comboBox1.Items.Add(trenutniLet);
                        comboBox2.Items.Add(trenutniLet);
                    }
                    else if (deli[0] == "POTNIK" && trenutniLet != null)
                    {
                        trenutniLet.DodajOsebo(
                            new Potnik(deli[1], deli[2], deli[3], int.Parse(deli[4])));
                    }
                    else if (deli[0] == "ZAPOSLENI" && trenutniLet != null)
                    {
                        trenutniLet.DodajOsebo(
                            new Zaposleni(deli[1], deli[2], deli[3], deli[4]));
                    }
                }
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            ShraniPodatke();
            MessageBox.Show("Podatki shranjeni!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NaloziPodatke();

            if (steviloLetov > 0)
            {
                comboBoxLeti.SelectedIndex = 0;
            }

            OsveziSeznamOseb();
            MessageBox.Show("Podatki naloženi!");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShraniPodatke();
        }
    }
}
