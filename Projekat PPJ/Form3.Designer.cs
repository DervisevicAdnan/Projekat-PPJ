﻿namespace Projekat_PPJ
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AžuriranjeArtikla = new System.Windows.Forms.Button();
            this.buttonDodavanjeArtikla = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIdArtikla = new System.Windows.Forms.TextBox();
            this.textBoxKolicina = new System.Windows.Forms.TextBox();
            this.textBoxCijena = new System.Windows.Forms.TextBox();
            this.textBoxVrstaArtikla = new System.Windows.Forms.TextBox();
            this.textBoxNazivArtikla = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonTrazi = new System.Windows.Forms.Button();
            this.textBoxPretragaNaziv = new System.Windows.Forms.TextBox();
            this.textBoxPretragaId = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodavanjeAžuriranjeArtiklaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazBrisanjeNarudžbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreiranjeNovogKupcaAžuriranjePostojećegKupcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AžuriranjeArtikla);
            this.groupBox1.Controls.Add(this.buttonDodavanjeArtikla);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxIdArtikla);
            this.groupBox1.Controls.Add(this.textBoxKolicina);
            this.groupBox1.Controls.Add(this.textBoxCijena);
            this.groupBox1.Controls.Add(this.textBoxVrstaArtikla);
            this.groupBox1.Controls.Add(this.textBoxNazivArtikla);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.buttonTrazi);
            this.groupBox1.Controls.Add(this.textBoxPretragaNaziv);
            this.groupBox1.Controls.Add(this.textBoxPretragaId);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 488);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje / Ažuriranje artikla";
            // 
            // AžuriranjeArtikla
            // 
            this.AžuriranjeArtikla.Location = new System.Drawing.Point(415, 453);
            this.AžuriranjeArtikla.Name = "AžuriranjeArtikla";
            this.AžuriranjeArtikla.Size = new System.Drawing.Size(105, 23);
            this.AžuriranjeArtikla.TabIndex = 17;
            this.AžuriranjeArtikla.Text = "Ažuriranje artikla:";
            this.AžuriranjeArtikla.UseVisualStyleBackColor = true;
            this.AžuriranjeArtikla.Click += new System.EventHandler(this.AžuriranjeArtikla_Click);
            // 
            // buttonDodavanjeArtikla
            // 
            this.buttonDodavanjeArtikla.Location = new System.Drawing.Point(85, 453);
            this.buttonDodavanjeArtikla.Name = "buttonDodavanjeArtikla";
            this.buttonDodavanjeArtikla.Size = new System.Drawing.Size(134, 23);
            this.buttonDodavanjeArtikla.TabIndex = 16;
            this.buttonDodavanjeArtikla.Text = "Dodavanje artikla:";
            this.buttonDodavanjeArtikla.UseVisualStyleBackColor = true;
            this.buttonDodavanjeArtikla.Click += new System.EventHandler(this.buttonDodavanjeArtikla_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(437, 401);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Dodaj količinu:";
            // 
            // textBoxIdArtikla
            // 
            this.textBoxIdArtikla.Location = new System.Drawing.Point(435, 370);
            this.textBoxIdArtikla.Name = "textBoxIdArtikla";
            this.textBoxIdArtikla.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdArtikla.TabIndex = 13;
            // 
            // textBoxKolicina
            // 
            this.textBoxKolicina.Location = new System.Drawing.Point(119, 427);
            this.textBoxKolicina.Name = "textBoxKolicina";
            this.textBoxKolicina.Size = new System.Drawing.Size(100, 20);
            this.textBoxKolicina.TabIndex = 12;
            // 
            // textBoxCijena
            // 
            this.textBoxCijena.Location = new System.Drawing.Point(119, 398);
            this.textBoxCijena.Name = "textBoxCijena";
            this.textBoxCijena.Size = new System.Drawing.Size(100, 20);
            this.textBoxCijena.TabIndex = 11;
            // 
            // textBoxVrstaArtikla
            // 
            this.textBoxVrstaArtikla.Location = new System.Drawing.Point(119, 367);
            this.textBoxVrstaArtikla.Name = "textBoxVrstaArtikla";
            this.textBoxVrstaArtikla.Size = new System.Drawing.Size(100, 20);
            this.textBoxVrstaArtikla.TabIndex = 10;
            // 
            // textBoxNazivArtikla
            // 
            this.textBoxNazivArtikla.Location = new System.Drawing.Point(119, 338);
            this.textBoxNazivArtikla.Name = "textBoxNazivArtikla";
            this.textBoxNazivArtikla.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazivArtikla.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID artikla:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Količina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cijena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vrsta artikla:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv artikla:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(569, 253);
            this.dataGridView1.TabIndex = 3;
            // 
            // buttonTrazi
            // 
            this.buttonTrazi.Location = new System.Drawing.Point(328, 27);
            this.buttonTrazi.Name = "buttonTrazi";
            this.buttonTrazi.Size = new System.Drawing.Size(75, 23);
            this.buttonTrazi.TabIndex = 2;
            this.buttonTrazi.Text = "Traži";
            this.buttonTrazi.UseVisualStyleBackColor = true;
            this.buttonTrazi.Click += new System.EventHandler(this.buttonTrazi_Click);
            // 
            // textBoxPretragaNaziv
            // 
            this.textBoxPretragaNaziv.Location = new System.Drawing.Point(188, 29);
            this.textBoxPretragaNaziv.Name = "textBoxPretragaNaziv";
            this.textBoxPretragaNaziv.Size = new System.Drawing.Size(100, 20);
            this.textBoxPretragaNaziv.TabIndex = 1;
            // 
            // textBoxPretragaId
            // 
            this.textBoxPretragaId.Location = new System.Drawing.Point(60, 30);
            this.textBoxPretragaId.Name = "textBoxPretragaId";
            this.textBoxPretragaId.Size = new System.Drawing.Size(100, 20);
            this.textBoxPretragaId.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodavanjeAžuriranjeArtiklaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodavanjeAžuriranjeArtiklaToolStripMenuItem
            // 
            this.dodavanjeAžuriranjeArtiklaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreiranjeNovogKupcaAžuriranjePostojećegKupcaToolStripMenuItem,
            this.prikazBrisanjeNarudžbeToolStripMenuItem});
            this.dodavanjeAžuriranjeArtiklaToolStripMenuItem.Name = "dodavanjeAžuriranjeArtiklaToolStripMenuItem";
            this.dodavanjeAžuriranjeArtiklaToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dodavanjeAžuriranjeArtiklaToolStripMenuItem.Text = "Meni";
            // 
            // prikazBrisanjeNarudžbeToolStripMenuItem
            // 
            this.prikazBrisanjeNarudžbeToolStripMenuItem.Name = "prikazBrisanjeNarudžbeToolStripMenuItem";
            this.prikazBrisanjeNarudžbeToolStripMenuItem.Size = new System.Drawing.Size(352, 22);
            this.prikazBrisanjeNarudžbeToolStripMenuItem.Text = "Prikaz / Brisanje narudžbe";
            this.prikazBrisanjeNarudžbeToolStripMenuItem.Click += new System.EventHandler(this.prikazBrisanjeNarudžbeToolStripMenuItem_Click);
            // 
            // kreiranjeNovogKupcaAžuriranjePostojećegKupcaToolStripMenuItem
            // 
            this.kreiranjeNovogKupcaAžuriranjePostojećegKupcaToolStripMenuItem.Name = "kreiranjeNovogKupcaAžuriranjePostojećegKupcaToolStripMenuItem";
            this.kreiranjeNovogKupcaAžuriranjePostojećegKupcaToolStripMenuItem.Size = new System.Drawing.Size(352, 22);
            this.kreiranjeNovogKupcaAžuriranjePostojećegKupcaToolStripMenuItem.Text = "Kreiranje novog kupca / Ažuriranje postojećeg kupca";
            this.kreiranjeNovogKupcaAžuriranjePostojećegKupcaToolStripMenuItem.Click += new System.EventHandler(this.kreiranjeNovogKupcaAžuriranjePostojećegKupcaToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 539);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Dodavanje / Ažuriranje artikla";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonTrazi;
        private System.Windows.Forms.TextBox textBoxPretragaNaziv;
        private System.Windows.Forms.TextBox textBoxPretragaId;
        private System.Windows.Forms.Button AžuriranjeArtikla;
        private System.Windows.Forms.Button buttonDodavanjeArtikla;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxIdArtikla;
        private System.Windows.Forms.TextBox textBoxKolicina;
        private System.Windows.Forms.TextBox textBoxCijena;
        private System.Windows.Forms.TextBox textBoxVrstaArtikla;
        private System.Windows.Forms.TextBox textBoxNazivArtikla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeAžuriranjeArtiklaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazBrisanjeNarudžbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeNovogKupcaAžuriranjePostojećegKupcaToolStripMenuItem;
    }
}