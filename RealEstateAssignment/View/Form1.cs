using Microsoft.VisualBasic.ApplicationServices;
using RealEstateAssignment.Controller;
using RealEstateAssignment.Model;
using System.Diagnostics;
using System.Drawing.Text;
using System.Windows.Forms;
using static Enums;

namespace RealEstateAssignment
{
    public partial class Form1 : Form
    {
        private Estate estate;
        private EstateManager estates = new EstateManager();
        public Form1()
        {
            InitializeComponent();
            countryComboBox.DataSource = Enums.countries.GetValues(typeof(countries));
            countryInfoComboBox.DataSource = Enums.countries.GetValues(typeof(countries));
            comboBox2.DataSource = Enums.types.GetValues(typeof(types));
            garageComboBox.DataSource = Enums.hasGarage.GetValues(typeof(hasGarage));
            garageInfoComboBox.DataSource = Enums.hasGarage.GetValues(typeof(hasGarage));
            apartmentTypeComboBox.DataSource = Enums.legalType.GetValues(typeof(legalType));
            legalFormInfoComboBox.DataSource = Enums.legalType.GetValues(typeof(legalType));
        }

        public void updateGUI()
        {
            lstEstates.Items.Clear();
            lstEstates.Items.AddRange(estates.ToStringArray());
        }

        //Delete button to delete estate object..
        private void button3_Click(object sender, EventArgs e)
        {
            hideInfo();
            String id = lstEstates.GetItemText(lstEstates.SelectedItem).ToString().Split(" ").Last();
            estates.DeleteAt(id);
            updateGUI();
            /**AddressInfoGroup.Visible = false;
            displayseeEstate.Visible = true;
            errorText.Text = "";
            addButton.Visible = true;
            changeButton.Visible = false;
            imgBox.Visible = false;**/
        }

        //Method for changing object
        private void button1_Click_1(object sender, EventArgs e)
        {
            LegalForm legal;
            Address adress = new Address(streetTextBox.Text, cityTextBox.Text, Int32.Parse(zipCodeTextBox.Text), (countries)countryComboBox.SelectedItem);
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
                    showInfo(estate);
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
                    showInfo(estate);
                    break;
                case "Apartment":
                    estate.Change(new Apartment(adress, Int32.Parse(apartmentNumberTextBox.Text), Int32.Parse(roomsTextBox.Text), Int32.Parse(sizeTextBox.Text), legal, chooseImageTextBox.Text));
                    showInfo(estate);
                    break;
                case "University":
                    estate.Change(new University(adress, Int32.Parse(sizeTextBox.Text), legal, chooseImageTextBox.Text, Int32.Parse(plotSizeText.Text)));
                    showInfo(estate);
                    break;
                case "Schools":
                    estate.Change(new Shop(adress, Int32.Parse(sizeTextBox.Text), legal, chooseImageTextBox.Text, Int32.Parse(plotSizeText.Text)));
                    showInfo(estate);
                    break;
                case "Hospitals":
                    estate.Change(new Hospitals(adress, Int32.Parse(sizeTextBox.Text), legal, chooseImageTextBox.Text, Int32.Parse(plotSizeText.Text)));
                    showInfo(estate);
                    break;
                case "Warehouse":
                    estate.Change(new Warehouse(adress, Int32.Parse(sizeTextBox.Text), legal, chooseImageTextBox.Text, Int32.Parse(plotSizeText.Text)));
                    showInfo(estate);
                    break;
                case "Shop":
                    estate.Change(new Shop(adress, Int32.Parse(sizeTextBox.Text), legal, chooseImageTextBox.Text, Int32.Parse(plotSizeText.Text)));
                    showInfo(estate);
                    break;
                default:
                    break;
            }
            imgBox.Visible = true;
        }

