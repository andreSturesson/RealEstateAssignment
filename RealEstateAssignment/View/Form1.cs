using RealEstateAssignment.Controller;
using System.Diagnostics;
using System.Drawing.Text;
using System.Windows.Forms;
using static Enums;

namespace RealEstateAssignment
{
    public partial class Form1 : Form
    {
        private Estate estate;
        private ListManager lstManager = new ListManager();
        public Form1()
        {
            InitializeComponent();
            countryComboBox.DataSource = Enums.countries.GetValues(typeof(countries));
            comboBox2.DataSource = Enums.types.GetValues(typeof(types));
            garageComboBox.DataSource = Enums.hasGarage.GetValues(typeof(hasGarage));
            apartmentTypeComboBox.DataSource = Enums.apartmentType.GetValues(typeof(apartmentType));
        }

        public void updateGUI()
        {
            lstEstates.Items.Clear();
            lstEstates.Items.AddRange(lstManager.ToStringArray());
        }

        //Delete button to delete estate object..
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
            errorText.Text = "";
            addButton.Visible = true;
            changeButton.Visible = false;
            imgBox.Visible = false;
        }

        //Method for changing object
        private void button1_Click_1(object sender, EventArgs e)
        {
            LegalForm legal;
            Address adress = new Address(streetTextBox.Text, cityTextBox.Text, Int32.Parse(zipCodeTextBox.Text), countryComboBox.SelectedItem.ToString());
            if (apartmentTypeComboBox.SelectedItem.ToString() == "Tenement")
            {
                legal = new Rental(Int32.Parse(rentLabelText.Text));
            }
            else
            {
                legal = new Ownership(Int32.Parse(rentLabelText.Text));
            }
            switch (estate.getObjectType())
            {
                case "Villa":
                    Boolean garage;
                    if (garageComboBox.SelectedItem.ToString() == "Yes")
                    {
                        garage = true;
                    }
                    else
                    {
                        garage = false;
                    }
                    estate.Change(new Villa(adress, plotSizeText.Text, garage, Int32.Parse(roomsTextBox.Text), Int32.Parse(sizeTextBox.Text), legal, chooseImageTextBox.Text));
                    showVilla();
                    break;
                case "Rowhouse":
                    displayseeEstate.Visible = false;
                    Boolean ga;
                    if (garageComboBox.SelectedItem.ToString() == "Yes")
                    {
                        ga = true;
                    }
                    else
                    {
                        ga = false;
                    }
                    estate.Change(new Rowhouse(adress, plotSizeText.Text, ga, Int32.Parse(roomsTextBox.Text), Int32.Parse(sizeTextBox.Text), legal, chooseImageTextBox.Text));
                    showRowHouse();
                    break;
                case "Apartment":
                    estate.Change(new Apartment(adress, Int32.Parse(apartmentNumberTextBox.Text), Int32.Parse(roomsTextBox.Text), Int32.Parse(sizeTextBox.Text), legal, chooseImageTextBox.Text));
                    showApartment();
                    break;
                case "University":
                    estate.Change(new University(adress, Int32.Parse(sizeTextBox.Text), legal, chooseImageTextBox.Text, Int32.Parse(plotSizeText.Text)));
                    showUniversity();
                    break;
                case "Schools":
                    estate.Change(new Shop(adress, Int32.Parse(sizeTextBox.Text), legal, chooseImageTextBox.Text, Int32.Parse(plotSizeText.Text)));
                    showSchool();
                    break;
                case "Hospitals":
                    estate.Change(new Hospitals(adress, Int32.Parse(sizeTextBox.Text), legal, chooseImageTextBox.Text, Int32.Parse(plotSizeText.Text)));
                    showHospital();
                    break;
                case "Warehouse":
                    estate.Change(new Warehouse(adress, Int32.Parse(sizeTextBox.Text), legal, chooseImageTextBox.Text, Int32.Parse(plotSizeText.Text)));
                    showWarehouse();
                    break;
                case "Shop":
                    estate.Change(new Shop(adress, Int32.Parse(sizeTextBox.Text), legal, chooseImageTextBox.Text, Int32.Parse(plotSizeText.Text)));
                    showShop();
                    break;
                default:
                    break;
            }
            imgBox.Visible = true;
        }

