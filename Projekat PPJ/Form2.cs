using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projekat_PPJ
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        String kupID = Form1.kupacID;
        String konekStr = Form1.konekcioniString;

        private void buttonKreiranjeKupca_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "INSERT INTO kupac(ime,prezime,grad,adresa,telefon,user,pass)" +
                    " VALUES('";
                if (textBoxIme.Text == "" || textBoxPrezime.Text == "" || textBoxGrad.Text == "" ||
                    textBoxAdresa.Text == "" || textBoxTelefon.Text == "" || textBoxKorisničkoIme.Text=="" || textBoxSifra.Text == "")
                {
                    MessageBox.Show("Nisu popunjena sva polja");
                }
                else
                {
                    query += textBoxIme.Text + "', '" + textBoxPrezime.Text + "', '" + textBoxGrad.Text + "', '" +
                        textBoxAdresa.Text + "', '" + textBoxTelefon.Text + "', '" +
                        textBoxKorisničkoIme.Text + "', '" + textBoxSifra.Text + "'); ";
                    MessageBox.Show(query);
                    MySqlConnection konekcija = new MySqlConnection(konekStr);
                    konekcija.Open();
                    MySqlCommand cmd = new MySqlCommand(query, konekcija);
                    cmd.ExecuteNonQuery();
                    buttonTrazi.PerformClick();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTrazi_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "SELECT *" +
                    " FROM kupac " +
                    " WHERE kupac_id IS NOT NULL";
                if (textBoxPretragaIme.Text != "")
                {
                    query += " AND ime LIKE '%" + textBoxPretragaIme.Text + "%' ";
                }
                if (textBoxPretragaPrezime.Text != "")
                {
                    query += " AND prezime LIKE '%" + textBoxPretragaPrezime.Text + "%' ";
                }
                MySqlConnection konekcija = new MySqlConnection(konekStr);
                konekcija.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, konekcija);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                dataGridView1.DataSource = tabela;
                dataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            buttonTrazi.PerformClick();
        }

        private void buttonAzuriranjeKupca_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "UPDATE kupac SET ";
                if (textBoxIme.Text != "")
                {
                    query += "ime='"+textBoxIme.Text + "',";
                }
                if (textBoxPrezime.Text != "")
                {
                    query += "prezime='" + textBoxPrezime.Text + "',";
                }
                if(textBoxGrad.Text != "")
                {
                    query += "grad='" + textBoxGrad.Text + "',";
                }
                if(textBoxAdresa.Text != "")
                {
                    query += "adresa='" + textBoxAdresa.Text + "',";
                }
                if(textBoxTelefon.Text != "")
                {
                    query += "telefon='" + textBoxTelefon.Text + "',";
                }
                if(textBoxKorisničkoIme.Text != "")
                {
                    query += "user='" + textBoxKorisničkoIme.Text + "',";
                }
                if(textBoxSifra.Text != "")
                {
                    query += "pass='" + textBoxSifra.Text + "',";
                }
                if(query[query.Length-1]==',') query=query.Substring(0,query.Length-1);
                query += " WHERE kupac_id='" + textBoxIdKupca.Text + "';";
                MessageBox.Show(query);
                MySqlConnection konekcija = new MySqlConnection(konekStr);
                konekcija.Open();
                MySqlCommand cmd = new MySqlCommand(query, konekcija);
                cmd.ExecuteNonQuery();
                buttonTrazi.PerformClick();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dodavanjeAžuriranjeArtiklaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            this.Hide();
            fr3.Show();
        }

        private void prikazBrisanjeNarudžbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            this.Hide();
            fr4.Show();
        }
    }
}
