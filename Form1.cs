namespace LAB03
{
    public partial class Kalkulator_procentowy_roztworu : Form
    {
        public Kalkulator_procentowy_roztworu()
        {
            InitializeComponent();
        }





        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double capacity;
            double percentageContent;
            double numberOfVessels;

            if (!double.TryParse(textBox1.Text, out capacity))
            {
                MessageBox.Show("Pojemnoœæ naczynia musi byæ liczb¹.");
                return;
            }

            if (!double.TryParse(textBox2.Text, out percentageContent))
            {
                MessageBox.Show("Zawartoœæ procentowa musi byæ liczb¹.");
                return;
            }

            if ( !double.TryParse(textBox3.Text, out numberOfVessels))
            {
                MessageBox.Show("Liczba naczyñ musi byæ liczb¹.");
                return;
            }

            if (capacity <= 0 || percentageContent < 0 || numberOfVessels <= 0)
            {
                MessageBox.Show("Wszystkie wartoœci musz¹ byæ dodatnie.");
                return;
            }




        }

        
    }
}
