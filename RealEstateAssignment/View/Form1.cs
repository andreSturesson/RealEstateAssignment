using RealEstateAssignment.Appartment;
using System.Diagnostics;
using System.Drawing.Text;
using System.Windows.Forms;
using static Enums;

namespace RealEstateAssignment
{
    public partial class Form1 : Form
    {
        private EstateManager em;

        public Form1()
        {
            InitializeComponent();

            countryComboBox.DataSource = Enums.countries.GetValues(typeof(countries));
            comboBox2.DataSource = Enums.types.GetValues(typeof(types));
            garageComboBox.DataSource = Enums.hasGarage.GetValues(typeof(hasGarage));
            apartmentTypeComboBox.DataSource = Enums.apartmentType.GetValues(typeof(apartmentType));
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Estate state;
            state = new Apartment(15, new Address("Street", "City", 35591, Enums.countries.Somalia), 1, 1, 1, new LegalForm());
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
            plotSizeLabel.Visible = false;
            plotSizeText.Visible = false;
            rentLabel.Visible = false;
            rentLabelText.Visible = false;
            garageLabel.Visible = false;
            garageComboBox.Visible = false;
            apartmentTypeComboBox.Visible = false;
            AppartmentTypeText.Visible = false;
            browseFilesButton.Visible = false;
            BrowseFilesLabel.Visible = false;
            apartmentNumberLabel.Visible = false;
            apartmentNumberTextBox.Visible = false;
            switch (comboBox2.SelectedItem.ToString())
            {
                case "Apartment":
                    sizeLabel.Visible = true;
                    sizeTextBox.Visible = true;
                    sizesqmLabel.Visible = true;
                    roomsLabel.Visible = true;
                    roomsTextBox.Visible = true;
                    apartmentTypeComboBox.Visible = true;
                    AppartmentTypeText.Visible = true;
                    browseFilesButton.Visible = true;
                    BrowseFilesLabel.Visible = true;
                    apartmentNumberLabel.Visible = true;
                    apartmentNumberTextBox.Visible = true;
                    break;
                case "Villa":
                    sizeLabel.Visible = true;
                    sizeTextBox.Visible = true;
                    sizesqmLabel.Visible = true;
                    roomsLabel.Visible = true;
                    roomsTextBox.Visible = true;
                    plotSizeLabel.Visible = true;
                    plotSizeText.Visible = true;
                    garageLabel.Visible = true;
                    garageComboBox.Visible = true;
                    browseFilesButton.Visible = true;
                    BrowseFilesLabel.Visible = true;
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

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void plotSizeText_TextChanged(object sender, EventArgs e)
        {

        }

        private void garageLabel_Click(object sender, EventArgs e)
        {

        }

        private void apartmentTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rentLabel.Visible = false;
            rentLabelText.Visible = false;
            switch (apartmentTypeComboBox.SelectedItem.ToString())
            {
                case "Tenement":

                    break;
                case "Rental":
                    rentLabel.Visible = true;
                    rentLabelText.Visible = true;
                    break;
                default:
                    break;
            }
        }
        private void BrowseFilesLabel_Click(object sender, EventArgs e)
        {

        }

        private void browseFilesButton_Click(object sender, EventArgs e)
        {
            chooseImageFile.ShowDialog();
        }

        private void chooseImageFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            chooseImageTextBox.Text = chooseImageFile.FileName;
            image.Load(chooseImageFile.FileName);
        }

        private void chooseImageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void image_Click(object sender, EventArgs e)
        {
            
        }

        //Add an estate
        private void button2_Click(object sender, EventArgs e)
        {
            //Address adress = new Address(streetTextBox.Text, cityTextBox.Text, Int32.Parse(zipCodeTextBox.Text), countryComboBox.SelectedItem.ToString);
            switch (comboBox2.SelectedItem.ToString())
            {
                case "Apartment":

                    String size = sizeTextBox.Text;
                    String rooms = roomsTextBox.Text;


                    break;
                case "Villa":
                    break;
                case "Shop":
                    break;
                case "Warehouse":
                    break;
                default:
                    break;
            }

        }

        //Errortext
        private void errorText_Click(object sender, EventArgs e)
        {

        }
    }
}