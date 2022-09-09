namespace RealEstateAssignment
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            comboBox1.DataSource = Enum.GetValues(typeof(Countries));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estate state;
            state = new Apartment(15, new Address("Street", "City", 35591, Countries.Bangladesh), 1, 1, 1, new LegalForm());
            Console.Write(state);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void test_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}