        //Method for when chaning the combobox for type. shows relevant fields
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            sizeLabel.Visible = false;
            sizeTextBox.Visible = false;
            sizesqmLabel.Visible = false;
            plotSizeLabel.Visible = false;
            plotSizeText.Visible = false;
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
                    browseFilesButton.Visible = true;
                    BrowseFilesLabel.Visible = true;
                    apartmentNumberLabel.Visible = true;
                    apartmentNumberTextBox.Visible = true;
                    rentLabel.Visible = true;
                    rentLabelText.Visible = true;
                    apartmentTypeComboBox.Visible = true;
                    AppartmentTypeText.Visible = true;
                    break;
                case "Villa":
                    sizeLabel.Visible = true;
                    sizeTextBox.Visible = true;
                    sizesqmLabel.Visible = true;
                    roomsLabel.Visible = true;
                    roomsTextBox.Visible = true;
                    plotSizeLabel.Text = "Plot size";
                    plotSizeLabel.Visible = true;
                    plotSizeText.Visible = true;
                    garageLabel.Visible = true;
                    garageComboBox.Visible = true;
                    browseFilesButton.Visible = true;
                    BrowseFilesLabel.Visible = true;

                    //For legalform
                    rentLabel.Visible = true;
                    rentLabelText.Visible = true;
                    apartmentTypeComboBox.Visible = true;
                    AppartmentTypeText.Visible = true;
                    break;
                case "Shop":
                    sizeLabel.Visible = true;
                    sizeTextBox.Visible = true;
                    roomsLabel.Visible = true;
                    roomsTextBox.Visible = true;
                    plotSizeLabel.Text = "Shelves";
                    plotSizeLabel.Visible = true;
                    plotSizeText.Visible = true;
                    browseFilesButton.Visible = true;
                    BrowseFilesLabel.Visible = true;

                    //For legalform
                    rentLabel.Visible = true;
                    rentLabelText.Visible = true;
                    apartmentTypeComboBox.Visible = true;
                    AppartmentTypeText.Visible = true;
                    break;
                case "Warehouse":
                    sizeLabel.Visible = true;
                    sizeTextBox.Visible = true;
                    roomsLabel.Visible = true;
                    roomsTextBox.Visible = true;
                    plotSizeLabel.Text = "Shelves";
                    plotSizeLabel.Visible = true;
                    plotSizeText.Visible = true;
                    browseFilesButton.Visible = true;
                    BrowseFilesLabel.Visible = true;

                    //For legalform
                    rentLabel.Visible = true;
                    rentLabelText.Visible = true;
                    apartmentTypeComboBox.Visible = true;
                    AppartmentTypeText.Visible = true;
                    break;

                case "Hospital":
                    sizeLabel.Visible = true;
                    sizeTextBox.Visible = true;
                    rentLabel.Visible = true;
                    rentLabelText.Visible = true;
                    apartmentTypeComboBox.Visible = true;
                    AppartmentTypeText.Visible = true;
                    plotSizeLabel.Text = "Capacity";
                    plotSizeLabel.Visible = true;
                    plotSizeText.Visible = true;
                    browseFilesButton.Visible = true;
                    BrowseFilesLabel.Visible = true;
                    break;
                case "School":
                    sizeLabel.Visible = true;
                    sizeTextBox.Visible = true;
                    rentLabel.Visible = true;
                    rentLabelText.Visible = true;
                    apartmentTypeComboBox.Visible = true;
                    AppartmentTypeText.Visible = true;
                    plotSizeLabel.Text = "Capacity";
                    plotSizeLabel.Visible = true;
                    plotSizeText.Visible = true;
                    browseFilesButton.Visible = true;
                    BrowseFilesLabel.Visible = true;
                    break;
                case "University":
                    sizeLabel.Visible = true;
                    sizeTextBox.Visible = true;
                    rentLabel.Visible = true;
                    rentLabelText.Visible = true;
                    apartmentTypeComboBox.Visible = true;
                    AppartmentTypeText.Visible = true;
                    plotSizeLabel.Text = "Capacity";
                    plotSizeLabel.Visible = true;
                    plotSizeText.Visible = true;
                    browseFilesButton.Visible = true;
                    BrowseFilesLabel.Visible = true;
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
                    rentLabel.Visible = true;
                    rentLabelText.Visible = true;
                    rentLabel.Visible = true;
                    rentLabelText.Visible = true;
                    apartmentTypeComboBox.Visible = true;
                    AppartmentTypeText.Visible = true;
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
            switch (apartmentTypeComboBox.SelectedItem.ToString())
            {
                case "Tenement":
                    rentLabel.Text = "Value";
                    rentLabel.Visible = true;
                    rentLabelText.Visible = true;
                    break;
                case "Rental":
                    rentLabel.Text = "Rent";
                    rentLabel.Visible = true;
                    rentLabelText.Visible = true;
                    break;
                default:
                    break;
            }
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

