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
                MessageBox.Show("Pojemno�� naczynia musi by� liczb�.");
                return;
            }

            if (!double.TryParse(textBox2.Text, out percentageContent))
            {
                MessageBox.Show("Zawarto�� procentowa musi by� liczb�.");
                return;
            }

            if ( !double.TryParse(textBox3.Text, out numberOfVessels))
            {
                MessageBox.Show("Liczba naczy� musi by� liczb�.");
                return;
            }

            if (capacity <= 0 || percentageContent < 0 || numberOfVessels <= 0)
            {
                MessageBox.Show("Wszystkie warto�ci musz� by� dodatnie.");
                return;
            }




        }

        
    }
}
