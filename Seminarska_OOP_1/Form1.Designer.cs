namespace Seminarska_OOP_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOznakaLeta = new System.Windows.Forms.TextBox();
            this.textBoxDestinacija = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxSifra = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.labelStLetal = new System.Windows.Forms.Label();
            this.textBoxKapaciteta = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelStPotnikov = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxVloga = new System.Windows.Forms.ComboBox();
            this.labelVloga = new System.Windows.Forms.Label();
            this.radioButtonZaposleni = new System.Windows.Forms.RadioButton();
            this.radioButtonPotnik = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrtljaga = new System.Windows.Forms.TextBox();
            this.textBoxPotniList = new System.Windows.Forms.TextBox();
            this.textBoxPriimek = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonDodajPotnika = new System.Windows.Forms.Button();
            this.buttonUstvariLet = new System.Windows.Forms.Button();
            this.listBoxPotniki = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBoxLeti = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonPrimarjaj = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelPodatkiLeta = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oznaka leta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destinacija:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxOznakaLeta
            // 
            this.textBoxOznakaLeta.Location = new System.Drawing.Point(9, 42);
            this.textBoxOznakaLeta.Name = "textBoxOznakaLeta";
            this.textBoxOznakaLeta.Size = new System.Drawing.Size(116, 20);
            this.textBoxOznakaLeta.TabIndex = 2;
            // 
            // textBoxDestinacija
            // 
            this.textBoxDestinacija.Location = new System.Drawing.Point(149, 42);
            this.textBoxDestinacija.Name = "textBoxDestinacija";
            this.textBoxDestinacija.Size = new System.Drawing.Size(116, 20);
            this.textBoxDestinacija.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBoxSifra);
            this.groupBox1.Controls.Add(this.textBoxModel);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.labelStLetal);
            this.groupBox1.Controls.Add(this.textBoxKapaciteta);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxDestinacija);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxOznakaLeta);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 190);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Let";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(146, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Šifra:";
            // 
            // textBoxSifra
            // 
            this.textBoxSifra.Location = new System.Drawing.Point(149, 115);
            this.textBoxSifra.Name = "textBoxSifra";
            this.textBoxSifra.Size = new System.Drawing.Size(116, 20);
            this.textBoxSifra.TabIndex = 17;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(7, 115);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(118, 20);
            this.textBoxModel.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Model letala:";
            // 
            // labelStLetal
            // 
            this.labelStLetal.AutoSize = true;
            this.labelStLetal.Location = new System.Drawing.Point(65, 166);
            this.labelStLetal.Name = "labelStLetal";
            this.labelStLetal.Size = new System.Drawing.Size(13, 13);
            this.labelStLetal.TabIndex = 15;
            this.labelStLetal.Text = "0";
            // 
            // textBoxKapaciteta
            // 
            this.textBoxKapaciteta.Location = new System.Drawing.Point(288, 42);
            this.textBoxKapaciteta.Name = "textBoxKapaciteta";
            this.textBoxKapaciteta.Size = new System.Drawing.Size(116, 20);
            this.textBoxKapaciteta.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Število letal: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(285, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Kapaciteta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelStPotnikov);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxPrtljaga);
            this.groupBox2.Controls.Add(this.textBoxPotniList);
            this.groupBox2.Controls.Add(this.textBoxPriimek);
            this.groupBox2.Controls.Add(this.textBoxIme);
            this.groupBox2.Location = new System.Drawing.Point(12, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 145);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Potniki";
            // 
            // labelStPotnikov
            // 
            this.labelStPotnikov.AutoSize = true;
            this.labelStPotnikov.Location = new System.Drawing.Point(78, 121);
            this.labelStPotnikov.Name = "labelStPotnikov";
            this.labelStPotnikov.Size = new System.Drawing.Size(13, 13);
            this.labelStPotnikov.TabIndex = 13;
            this.labelStPotnikov.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Število oseb: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kosi prtljage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Potni List";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxVloga);
            this.groupBox4.Controls.Add(this.labelVloga);
            this.groupBox4.Controls.Add(this.radioButtonZaposleni);
            this.groupBox4.Controls.Add(this.radioButtonPotnik);
            this.groupBox4.Location = new System.Drawing.Point(430, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(109, 115);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Podatki o osebi";
            // 
            // comboBoxVloga
            // 
            this.comboBoxVloga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVloga.FormattingEnabled = true;
            this.comboBoxVloga.Items.AddRange(new object[] {
            "Pilot",
            "Stevardesa"});
            this.comboBoxVloga.Location = new System.Drawing.Point(10, 82);
            this.comboBoxVloga.Name = "comboBoxVloga";
            this.comboBoxVloga.Size = new System.Drawing.Size(93, 21);
            this.comboBoxVloga.TabIndex = 14;
            // 
            // labelVloga
            // 
            this.labelVloga.AutoSize = true;
            this.labelVloga.Location = new System.Drawing.Point(7, 65);
            this.labelVloga.Name = "labelVloga";
            this.labelVloga.Size = new System.Drawing.Size(34, 13);
            this.labelVloga.TabIndex = 13;
            this.labelVloga.Text = "Vloga";
            // 
            // radioButtonZaposleni
            // 
            this.radioButtonZaposleni.AutoSize = true;
            this.radioButtonZaposleni.Location = new System.Drawing.Point(7, 43);
            this.radioButtonZaposleni.Name = "radioButtonZaposleni";
            this.radioButtonZaposleni.Size = new System.Drawing.Size(71, 17);
            this.radioButtonZaposleni.TabIndex = 1;
            this.radioButtonZaposleni.Text = "Zaposleni";
            this.radioButtonZaposleni.UseVisualStyleBackColor = true;
            this.radioButtonZaposleni.CheckedChanged += new System.EventHandler(this.radioButtonZaposleni_CheckedChanged);
            // 
            // radioButtonPotnik
            // 
            this.radioButtonPotnik.AutoSize = true;
            this.radioButtonPotnik.Checked = true;
            this.radioButtonPotnik.Location = new System.Drawing.Point(7, 20);
            this.radioButtonPotnik.Name = "radioButtonPotnik";
            this.radioButtonPotnik.Size = new System.Drawing.Size(55, 17);
            this.radioButtonPotnik.TabIndex = 0;
            this.radioButtonPotnik.TabStop = true;
            this.radioButtonPotnik.Text = "Potnik";
            this.radioButtonPotnik.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Priimek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ime";
            // 
            // textBoxPrtljaga
            // 
            this.textBoxPrtljaga.Location = new System.Drawing.Point(324, 41);
            this.textBoxPrtljaga.Name = "textBoxPrtljaga";
            this.textBoxPrtljaga.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrtljaga.TabIndex = 3;
            // 
            // textBoxPotniList
            // 
            this.textBoxPotniList.Location = new System.Drawing.Point(218, 41);
            this.textBoxPotniList.Name = "textBoxPotniList";
            this.textBoxPotniList.Size = new System.Drawing.Size(100, 20);
            this.textBoxPotniList.TabIndex = 2;
            // 
            // textBoxPriimek
            // 
            this.textBoxPriimek.Location = new System.Drawing.Point(112, 41);
            this.textBoxPriimek.Name = "textBoxPriimek";
            this.textBoxPriimek.Size = new System.Drawing.Size(100, 20);
            this.textBoxPriimek.TabIndex = 1;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(6, 41);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(100, 20);
            this.textBoxIme.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonDodajPotnika);
            this.groupBox3.Controls.Add(this.buttonUstvariLet);
            this.groupBox3.Location = new System.Drawing.Point(431, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 93);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ustvari/Dodaj";
            // 
            // buttonDodajPotnika
            // 
            this.buttonDodajPotnika.Location = new System.Drawing.Point(7, 49);
            this.buttonDodajPotnika.Name = "buttonDodajPotnika";
            this.buttonDodajPotnika.Size = new System.Drawing.Size(107, 23);
            this.buttonDodajPotnika.TabIndex = 1;
            this.buttonDodajPotnika.Text = "Dodaj Osebo";
            this.buttonDodajPotnika.UseVisualStyleBackColor = true;
            this.buttonDodajPotnika.Click += new System.EventHandler(this.buttonDodajPotnika_Click);
            // 
            // buttonUstvariLet
            // 
            this.buttonUstvariLet.Location = new System.Drawing.Point(7, 20);
            this.buttonUstvariLet.Name = "buttonUstvariLet";
            this.buttonUstvariLet.Size = new System.Drawing.Size(107, 23);
            this.buttonUstvariLet.TabIndex = 0;
            this.buttonUstvariLet.Text = "Ustvari let";
            this.buttonUstvariLet.UseVisualStyleBackColor = true;
            this.buttonUstvariLet.Click += new System.EventHandler(this.buttonUstvariLet_Click);
            // 
            // listBoxPotniki
            // 
            this.listBoxPotniki.FormattingEnabled = true;
            this.listBoxPotniki.Location = new System.Drawing.Point(12, 391);
            this.listBoxPotniki.Name = "listBoxPotniki";
            this.listBoxPotniki.Size = new System.Drawing.Size(547, 355);
            this.listBoxPotniki.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Trenutni let:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 9;
            // 
            // comboBoxLeti
            // 
            this.comboBoxLeti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLeti.FormattingEnabled = true;
            this.comboBoxLeti.Location = new System.Drawing.Point(438, 367);
            this.comboBoxLeti.Name = "comboBoxLeti";
            this.comboBoxLeti.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLeti.TabIndex = 11;
            this.comboBoxLeti.SelectedIndexChanged += new System.EventHandler(this.comboBoxLeti_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonPrimarjaj);
            this.groupBox5.Controls.Add(this.comboBox2);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Location = new System.Drawing.Point(308, 111);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(251, 91);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Večja kapaciteta";
            // 
            // buttonPrimarjaj
            // 
            this.buttonPrimarjaj.Location = new System.Drawing.Point(63, 62);
            this.buttonPrimarjaj.Name = "buttonPrimarjaj";
            this.buttonPrimarjaj.Size = new System.Drawing.Size(112, 23);
            this.buttonPrimarjaj.TabIndex = 2;
            this.buttonPrimarjaj.Text = "Primerjaj Kapaciteto";
            this.buttonPrimarjaj.UseVisualStyleBackColor = true;
            this.buttonPrimarjaj.Click += new System.EventHandler(this.buttonPrimarjaj_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(131, 35);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(114, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // labelPodatkiLeta
            // 
            this.labelPodatkiLeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPodatkiLeta.Location = new System.Drawing.Point(12, 356);
            this.labelPodatkiLeta.Name = "labelPodatkiLeta";
            this.labelPodatkiLeta.Size = new System.Drawing.Size(351, 32);
            this.labelPodatkiLeta.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 760);
            this.Controls.Add(this.labelPodatkiLeta);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.comboBoxLeti);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxPotniki);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Letalski Sistem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOznakaLeta;
        private System.Windows.Forms.TextBox textBoxDestinacija;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrtljaga;
        private System.Windows.Forms.TextBox textBoxPotniList;
        private System.Windows.Forms.TextBox textBoxPriimek;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonDodajPotnika;
        private System.Windows.Forms.Button buttonUstvariLet;
        private System.Windows.Forms.ListBox listBoxPotniki;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButtonZaposleni;
        private System.Windows.Forms.RadioButton radioButtonPotnik;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelVloga;
        private System.Windows.Forms.ComboBox comboBoxVloga;
        private System.Windows.Forms.TextBox textBoxKapaciteta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelStPotnikov;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelStLetal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxLeti;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxSifra;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonPrimarjaj;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelPodatkiLeta;
    }
}