        //Add an estate
        private void button2_Click(object sender, EventArgs e)
        {
            displayseeEstate.Visible = false;
            errorText.Visible = false;
            try
            {
                LegalForm legal;
                if (streetTextBox.Text != "" && cityTextBox.Text != "" && zipCodeTextBox.Text != "" && countryComboBox.SelectedText.ToString() == "")
                {
                    Address adress = new Address(streetTextBox.Text, cityTextBox.Text, Int32.Parse(zipCodeTextBox.Text), countryComboBox.SelectedItem.ToString());
                    if (apartmentTypeComboBox.SelectedItem.ToString() == "Tenement")
                    {
                        legal = new Rental(Int32.Parse(rentLabelText.Text));
                    }
                    else
                    {
                        legal = new Ownership(Int32.Parse(rentLabelText.Text));
                    }
                    switch (comboBox2.SelectedItem.ToString())
                    {
                        case "Apartment":
                            if (apartmentNumberTextBox.Text != "" && roomsTextBox.Text != "" && sizeTextBox.Text != "")
                            {
                                lstManager.Add(new Apartment(adress, Int32.Parse(apartmentNumberTextBox.Text), Int32.Parse(roomsTextBox.Text), Int32.Parse(sizeTextBox.Text), legal, chooseImageTextBox.Text));
                                showApartment();
                            }
                            else
                            {
                                errorText.Text = "ERROR - No fields can be empty";
                            }
                            break;
                        case "Villa":
                            estate = new Villa();
                            newEstate();
                            newResidential();
                            if (garageComboBox.SelectedItem.ToString() == "Yes")
                            {
                                ((Villa)estate).Garage = true;
                            }
                            else
                            {
                                ((Villa)estate).Garage = false;
                            }
                            ((Villa)estate).Plot = plotSizeText.Text;
                            showVilla();
                            break;
                        case "Shop":
                            estate = new Shop(adress, Int32.Parse(sizeTextBox.Text), legal, chooseImageTextBox.Text, Int32.Parse(plotSizeText.Text));
                            showShop();
                            break;
                        case "Warehouse":
                            estate = new Warehouse(adress, Int32.Parse(sizeTextBox.Text), legal, chooseImageTextBox.Text, Int32.Parse(plotSizeText.Text));

                            showWarehouse();
                            break;
                        case "Rowhouse":
                            Boolean ga;
                            if (garageComboBox.SelectedItem.ToString() == "Yes")
                            {
                                ga = true;
                            }
                            else
                            {
                                ga = false;
                            }
                            estate = new Rowhouse(adress, plotSizeText.Text, ga, Int32.Parse(roomsTextBox.Text), Int32.Parse(sizeTextBox.Text), legal, chooseImageTextBox.Text);
                            showRowHouse();
                            break;
                        case "University":
                            estate = new University(adress,Int32.Parse(sizeTextBox.Text),legal, chooseImageTextBox.Text, Int32.Parse(plotSizeText.Text));
                            showUniversity();
                            break;
                        case "School":
                            estate = new Schools(adress, Int32.Parse(sizeTextBox.Text), legal, chooseImageTextBox.Text, Int32.Parse(plotSizeText.Text));
                            showSchool();
                            break;
                        case "Hospital":
                            estate = new Hospitals(adress, Int32.Parse(sizeTextBox.Text), legal, chooseImageTextBox.Text, Int32.Parse(plotSizeText.Text));
                            showHospital();
                            break;
                        default:
                            break;

                    }
                    addButton.Visible = false;
                    changeButton.Visible = true;
                }
                else
                {
                    errorText.Visible = true;
                    errorText.Text = "ERROR - Something in address is empty";
                }
                imgBox.Visible = true;
            } catch (Exception er)
            {
                errorText.Visible = true;
                errorText.Text = "ERROR - Some value is empty or incorrect " + er;
            }
            updateGUI();
        }

