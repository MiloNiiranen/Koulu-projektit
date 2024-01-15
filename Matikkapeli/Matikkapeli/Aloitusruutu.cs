namespace Matikkapeli
{
    public partial class Aloitusruutu : Form
    {
        public Aloitusruutu()
        {
            InitializeComponent();
        }

        private void Plusnappi_Click(object sender, EventArgs e)
        {
            Plustehtavat form2 = new Plustehtavat();
            this.Hide();
            form2.ShowDialog();

        }

        private void Miinusnappi_Click(object sender, EventArgs e)
        {
            Miinustehtavat form3 = new Miinustehtavat();
            this.Hide();
            form3.ShowDialog();
        }

        private void Kertonappi_Click(object sender, EventArgs e)
        {
            Kertotehtavat form4 = new Kertotehtavat();
            this.Hide();
            form4.ShowDialog();
        }

        private void jakonappi_Click(object sender, EventArgs e)
        {
            jakotehtavat form5 = new jakotehtavat();
            this.Hide();
            form5.ShowDialog();
        }
    }
}