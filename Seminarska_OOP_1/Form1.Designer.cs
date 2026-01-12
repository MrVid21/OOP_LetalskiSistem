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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPriimek = new System.Windows.Forms.TextBox();
            this.textBoxPotniList = new System.Windows.Forms.TextBox();
            this.textBoxPrtljaga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonUstvariLet = new System.Windows.Forms.Button();
            this.buttonDodajPotnika = new System.Windows.Forms.Button();
            this.listBoxPotniki = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oznaka leta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destinacija:";
            // 
            // textBoxOznakaLeta
            // 
            this.textBoxOznakaLeta.Location = new System.Drawing.Point(6, 42);
            this.textBoxOznakaLeta.Name = "textBoxOznakaLeta";
            this.textBoxOznakaLeta.Size = new System.Drawing.Size(100, 20);
            this.textBoxOznakaLeta.TabIndex = 2;
            // 
            // textBoxDestinacija
            // 
            this.textBoxDestinacija.Location = new System.Drawing.Point(135, 42);
            this.textBoxDestinacija.Name = "textBoxDestinacija";
            this.textBoxDestinacija.Size = new System.Drawing.Size(100, 20);
            this.textBoxDestinacija.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxDestinacija);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxOznakaLeta);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 104);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Let";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxPrtljaga);
            this.groupBox2.Controls.Add(this.textBoxPotniList);
            this.groupBox2.Controls.Add(this.textBoxPriimek);
            this.groupBox2.Controls.Add(this.textBoxIme);
            this.groupBox2.Location = new System.Drawing.Point(12, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 236);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Potniki";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(9, 41);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(100, 20);
            this.textBoxIme.TabIndex = 0;
            // 
            // textBoxPriimek
            // 
            this.textBoxPriimek.Location = new System.Drawing.Point(135, 41);
            this.textBoxPriimek.Name = "textBoxPriimek";
            this.textBoxPriimek.Size = new System.Drawing.Size(100, 20);
            this.textBoxPriimek.TabIndex = 1;
            // 
            // textBoxPotniList
            // 
            this.textBoxPotniList.Location = new System.Drawing.Point(260, 41);
            this.textBoxPotniList.Name = "textBoxPotniList";
            this.textBoxPotniList.Size = new System.Drawing.Size(100, 20);
            this.textBoxPotniList.TabIndex = 2;
            // 
            // textBoxPrtljaga
            // 
            this.textBoxPrtljaga.Location = new System.Drawing.Point(381, 41);
            this.textBoxPrtljaga.Name = "textBoxPrtljaga";
            this.textBoxPrtljaga.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrtljaga.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Priimek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Potni List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kosi prtljage";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonDodajPotnika);
            this.groupBox3.Controls.Add(this.buttonUstvariLet);
            this.groupBox3.Location = new System.Drawing.Point(391, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 101);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ustvari/Dodaj";
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
            // buttonDodajPotnika
            // 
            this.buttonDodajPotnika.Location = new System.Drawing.Point(7, 67);
            this.buttonDodajPotnika.Name = "buttonDodajPotnika";
            this.buttonDodajPotnika.Size = new System.Drawing.Size(107, 23);
            this.buttonDodajPotnika.TabIndex = 1;
            this.buttonDodajPotnika.Text = "Dodaj potnika";
            this.buttonDodajPotnika.UseVisualStyleBackColor = true;
            this.buttonDodajPotnika.Click += new System.EventHandler(this.buttonDodajPotnika_Click);
            // 
            // listBoxPotniki
            // 
            this.listBoxPotniki.FormattingEnabled = true;
            this.listBoxPotniki.Location = new System.Drawing.Point(12, 376);
            this.listBoxPotniki.Name = "listBoxPotniki";
            this.listBoxPotniki.Size = new System.Drawing.Size(507, 264);
            this.listBoxPotniki.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.listBoxPotniki);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}

