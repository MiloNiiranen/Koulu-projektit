using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matikkapeli
{
    public partial class Plustehtavat : Form
    {
        int _aika; 
        int _oikeaVastaus;
        private int _oikeidenVastaustenLaskuri = 0;
        List<int> _ajat;
        MathUtility mathUtility;


        public  Plustehtavat()
        {
            InitializeComponent();
            mathUtility = new MathUtility(); 
            _ajat = new List<int>();

            timer1.Start();
            lasku();

            LataaAjat();
            AsetaParasAikaLabelille();
        }

        private void LataaAjat()
        { 
           _ajat = mathUtility.LataaAjatPlus();
        }

        private void AsetaParasAikaLabelille()
        {
            if (_ajat.Count > 0)
            {
                int pieninAika = _ajat.Min();
                int minuutit = pieninAika / 60;
                int sekuntit = pieninAika % 60;

                labelParasaikaPlus.Text = $"Paras aika: {minuutit:D2}:{sekuntit:D2}";
            }
            else
            {
                labelParasaikaPlus.Text = "Paras aika: -";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int t = _aika++;
            int minuutit = _aika / 60;
            int sekunnit = _aika % 60;
            Ajastin.Text = string.Format("{0:D2}:{1:D2}", minuutit, sekunnit);
            // Ajastin joka näyttää minuutit ja sekunnit labelillä
        }
        private int ArvoLuku()
        {
            Random random = new Random();
            return random.Next(1, 11);
            // Arpoo luvun 1-10 välillä
        }

        private void lasku() // tämä kirjoitaa labeliin laskun mikä käyttäjän pitää laskea
        {
            int luku1 = ArvoLuku();
            int luku2 = ArvoLuku();
            _oikeaVastaus = luku1 + luku2;

            laskulabel.Text = $"{luku1} + {luku2} =";
        }
        private void tarkistusnappi_Click(object sender, EventArgs e) // nappi joka tarkistaa onko texboxin syöte oikein
        {
            if (int.TryParse(vastausTextBox.Text, out int kayttajanVastaus))
            {
                if (kayttajanVastaus == _oikeaVastaus) // Jos oikein
                {
                    OikeinAani();
                    lasku();
                    vastausTextBox.Clear();
                    _oikeidenVastaustenLaskuri++;
                    tehtäviätehty.Text = $"{_oikeidenVastaustenLaskuri}";
                }

                else // Jos väärin
                {
                    vaarinAani();
                    vastausTextBox.Clear();
                }

                if (_oikeidenVastaustenLaskuri == 10) // Kun saanut kymmenen laskua oikein niin resetoi ajastimen ja kuinka monta tehtävää tehty
                {

                    timer1.Stop();
                    MessageBox.Show($"Aikasi on {_aika / 60} minuutti ja {_aika % 60} sekunttia");
                    mathUtility.TallennaAikaPlus(_aika);
                    _aika = 0;
                    timer1.Start();
                    _oikeidenVastaustenLaskuri = 0;
                    tehtäviätehty.Text = "0";
                }
            }
        }

        private void OikeinAani()
        {
            SoundPlayer aani = new SoundPlayer(Matikkapeli.Properties.Resources._1450b9bc_16c5_4e33_bdae_e80ac2344bc7);
            aani.Play();
        }

        private void vaarinAani()
        {
            SoundPlayer aani = new SoundPlayer(Matikkapeli.Properties.Resources._2aa79859_239d_45f3_99c8_3cacd6a4c3a0);
            aani.Play();
        }

        private void Takaisinnappi_Click(object sender, EventArgs e)
        {
            Aloitusruutu form1 = new Aloitusruutu();
            this.Hide();
            this.Close();
            form1.ShowDialog();
            // Nappi joka vie takaisin aloitus ruutuun
        }
    }
}