        private void newEstate()
        {
            LegalForm legal;
            Address adress = new Address(streetTextBox.Text, cityTextBox.Text, Int32.Parse(zipCodeTextBox.Text), 
                countryComboBox.SelectedItem.ToString());
            if (apartmentTypeComboBox.SelectedItem.ToString() == "Tenement")
            {
                legal = new Rental(Int32.Parse(rentLabelText.Text));
            }
            else
            {
                legal = new Ownership(Int32.Parse(rentLabelText.Text));
            }
            estate.Size = Int32.Parse(sizeTextBox.Text);
            estate.Img = chooseImageTextBox.Text;



        }
        private void newResidential()
        {
            ((Residential)estate).Rooms = Int32.Parse(roomsTextBox.Text);
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
            String ty;
            LegalForm le = estate.LegalForm;
            if (((Apartment)estate).LegalForm.getType() == "Ownership")
            {
                ty = "Estate finance: Owned" + "\r\n" + "Property is valued: " + ((Ownership)le).Value.ToString() + "$";
            }
            else
            {
                ty = "Estate finance - Rental" + "\r\n" + "Rent: " + ((Rental)le).Rent.ToString() + "$ per month";
            }
            displayEstateText.Text = "Size: " + ((Apartment)estate).Size.ToString() + "\r\n" + "Apartment Number: " + 
                ((Apartment)estate).ApartmentNumber + "\r\n" + "Number of rooms: " + ((Apartment)estate).Rooms.ToString() + "\r\n" + ty;
            displayEstateText.Visible = true;
            imgBox.Image = Image.FromFile(((Apartment)estate).Img);
            showAdress();
        }

        private void showVilla()
        {
            String ty;
            LegalForm le = estate.LegalForm;
            if (((Villa)estate).LegalForm.getType() == "Ownership")
            {
                ty = "Estate finance: Owned" + "\r\n" + "Property is valued: " + ((Ownership)le).Value.ToString() + "$";
            }
            else
            {
                ty = "Estate finance - Rental" + "\r\n" + "Rent: " + ((Rental)le).Rent.ToString() + "$ per month";
            }
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
            displayEstateText.Text = "Size: " + ((Villa)estate).Size + "\r\n" + "Total land size: " + ((Villa)estate).Plot + 
                "\r\n" + "Number of rooms: " + ((Villa)estate).Rooms + "\r\n" + "Garage: " + hasGarage + "\r\n" + ty;
            showAdress();
            imgBox.Image = Image.FromFile(((Villa)estate).Img);
        }

        private void showRowHouse()
        {
            String ty;
            LegalForm le = estate.LegalForm;
            if (((Rowhouse)estate).LegalForm.getType() == "Ownership")
            {
                ty = "Estate finance: Owned" + "\r\n" + "Property is valued: " + ((Ownership)le).Value.ToString() + "$";
            }
            else
            {
                ty = "Estate finance - Rental" + "\r\n" + "Rent: " + ((Rental)le).Rent.ToString() + "$ per month";
            }
            displayEstateText.Visible = true;
            string hasGarage;
            if (((Rowhouse)estate).Garage == true)
            {
                hasGarage = "Yes";
            }
            else
            {
                hasGarage = "No";
            }
            displayEstateText.Text = "Size: " + ((Rowhouse)estate).Size + "\r\n" + "Total land size: " + ((Rowhouse)estate).Plot + "\r\n" + "Number of rooms: " + ((Rowhouse)estate).Rooms + "\r\n" + "Garage: " + hasGarage + "\r\n" + ty;
            showAdress();
            imgBox.Image = Image.FromFile(((Rowhouse)estate).Img);

        }

