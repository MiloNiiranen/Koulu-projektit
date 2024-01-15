using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matikkapeli
{
    public partial class Miinustehtavat : Form
    {
        int _aika;
        int _oikeaVastaus;
        private int _oikeidenVastaustenLaskuri = 0;
        List<int> _ajat;
        MathUtility mathUtility;

        public Miinustehtavat()
        {
            InitializeComponent();
            mathUtility = new MathUtility();
            _ajat = new List<int>();

            timer2.Start();
            lasku();

            LataaAjat();
            AsetaParasAikaLabelille();
        }

        private void LataaAjat()
        {
            _ajat = mathUtility.LataaAjatMiinus();
        }

        private void AsetaParasAikaLabelille()
        {
            if (_ajat.Count > 0)
            {
                int pieninAika = _ajat.Min();
                int minuutit = pieninAika / 60;
                int sekuntit = pieninAika % 60;

                labelParasaikaMiinus.Text = $"Paras aika: {minuutit:D2}:{sekuntit:D2}";
            }
            else
            {
                labelParasaikaMiinus.Text = "Paras aika: -";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int t = _aika++;
            int minuutit = _aika / 60;
            int sekunnit = _aika % 60;
            Ajastinlabel2.Text = string.Format("{0:D2}:{1:D2}", minuutit, sekunnit);




        }
        private int ArvoLuku()
        {
            Random random = new Random();
            return random.Next(1, 11);
        }

        private void lasku() // tämä kirjoitaa labeliin laskun mikä käyttäjän pitää laskea
        {
            int luku1 = ArvoLuku();
            int luku2 = ArvoLuku();
            _oikeaVastaus = luku1 - luku2;

            laskulabel2.Text = $"{luku1} - {luku2} =";
        }
        private void tarkistusnappi_Click(object sender, EventArgs e)
        {
            if (int.TryParse(vastausTextBox2.Text, out int kayttajanVastaus))
            {
                if (kayttajanVastaus == _oikeaVastaus)
                {
                    OikeinAani();
                    lasku();
                    vastausTextBox2.Clear();
                    _oikeidenVastaustenLaskuri++;
                    tehtäviätehty2.Text = $"{_oikeidenVastaustenLaskuri}";
                }

                else
                {
                    vaarinAani();
                    vastausTextBox2.Clear();
                }

                if (_oikeidenVastaustenLaskuri == 10)
                {
                    timer2.Stop();
                    MessageBox.Show($"Aikasi on {_aika / 60} minuutti ja {_aika % 60} sekunttia");
                    mathUtility.TallennaAikaMiinus(_aika);
                    _aika = 0;
                    timer2.Start();
                    _oikeidenVastaustenLaskuri = 0;
                    tehtäviätehty2.Text = "0";
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
        }

    }
}