using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Parking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtVreme.Text = DateTime.Now.ToString("hh:mm:ss");
            txtDatum.Text = DateTime.Now.ToString("dd/mm/yyyy");
            int brojMesta = 75;
            txtBrojMesta.Text = brojMesta.ToString();
            brojVozila();
        }

        int brojMesta = 75;

        public void brojVozila()
        {
            SqlConnection konekcija = new SqlConnection(Konekcija.konString);

            SqlCommand komanda = new SqlCommand("SELECT * FROM Parkirana_vozila", konekcija);

            SqlDataReader citac = null;

            try
            {
                konekcija.Open();
                citac = komanda.ExecuteReader();
                while (citac.Read())
                    brojMesta--;
                konekcija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void provera_povlascenih()
        {
            string pom = txtRegistracija.Text;

            SqlConnection konekcija = new SqlConnection(Konekcija.konString);

            SqlCommand komanda = new SqlCommand("SELECT Registracija FROM Povlascena_vozila", konekcija);

            SqlDataReader citac = null;

            StringBuilder povlascena = new StringBuilder();

            try
            {
                konekcija.Open();
                citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    if (citac[0].ToString() == pom)
                        MessageBox.Show("Uslo je povlasceno vozilo", "Paznja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                konekcija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


        }

        public void provera_trazenih()
        {
            string pom = txtRegistracija.Text;

            SqlConnection konekcija = new SqlConnection(Konekcija.konString);

            SqlCommand komanda = new SqlCommand("SELECT Registracija FROM Vozila_sa_poternicom", konekcija);

            SqlDataReader citac = null;

            StringBuilder povlascena = new StringBuilder();

            try
            {
                konekcija.Open();
                citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    if (citac[0].ToString() == pom)
                        MessageBox.Show("Vozilo koje je upravo uslo je trazeno od strane policije, pozovite policiju!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                konekcija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the '_Parking_B.Parkirana_vozila' table. You can move, or remove it, as needed.
            //this.parkirana_vozilaTableAdapter2.Fill(this._Parking_B.Parkirana_vozila);
            //// TODO: This line of code loads data into the '_Parking_B.Radnik' table. You can move, or remove it, as needed.
            //this.radnikTableAdapter3.Fill(this._Parking_B.Radnik);
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegistracija.Text))
            {
                MessageBox.Show("Registarska tablica nije lepo uneta", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (brojMesta == 0)
                {
                    MessageBox.Show("Parking je pun!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                provera_povlascenih();
                provera_trazenih();

                SqlConnection konekcija = new SqlConnection(Konekcija.konString);

                SqlCommand komanda = new SqlCommand("INSERT INTO Parkirana_vozila (Registracija, Vreme_ulaska) VALUES (@registracija, @vreme)", konekcija);

                SqlParameter regParam = new SqlParameter("@registracija", SqlDbType.NVarChar, 15);
                SqlParameter vremeParam = new SqlParameter("@vreme", SqlDbType.NVarChar, 30);

                komanda.Parameters.Add(regParam);
                komanda.Parameters.Add(vremeParam);

                regParam.Value = txtRegistracija.Text;
                vremeParam.Value = txtVreme.Text;

                try
                {
                    konekcija.Open();
                    komanda.ExecuteNonQuery();
                    konekcija.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                txtRegistracija.Clear();
                brojMesta--;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            txtVreme.Text = DateTime.Now.ToString("hh:mm:ss");
            txtDatum.Text = DateTime.Now.ToString("dd/mm/yyyy");
            txtBrojMesta.Text = brojMesta.ToString();
        }
        

        

        

        

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Parking_B.Radnik' table. You can move, or remove it, as needed.
            this.radnikTableAdapter.Fill(this._Parking_B.Radnik);
            // TODO: This line of code loads data into the '_Parking_B.Parkirana_vozila' table. You can move, or remove it, as needed.
            this.parkirana_vozilaTableAdapter.Fill(this._Parking_B.Parkirana_vozila);

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            txtVreme.Text = DateTime.Now.ToString("hh:mm:ss");
            txtDatum.Text = DateTime.Now.ToString("dd/mm/yyyy");
            txtBrojMesta.Text = brojMesta.ToString();
            this.parkirana_vozilaTableAdapter.Fill(this._Parking_B.Parkirana_vozila);
        }

        private void btnIzlaz_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIzlaz.Text))
            {
                MessageBox.Show("Registarska tablica nije lepo uneta", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection konekcija = new SqlConnection(Konekcija.konString);

                SqlCommand komanda = new SqlCommand("DELETE FROM Parkirana_vozila where Registracija = @reg", konekcija);

                SqlParameter regParam = new SqlParameter("@reg", SqlDbType.NVarChar, 15);
                komanda.Parameters.Add(regParam);
                regParam.Value = txtIzlaz.Text;

                try
                {
                    konekcija.Open();
                    komanda.ExecuteNonQuery();
                    konekcija.Close();
                    brojMesta++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    brojMesta--;
                }
                txtIzlaz.Clear();
            }
        }

        private void btnPovlascena_Click_1(object sender, EventArgs e)
        {
            rtbIspis.Clear();

            SqlConnection konekcija = new SqlConnection(Konekcija.konString);

            SqlCommand komanda = new SqlCommand("SELECT * from Povlascena_vozila", konekcija);

            SqlDataReader citac = null;

            StringBuilder sb = new StringBuilder();

            try
            {
                konekcija.Open();

                citac = komanda.ExecuteReader();

                sb.Append("Registracija\tNaziv Preduzeca\n");

                while (citac.Read())
                {
                    sb.Append(citac[0].ToString() + "\t" + citac[1].ToString() + "\n");
                }

                konekcija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            rtbIspis.Text = sb.ToString();
        }

        private void brnInfo_Click_1(object sender, EventArgs e)
        {
            rtbIspis.Clear();

            SqlConnection konekcija = new SqlConnection(Konekcija.konString);

            SqlCommand komanda = new SqlCommand("SELECT * FROM Parking_Info", konekcija);

            SqlDataReader citac = null;

            StringBuilder sb = new StringBuilder();

            try
            {
                konekcija.Open();
                citac = komanda.ExecuteReader();
                sb.Append("ID Parkinga\tNaziv parkinga\tKapacitet\n");
                while (citac.Read())
                {
                    sb.Append(citac[0].ToString() + "\t\t" + citac[1].ToString() + "\t\t" + citac[2].ToString() + "\n");
                }
                konekcija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            rtbIspis.AppendText(sb.ToString());
        }

        private void btnPoternica_Click_1(object sender, EventArgs e)
        {
            rtbIspis.Clear();

            SqlConnection konekcija = new SqlConnection(Konekcija.konString);

            SqlCommand komanda = new SqlCommand("SELECT * from Vozila_sa_poternicom", konekcija);

            SqlDataReader citac = null;

            StringBuilder sb = new StringBuilder();

            try
            {
                konekcija.Open();

                citac = komanda.ExecuteReader();

                sb.Append("Registracija\n");

                while (citac.Read())
                {
                    sb.Append(citac[0].ToString() + "\n");
                }

                konekcija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            rtbIspis.Text = sb.ToString();
        }
    }
}