        private void showShop()
        {
            String ty;
            LegalForm le = estate.LegalForm;
            if (((Shop)estate).LegalForm.getType() == "Ownership")
            {
                ty = "Estate finance: Owned" + "\r\n" + "Property is valued: " + ((Ownership)le).Value.ToString() + "$";
            }
            else
            {
                ty = "Estate finance - Rental" + "\r\n" + "Rent: " + ((Rental)le).Rent.ToString() + "$ per month";
            }
            displayEstateText.Visible = true;
            displayEstateText.Text = "Size: " + ((Shop)estate).Size + "\r\n" + "Shelves: " + ((Shop)estate).Shelves + "\r\n" + ty;
            showAdress();
            imgBox.Image = Image.FromFile(((Shop)estate).Img);
        }
        private void showWarehouse()
        {
            String ty;
            LegalForm le = estate.LegalForm;
            if (((Warehouse)estate).LegalForm.getType() == "Ownership")
            {
                ty = "Estate finance: Owned" + "\r\n" + "Property is valued: " + ((Ownership)le).Value.ToString() + "$";
            }
            else
            {
                ty = "Estate finance - Rental" + "\r\n" + "Rent: " + ((Rental)le).Rent.ToString() + "$ per month";
            }
            displayEstateText.Visible = true;
            displayEstateText.Text = "Size: " + ((Warehouse)estate).Size + "\r\n" + "Shelves: " + ((Warehouse)estate).Shelves + "\r\n" + ty;
            showAdress();
            imgBox.Image = Image.FromFile(((Warehouse)estate).Img);
        }

        private void showUniversity()
        {
            String ty;
            LegalForm le = estate.LegalForm;
            if (((University)estate).LegalForm.getType() == "Ownership")
            {
                ty = "Estate finance: Owned" + "\r\n" + "Property is valued: " + ((Ownership)le).Value.ToString() + "$";
            }
            else
            {
                ty = "Estate finance - Rental" + "\r\n" + "Rent: " + ((Rental)le).Rent.ToString() + "$ per month";
            }
            displayEstateText.Visible = true;
            displayEstateText.Text = "Size: " + ((University)estate).Size + "\r\n" + "Capacity: " + ((University)estate).Capacity + "\r\n" + ty;
            showAdress();
            imgBox.Image = Image.FromFile(((University)estate).Img);
        }
        private void showSchool()
        {
            String ty;
            LegalForm le = estate.LegalForm;
            if (((Schools)estate).LegalForm.getType() == "Ownership")
            {
                ty = "Estate finance: Owned" + "\r\n" + "Property is valued: " + ((Ownership)le).Value.ToString() + "$";
            }
            else
            {
                ty = "Estate finance - Rental" + "\r\n" + "Rent: " + ((Rental)le).Rent.ToString() + "$ per month";
            }

            displayEstateText.Visible = true;
            displayEstateText.Text = "Size: " + ((Schools)estate).Size + "\r\n" + "Capacity: " + ((Schools)estate).Capacity + "\r\n" + ty;
            showAdress();
            imgBox.Image = Image.FromFile(((Schools)estate).Img);
        }
        private void showHospital()
        {
            String ty;
            LegalForm le = estate.LegalForm;
            if (((Hospitals)estate).LegalForm.getType() == "Ownership")
            {
                ty = "Estate finance: Owned" + "\r\n" + "Property is valued: " + ((Ownership)le).Value.ToString() + "$";
            }
            else
            {
                ty = "Estate finance - Rental" + "\r\n" + "Rent: " + ((Rental)le).Rent.ToString() + "$ per month";
            }
            displayEstateText.Visible = true;
            displayEstateText.Text = "Size: " + ((Hospitals)estate).Size + "\r\n" + 
                "Capacity: " + ((Hospitals)estate).Capacity + "\r\n" + ty;
            showAdress();
            imgBox.Image = Image.FromFile(((Hospitals)estate).Img);
        }

        //Errortext
        private void errorText_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void chooseImageTextBox_TextChanged(object sender, EventArgs e)
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
        private void image_Click(object sender, EventArgs e)
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

        private void rentLabelText_TextChanged(object sender, EventArgs e)
        {

        }

        private void plotSizeLabel_Click(object sender, EventArgs e)
        {

        }

        private void imgBox_Click(object sender, EventArgs e)
        {

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
        private void BrowseFilesLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lstEstates_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }