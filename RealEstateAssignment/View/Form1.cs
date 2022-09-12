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
            DisplayAddressGroup.Visible = false;
            displayCountry.Visible = false;
            displayCity.Visible = false;
            displayStreet.Visible = false;
            displayZipcode.Visible = false;
            displayEstateText.Visible = false;
            displayseeEstate.Visible = true;
            estate = null;
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
                            showApartment();
                        }
                        else
                        {
                            errorText.Text = "ERROR - No fields can be empty";
                        }
                        break;
                    case "Villa":
                        estate = new Villa(adress, plotSizeText.Text, Convert.ToBoolean(garageComboBox.Text), Int32.Parse(roomsTextBox.Text), Int32.Parse(sizeTextBox.Text),legalform);
                        showVilla();
                        break;
                    case "Shop":
                        showShop();
                        break;
                    case "Warehouse":
                        showWarehouse();
                        break;
                    case "Rowhouse":
                        showRowHouse();
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

        private void showAdress()
        {
            DisplayAddressGroup.Visible = true;
            displayCountry.Visible = true;
            displayCity.Visible = true;
            displayStreet.Visible = true;
            displayZipcode.Visible = true;
            displayCountry.Text = "Country: " + estate.Address.Country;
            displayCity.Text = "City: " + estate.Address.City;
            displayZipcode.Text = "Zip code: " +estate.Address.ZipCode.ToString();
            displayStreet.Text = "Street: " + estate.Address.Street;
        }

        private void showApartment()
        {
            displayEstateText.Visible = true;
            displayEstateText.Text = "Size: " + ((Apartment)estate).Size.ToString() + "\r\n" + "Apartment Number: " + ((Apartment)estate).ApartmentNumber + "\r\n" + "Number of rooms: " + ((Apartment)estate).Rooms.ToString() + "\r\n";
            showAdress();

        }

        private void showVilla()
        {
            displayEstateText.Visible = true;
            showAdress();
        }

        private void showRowHouse()
        {
            displayEstateText.Visible = true;
            string hasGarage;
            if (((Villa)estate).Garage == true)
            {
                hasGarage = "Yes";
            }
            else
            {
                hasGarage = "No";
            }
            displayEstateText.Text = "Size: " + ((Villa)estate).Size + "\r\n" + "Total land size: " + ((Villa)estate).Plot + "\r\n" + "Number of rooms: " + ((Villa)estate).Rooms + "\r\n" + "Garage: " + hasGarage;
            showAdress();

        }

        private void showShop()
        {
            displayEstateText.Visible = true;
            displayEstateText.Text = "Size: " + "\r\n" + "Total land size: " + "\r\n" + "Number of rooms: " + "\r\n";
            showAdress();
        }
        private void showWarehouse()
        {
            displayEstateText.Visible = true;
            displayEstateText.Text = "Size: " + "\r\n" + "Total land size: " + "\r\n" + "Number of rooms: " + "\r\n";
            showAdress();
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayAddressGroup_Enter(object sender, EventArgs e)
        {

        }

        private void displayseeEstate_Click(object sender, EventArgs e)
        {

        }
    }
}