        //Method for when chaning the combobox for type. shows relevant fields
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            setVisible(true);
            switch (comboBox2.SelectedItem.ToString())
            {
                case "Apartment":
                    garageComboBox.Visible = false;
                    garageLabel.Visible = false;
                    break;
                case "Villa":
                    apartmentNumberTextBox.Visible = false;
                    apartmentNumberLabel.Visible = false;
                    plotSizeLabel.Text = "Plot size";
                    break;
                case "Shop":
                    garageComboBox.Visible = false;
                    garageLabel.Visible = false;
                    apartmentNumberTextBox.Visible = false;
                    apartmentNumberLabel.Visible = false;
                    plotSizeLabel.Text = "Shelves";
                    break;
                case "Warehouse":
                    garageComboBox.Visible = false;
                    garageLabel.Visible = false;
                    apartmentNumberTextBox.Visible = false;
                    apartmentNumberLabel.Visible = false;
                    plotSizeLabel.Text = "Shelves";
                    break;
                case "Hospital":
                    garageComboBox.Visible = false;
                    garageLabel.Visible = false;
                    apartmentNumberTextBox.Visible = false;
                    apartmentNumberLabel.Visible = false;
                    plotSizeLabel.Text = "Capacity";
                    break;
                case "School":
                    garageComboBox.Visible = false;
                    garageLabel.Visible = false;
                    apartmentNumberTextBox.Visible = false;
                    apartmentNumberLabel.Visible = false;
                    plotSizeLabel.Text = "Capacity";
                    break;
                case "University":
                    garageComboBox.Visible = false;
                    garageLabel.Visible = false;
                    apartmentNumberTextBox.Visible = false;
                    apartmentNumberLabel.Visible = false;
                    plotSizeLabel.Text = "Capacity";
                    break;
                case "Rowhouse":
                    apartmentNumberTextBox.Visible = false;
                    apartmentNumberLabel.Visible = false;
                    plotSizeLabel.Text = "Plot size";
                    break;
                default:
                    break;
            }

        }

        private void setVisible(Boolean visible)
        {
            roomsLabel.Visible = visible;
            roomsTextBox.Visible = visible;
            sizeLabel.Visible = visible;
            sizeTextBox.Visible = visible;
            sizesqmLabel.Visible = visible;
            rentLabel.Visible = visible;
            rentLabelText.Visible = visible;
            browseFilesButton.Visible = visible;
            BrowseFilesLabel.Visible = visible;
            plotSizeText.Visible = visible;
            plotSizeLabel.Visible = visible;
            plotSizeLabel.Visible = visible;
            plotSizeText.Visible = visible;
            garageLabel.Visible = visible;
            garageComboBox.Visible = visible;
            apartmentTypeComboBox.Visible = visible;
            AppartmentTypeText.Visible = visible;
            browseFilesButton.Visible = visible;
            BrowseFilesLabel.Visible = visible;
            apartmentNumberLabel.Visible = visible;
            apartmentNumberTextBox.Visible = visible;
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
                if (streetTextBox.Text != "" && cityTextBox.Text != "" && zipCodeTextBox.Text != "" && countryComboBox.SelectedText.ToString() == "")
                {
                    switch (comboBox2.SelectedItem.ToString())
                    {
                        case "Apartment":
                            if (apartmentNumberTextBox.Text != "" && roomsTextBox.Text != "" && sizeTextBox.Text != "")
                            {
                                estate = new Apartment();
                                newEstate();
                                newResidential();
                                ((Apartment)estate).ApartmentNumber = Int32.Parse(apartmentNumberTextBox.Text);
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
                            break;
                        case "Shop":
                            estate = new Shop();
                            newEstate();
                            newCommercial();
                            break;
                        case "Warehouse":
                            estate = new Warehouse();
                            newEstate();
                            newCommercial();
                            break;
                        case "Rowhouse":
                            estate = new Rowhouse();
                            newEstate();
                            newResidential();
                            if (garageComboBox.SelectedItem.ToString() == "Yes")
                            {
                                ((Rowhouse)estate).Garage = true;
                            }
                            else
                            {
                                ((Rowhouse)estate).Garage = false;
                            }
                            ((Rowhouse)estate).Plot = plotSizeText.Text;
                            showInfo(estate);
                            break;
                        case "University":
                            estate = new University();
                            newEstate();
                            newInstitutional();
                            break;
                        case "School":
                            estate = new Schools();
                            newEstate();
                            newInstitutional();
                            break;
                        case "Hospital":
                            estate = new Hospitals();
                            newEstate();
                            newInstitutional();
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
                imgBox.Visible = true;
            } catch (Exception er)
            {
                errorText.Visible = true;
                errorText.Text = "ERROR - Some value is empty or incorrect " + er;
            }
            estates.Add(estate);
            updateGUI();
        }

        private void newEstate()
        {
            LegalForm legal;
            Address adress = new Address(streetTextBox.Text, cityTextBox.Text, Int32.Parse(zipCodeTextBox.Text), 
                (countries)countryComboBox.SelectedItem);
            if ((legalType)apartmentTypeComboBox.SelectedItem == legalType.Rental)
            {
                legal = new Rental(Int32.Parse(rentLabelText.Text));
            }
            else
            {
                legal = new Ownership(Int32.Parse(rentLabelText.Text));
            }
            estate.LegalForm = legal;
            estate.Address = adress;
            estate.Size = Int32.Parse(sizeTextBox.Text);
            estate.Img = chooseImageTextBox.Text;
            estate.Address = adress;

        }
        private void newResidential()
        {
            ((Residential)estate).Rooms = Int32.Parse(roomsTextBox.Text);
        }

        private void newInstitutional()
        {
            ((Institutional)estate).Capacity = Int32.Parse(plotSizeText.Text);
        }

        private void newCommercial()
        {
            ((Commercial)estate).Shelves = Int32.Parse(plotSizeText.Text);
        }

     

        private void showInfo(Estate estate)
        {

            hideInfo();


            estateInfoIsDisabled();
            estateInfoIsVisible();
            setEstateInfo(estate);
            

            switch (estate.getObjectType())
            {
                case "Apartment":

                    setResidentialInfo(estate);
                    residentialInfoIsDisabled();
                    residentialInfoIsVisible();

                    apartmentNumberInfoBox.Text = ((Apartment)estate).ApartmentNumber.ToString();
                    apartmentNumberInfoBox.Enabled = false;
                    apartmentNumberInfoBox.Visible = true;
                    break;

                case "Villa":

                    setResidentialInfo(estate);
                    residentialInfoIsDisabled();
                    residentialInfoIsVisible();

                    plotSizeInfoBox.Text = ((Villa)estate).Plot.ToString();
                    plotSizeInfoBox.Enabled = false;
                    plotSizeInfoBox.Visible = true;

                    if (((Villa)estate).Garage)
                    {
                        garageInfoComboBox.SelectedItem = hasGarage.Yes;
                    }
                    else
                    {
                        garageInfoComboBox.SelectedItem = hasGarage.No;
                    }
                    garageInfoComboBox.Enabled = false;
                    garageInfoComboBox.Visible = true;
                    break;
                case "Rowhouse":

                    setResidentialInfo(estate);
                    residentialInfoIsDisabled();
                    residentialInfoIsVisible();

                    plotSizeInfoBox.Text = ((Rowhouse)estate).Plot.ToString();
                    plotSizeInfoBox.Enabled = false;
                    plotSizeInfoBox.Visible = true;

                    if (((Villa)estate).Garage)
                    {
                        garageInfoComboBox.SelectedItem = hasGarage.Yes;
                    }
                    else
                    {
                        garageInfoComboBox.SelectedItem = hasGarage.No;
                    }
                    garageInfoComboBox.Enabled = false;
                    garageInfoComboBox.Visible = true;
                    break;

                case "Shop":

                    setCommercialInfo(estate);
                    commercialInfoIsDisabled();
                    commercialInfoIsVisible();
                    break;

                case "Warehouse":

                    setCommercialInfo(estate);
                    commercialInfoIsDisabled();
                    commercialInfoIsVisible();
                    break;

                case "University":
                    
                    setinstitutionalInfo(estate);
                    institutionalInfoIsDisabled();
                    institutionalInfoIsVisible();
                    break;

                case "School":

                    setinstitutionalInfo(estate);
                    institutionalInfoIsDisabled();
                    institutionalInfoIsVisible();
                    break;

                case "Hospital":

                    setinstitutionalInfo(estate);
                    institutionalInfoIsDisabled();
                    institutionalInfoIsVisible();
                    break;

                default:
                    break;
            }
        }

        private void hideInfo()
        {
            AddressInfoGroup.Visible = false;
            sizeInfoBox.Visible = false;
            legalFormInfoComboBox.Visible = false;
            costInfoBox.Visible = false;
            roomInfoBox.Visible = false;
            apartmentNumberInfoBox.Visible = false;
            plotSizeInfoBox.Visible = false;
            garageInfoComboBox.Visible = false;
            imgBox.Visible = false;
            shelvesInfoBox.Visible = false;
            capacityInfoBox.Visible = false;
        }

        private void estateInfoIsVisible()
        {
            AddressInfoGroup.Visible = true;
            sizeInfoBox.Visible = true;
            legalFormInfoComboBox.Visible = true;
            costInfoBox.Visible = true;
            imgBox.Visible = true;
        }

        private void residentialInfoIsVisible()
        {
            roomInfoBox.Visible = true;
        }

        private void commercialInfoIsVisible()
        {
            shelvesInfoBox.Visible = true;
        }

        private void institutionalInfoIsVisible()
        {
            capacityInfoBox.Visible = true;
        }

        private void estateInfoIsEnabled()
        {
            countryInfoComboBox.Enabled = true;
            cityInfoBox.Enabled = true;
            zipCodeInfoBox.Enabled = true;
            streetInfoBox.Enabled = true;
            sizeInfoBox.Enabled = true;
            legalFormInfoComboBox.Enabled = true;
            costInfoBox.Enabled = true;
        }

        private void residentialInfoIsEnabled()
        {
            roomInfoBox.Enabled = true;
        }

        private void commercialInfoIsEnabled()
        {
            shelvesInfoBox.Enabled = true;
        }

        private void institutionalInfoIsEnabled()
        {
            capacityInfoBox.Enabled = true;
        }

        private void estateInfoIsDisabled()
        {
            countryInfoComboBox.Enabled = false;
            cityInfoBox.Enabled = false;
            zipCodeInfoBox.Enabled = false;
            streetInfoBox.Enabled = false;
            sizeInfoBox.Enabled = false;
            legalFormInfoComboBox.Enabled = false;
            costInfoBox.Enabled = false;
        }

        private void residentialInfoIsDisabled()
        {
            roomInfoBox.Enabled = false;
        }

        private void commercialInfoIsDisabled()
        {
            shelvesInfoBox.Enabled = false;
        }

        private void institutionalInfoIsDisabled()
        {
            capacityInfoBox.Enabled = false;
        }

        private void setEstateInfo(Estate estate)
        {
            countryInfoComboBox.SelectedItem = estate.Address.Country;
            cityInfoBox.Text = estate.Address.City;
            zipCodeInfoBox.Text = estate.Address.ZipCode.ToString();
            streetInfoBox.Text = estate.Address.Street.ToString();
            sizeInfoBox.Text = estate.Size.ToString();
            if(estate.LegalForm.getType() == "Ownership")
            {
                legalFormInfoComboBox.SelectedItem = legalType.Ownership;
                costInfoBox.Text = ((Ownership)estate.LegalForm).Value.ToString();
            }
            else
            {
                legalFormInfoComboBox.SelectedItem = legalType.Rental;
                costInfoBox.Text = ((Rental)estate.LegalForm).Rent.ToString();
            }
            if(File.Exists(estate.Img))
            {
                imgBox.Image = Image.FromFile(estate.Img);
            }
            else
            {
                imgBox.Visible = false;
            }
        }

        private void setResidentialInfo(Estate estate)
        {
           roomInfoBox.Text = ((Residential)estate).Rooms.ToString();
        }

        private void setCommercialInfo(Estate estate)
        {
            shelvesInfoBox.Text = ((Commercial)estate).Shelves.ToString();
        }

        private void setinstitutionalInfo(Estate estate)
        {
            capacityInfoBox.Text = ((Institutional)estate).Capacity.ToString();
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
            String id = lstEstates.GetItemText(lstEstates.SelectedItem).ToString().Split(" ").Last();
            showInfo(estates.GetAt(id));

        }

        private void AppartmentTypeText_Click(object sender, EventArgs e)
        {

        }

        private void roomsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            estates.DeleteAll();
            updateGUI();
            hideInfo();
            displayseeEstate.Visible = true;

        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            estates.BinarySerialize(estates.Path);
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            openBinary.ShowDialog();
        }

        private void openBinary_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            estates.BinaryDeSerialize(openBinary.FileName);
            displayseeEstate.Visible = false;
            updateGUI();
            estates.Path = openBinary.FileName;
            mnuSave.Enabled = true;
        }

        private void saveBinarySer_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            estates.BinarySerialize(saveBinarySer.FileName);
            estates.Path = saveBinarySer.FileName;
            mnuSave.Enabled = true;
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            saveBinarySer.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
    }
    }