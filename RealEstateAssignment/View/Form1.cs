using RealEstateAssignment.Appartment;
using System.Diagnostics;
using System.Drawing.Text;
using System.Windows.Forms;
using static Enums;

namespace RealEstateAssignment
{
    public partial class Form1 : Form
    {
        private Estate estate;

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
                case "Rowhouse":
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
            if (streetTextBox.Text != "" && cityTextBox.Text != "" && zipCodeTextBox.Text != "" && countryComboBox.SelectedText == "")
            {
                Address adress = new Address(streetTextBox.Text, cityTextBox.Text, Int32.Parse(zipCodeTextBox.Text), countryComboBox.SelectedText);
                LegalForm legalform = new LegalForm();
                switch (comboBox2.SelectedItem.ToString())
                {
                    case "Apartment":
                        if (apartmentNumberTextBox.Text != "" && roomsTextBox.Text != "" && sizeTextBox.Text != "")
                        {
                            estate = new Apartment(adress, Int32.Parse(apartmentNumberTextBox.Text), Int32.Parse(roomsTextBox.Text), Int32.Parse(sizeTextBox.Text), legalform);
                            displayseeEstate.Visible = false;
                            //Address
                            displayCountry.Visible = true;
                            displayCity.Visible = true;
                            displayStreet.Visible = true;
                            displayZipcode.Visible = true;

                            displaySize.Visible = true;
                            displayPlotSize.Visible = true;
                            displayRooms.Visible = true;
                        }
                        else
                        {
                            errorText.Text = "ERROR - No fields can be empty";
                        }
                        break;
                    case "Villa":
                        estate = new Villa(adress, plotSizeText.Text, Convert.ToBoolean(garageComboBox.Text), Int32.Parse(roomsTextBox.Text), Int32.Parse(sizeTextBox.Text),legalform);
                        break;
                    case "Shop":
                        break;
                    case "Warehouse":
                        break;
                    case "Rowhouse":
                        estate = new Rowhouse(adress, plotSizeText.Text, Convert.ToBoolean(garageComboBox.Text), Int32.Parse(roomsTextBox.Text), Int32.Parse(sizeTextBox.Text), legalform);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                errorText.Visible = true;
                errorText.Text = "ERROR - Something in address is empty";
            }

        }

        //Errortext
        private void errorText_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }
    }
}