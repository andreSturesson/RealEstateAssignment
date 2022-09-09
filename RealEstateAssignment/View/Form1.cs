using RealEstateAssignment.Appartment;
using static Enums;

namespace RealEstateAssignment
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            comboBox1.DataSource = Enums.contries.GetValues(typeof(contries));
            comboBox2.DataSource = Enums.types.GetValues(typeof(types));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estate state;
            state = new Apartment(15, new Address("Street", "City", 35591, "Sweden"));
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            sizeLabel.Visible = false;
            sizeTextBox.Visible = false;
            sizesqmLabel.Visible = false;
            roomsLabel.Visible = false;
            roomsTextBox.Visible = false;
            switch (comboBox2.SelectedItem.ToString())
            {
                case "Apartment":
                    sizeLabel.Visible = true;
                    sizeTextBox.Visible = true;
                    sizesqmLabel.Visible = true;
                    roomsLabel.Visible = true;
                    roomsTextBox.Visible = true;
                    break;
                case "Villa":
                    break;
                case "Rental":
                    break;
                case "Tenement":
                    break;
                case "Shop":
                    break;
                case "Warehouse":
                    break;
                default:
                    break;
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void sizeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}