namespace RealEstateAssignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.apartmentNumberTextBox = new System.Windows.Forms.TextBox();
            this.apartmentNumberLabel = new System.Windows.Forms.Label();
            this.chooseImageTextBox = new System.Windows.Forms.TextBox();
            this.browseFilesButton = new System.Windows.Forms.Button();
            this.BrowseFilesLabel = new System.Windows.Forms.Label();
            this.apartmentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.AppartmentTypeText = new System.Windows.Forms.Label();
            this.garageComboBox = new System.Windows.Forms.ComboBox();
            this.garageLabel = new System.Windows.Forms.Label();
            this.plotSizeText = new System.Windows.Forms.TextBox();
            this.plotSizeLabel = new System.Windows.Forms.Label();
            this.rentLabelText = new System.Windows.Forms.TextBox();
            this.rentLabel = new System.Windows.Forms.Label();
            this.sizesqmLabel = new System.Windows.Forms.Label();
            this.roomsTextBox = new System.Windows.Forms.TextBox();
            this.roomsLabel = new System.Windows.Forms.Label();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.streetLabel = new System.Windows.Forms.Label();
            this.zipcodeLabel = new System.Windows.Forms.Label();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.type = new System.Windows.Forms.Label();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.displayseeEstate = new System.Windows.Forms.Label();
            this.DisplayAddressGroup = new System.Windows.Forms.GroupBox();
            this.displayStreet = new System.Windows.Forms.Label();
            this.displayCountry = new System.Windows.Forms.Label();
            this.displayZipcode = new System.Windows.Forms.Label();
            this.displayCity = new System.Windows.Forms.Label();
            this.displayEstateText = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.chooseImageFile = new System.Windows.Forms.OpenFileDialog();
            this.errorText = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.DisplayAddressGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(562, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your estate";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Address});
            this.dataGridView1.Location = new System.Drawing.Point(0, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(271, 398);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.apartmentNumberTextBox);
            this.groupBox2.Controls.Add(this.apartmentNumberLabel);
            this.groupBox2.Controls.Add(this.chooseImageTextBox);
            this.groupBox2.Controls.Add(this.browseFilesButton);
            this.groupBox2.Controls.Add(this.BrowseFilesLabel);
            this.groupBox2.Controls.Add(this.apartmentTypeComboBox);
            this.groupBox2.Controls.Add(this.AppartmentTypeText);
            this.groupBox2.Controls.Add(this.garageComboBox);
            this.groupBox2.Controls.Add(this.garageLabel);
            this.groupBox2.Controls.Add(this.plotSizeText);
            this.groupBox2.Controls.Add(this.plotSizeLabel);
            this.groupBox2.Controls.Add(this.rentLabelText);
            this.groupBox2.Controls.Add(this.rentLabel);
            this.groupBox2.Controls.Add(this.sizesqmLabel);
            this.groupBox2.Controls.Add(this.roomsTextBox);
            this.groupBox2.Controls.Add(this.roomsLabel);
            this.groupBox2.Controls.Add(this.sizeTextBox);
            this.groupBox2.Controls.Add(this.sizeLabel);
            this.groupBox2.Controls.Add(this.streetTextBox);
            this.groupBox2.Controls.Add(this.streetLabel);
            this.groupBox2.Controls.Add(this.zipcodeLabel);
            this.groupBox2.Controls.Add(this.zipCodeTextBox);
            this.groupBox2.Controls.Add(this.cityLabel);
            this.groupBox2.Controls.Add(this.cityTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.type);
            this.groupBox2.Controls.Add(this.countryComboBox);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estate Registration";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // apartmentNumberTextBox
            // 
            this.apartmentNumberTextBox.Location = new System.Drawing.Point(122, 145);
            this.apartmentNumberTextBox.Name = "apartmentNumberTextBox";
            this.apartmentNumberTextBox.Size = new System.Drawing.Size(39, 23);
            this.apartmentNumberTextBox.TabIndex = 31;
            this.apartmentNumberTextBox.Visible = false;
            // 
            // apartmentNumberLabel
            // 
            this.apartmentNumberLabel.AutoSize = true;
            this.apartmentNumberLabel.Location = new System.Drawing.Point(5, 148);
            this.apartmentNumberLabel.Name = "apartmentNumberLabel";
            this.apartmentNumberLabel.Size = new System.Drawing.Size(111, 15);
            this.apartmentNumberLabel.TabIndex = 30;
            this.apartmentNumberLabel.Text = "Apartment Number";
            this.apartmentNumberLabel.Visible = false;
            // 
            // chooseImageTextBox
            // 
            this.chooseImageTextBox.Location = new System.Drawing.Point(58, 182);
            this.chooseImageTextBox.Name = "chooseImageTextBox";
            this.chooseImageTextBox.Size = new System.Drawing.Size(109, 23);
            this.chooseImageTextBox.TabIndex = 29;
            this.chooseImageTextBox.TextChanged += new System.EventHandler(this.chooseImageTextBox_TextChanged);
            // 
            // browseFilesButton
            // 
            this.browseFilesButton.Location = new System.Drawing.Point(171, 182);
            this.browseFilesButton.Name = "browseFilesButton";
            this.browseFilesButton.Size = new System.Drawing.Size(72, 23);
            this.browseFilesButton.TabIndex = 28;
            this.browseFilesButton.Text = "Browse...";
            this.browseFilesButton.UseVisualStyleBackColor = true;
            this.browseFilesButton.Visible = false;
            this.browseFilesButton.Click += new System.EventHandler(this.browseFilesButton_Click);
            // 
            // BrowseFilesLabel
            // 
            this.BrowseFilesLabel.AutoSize = true;
            this.BrowseFilesLabel.Location = new System.Drawing.Point(5, 175);
            this.BrowseFilesLabel.Name = "BrowseFilesLabel";
            this.BrowseFilesLabel.Size = new System.Drawing.Size(47, 30);
            this.BrowseFilesLabel.TabIndex = 27;
            this.BrowseFilesLabel.Text = "Choose\r\nImage";
            this.BrowseFilesLabel.Visible = false;
            this.BrowseFilesLabel.Click += new System.EventHandler(this.BrowseFilesLabel_Click);
            // 
            // apartmentTypeComboBox
            // 
            this.apartmentTypeComboBox.FormattingEnabled = true;
            this.apartmentTypeComboBox.Location = new System.Drawing.Point(136, 82);
            this.apartmentTypeComboBox.Name = "apartmentTypeComboBox";
            this.apartmentTypeComboBox.Size = new System.Drawing.Size(91, 23);
            this.apartmentTypeComboBox.TabIndex = 26;
            this.apartmentTypeComboBox.Visible = false;
            this.apartmentTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.apartmentTypeComboBox_SelectedIndexChanged);
            // 
            // AppartmentTypeText
            // 
            this.AppartmentTypeText.AutoSize = true;
            this.AppartmentTypeText.Location = new System.Drawing.Point(136, 54);
            this.AppartmentTypeText.Name = "AppartmentTypeText";
            this.AppartmentTypeText.Size = new System.Drawing.Size(91, 15);
            this.AppartmentTypeText.TabIndex = 25;
            this.AppartmentTypeText.Text = "Apartment Type";
            this.AppartmentTypeText.Visible = false;
            // 
            // garageComboBox
            // 
            this.garageComboBox.FormattingEnabled = true;
            this.garageComboBox.Location = new System.Drawing.Point(56, 145);
            this.garageComboBox.Name = "garageComboBox";
            this.garageComboBox.Size = new System.Drawing.Size(39, 23);
            this.garageComboBox.TabIndex = 24;
            this.garageComboBox.Visible = false;
            // 
            // garageLabel
            // 
            this.garageLabel.AutoSize = true;
            this.garageLabel.Location = new System.Drawing.Point(8, 148);
            this.garageLabel.Name = "garageLabel";
            this.garageLabel.Size = new System.Drawing.Size(44, 15);
            this.garageLabel.TabIndex = 23;
            this.garageLabel.Text = "Garage";
            this.garageLabel.Click += new System.EventHandler(this.garageLabel_Click);
            // 
            // plotSizeText
            // 
            this.plotSizeText.Location = new System.Drawing.Point(56, 116);
            this.plotSizeText.Name = "plotSizeText";
            this.plotSizeText.Size = new System.Drawing.Size(39, 23);
            this.plotSizeText.TabIndex = 22;
            this.plotSizeText.Visible = false;
            this.plotSizeText.TextChanged += new System.EventHandler(this.plotSizeText_TextChanged);
            // 
            // plotSizeLabel
            // 
            this.plotSizeLabel.AutoSize = true;
            this.plotSizeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plotSizeLabel.Location = new System.Drawing.Point(6, 120);
            this.plotSizeLabel.Name = "plotSizeLabel";
            this.plotSizeLabel.Size = new System.Drawing.Size(51, 15);
            this.plotSizeLabel.TabIndex = 21;
            this.plotSizeLabel.Text = "Plot Size";
            this.plotSizeLabel.Visible = false;
            // 
            // rentLabelText
            // 
            this.rentLabelText.Location = new System.Drawing.Point(56, 116);
            this.rentLabelText.Name = "rentLabelText";
            this.rentLabelText.Size = new System.Drawing.Size(39, 23);
            this.rentLabelText.TabIndex = 20;
            // 
            // rentLabel
            // 
            this.rentLabel.AutoSize = true;
            this.rentLabel.Location = new System.Drawing.Point(6, 120);
            this.rentLabel.Name = "rentLabel";
            this.rentLabel.Size = new System.Drawing.Size(31, 15);
            this.rentLabel.TabIndex = 19;
            this.rentLabel.Text = "Rent";
            this.rentLabel.Visible = false;
            this.rentLabel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // sizesqmLabel
            // 
            this.sizesqmLabel.AutoSize = true;
            this.sizesqmLabel.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sizesqmLabel.Location = new System.Drawing.Point(92, 66);
            this.sizesqmLabel.Name = "sizesqmLabel";
            this.sizesqmLabel.Size = new System.Drawing.Size(21, 11);
            this.sizesqmLabel.TabIndex = 18;
            this.sizesqmLabel.Text = "m^2";
            this.sizesqmLabel.Visible = false;
            // 
            // roomsTextBox
            // 
            this.roomsTextBox.Location = new System.Drawing.Point(56, 87);
            this.roomsTextBox.Name = "roomsTextBox";
            this.roomsTextBox.Size = new System.Drawing.Size(39, 23);
            this.roomsTextBox.TabIndex = 16;
            this.roomsTextBox.Visible = false;
            // 
            // roomsLabel
            // 
            this.roomsLabel.AutoSize = true;
            this.roomsLabel.Location = new System.Drawing.Point(6, 90);
            this.roomsLabel.Name = "roomsLabel";
            this.roomsLabel.Size = new System.Drawing.Size(44, 15);
            this.roomsLabel.TabIndex = 15;
            this.roomsLabel.Text = "Rooms";
            this.roomsLabel.Visible = false;
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(56, 54);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(39, 23);
            this.sizeTextBox.TabIndex = 14;
            this.sizeTextBox.Visible = false;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(6, 57);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(27, 15);
            this.sizeLabel.TabIndex = 13;
            this.sizeLabel.Text = "Size";
            this.sizeLabel.Visible = false;
            this.sizeLabel.Click += new System.EventHandler(this.sizeLabel_Click);
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(67, 343);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(100, 23);
            this.streetTextBox.TabIndex = 12;
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(6, 351);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(37, 15);
            this.streetLabel.TabIndex = 11;
            this.streetLabel.Text = "Street";
            // 
            // zipcodeLabel
            // 
            this.zipcodeLabel.AutoSize = true;
            this.zipcodeLabel.Location = new System.Drawing.Point(6, 308);
            this.zipcodeLabel.Name = "zipcodeLabel";
            this.zipcodeLabel.Size = new System.Drawing.Size(55, 15);
            this.zipcodeLabel.TabIndex = 10;
            this.zipcodeLabel.Text = "Zip Code";
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(67, 305);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.zipCodeTextBox.TabIndex = 9;
            this.zipCodeTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(8, 270);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(28, 15);
            this.cityLabel.TabIndex = 8;
            this.cityLabel.Text = "City";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(67, 267);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 23);
            this.cityTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Country";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(42, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(6, 22);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(30, 15);
            this.type.TabIndex = 4;
            this.type.Text = "type";
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(67, 235);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(100, 23);
            this.countryComboBox.TabIndex = 3;
            this.countryComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(0, 215);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(252, 176);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Address Information";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(110, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.displayseeEstate);
            this.groupBox3.Controls.Add(this.DisplayAddressGroup);
            this.groupBox3.Controls.Add(this.displayEstateText);
            this.groupBox3.Controls.Add(this.image);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(270, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(575, 426);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estate Information";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // displayseeEstate
            // 
            this.displayseeEstate.AutoSize = true;
            this.displayseeEstate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.displayseeEstate.Location = new System.Drawing.Point(79, 120);
            this.displayseeEstate.Name = "displayseeEstate";
            this.displayseeEstate.Size = new System.Drawing.Size(413, 25);
            this.displayseeEstate.TabIndex = 14;
            this.displayseeEstate.Text = "Please add an estate to see information about it";
            this.displayseeEstate.Click += new System.EventHandler(this.displayseeEstate_Click);
            // 
            // DisplayAddressGroup
            // 
            this.DisplayAddressGroup.Controls.Add(this.displayStreet);
            this.DisplayAddressGroup.Controls.Add(this.displayCountry);
            this.DisplayAddressGroup.Controls.Add(this.displayZipcode);
            this.DisplayAddressGroup.Controls.Add(this.displayCity);
            this.DisplayAddressGroup.Location = new System.Drawing.Point(265, 22);
            this.DisplayAddressGroup.Name = "DisplayAddressGroup";
            this.DisplayAddressGroup.Size = new System.Drawing.Size(227, 196);
            this.DisplayAddressGroup.TabIndex = 13;
            this.DisplayAddressGroup.TabStop = false;
            this.DisplayAddressGroup.Text = "Adress of estate";
            this.DisplayAddressGroup.Visible = false;
            this.DisplayAddressGroup.Enter += new System.EventHandler(this.DisplayAddressGroup_Enter);
            // 
            // displayStreet
            // 
            this.displayStreet.AutoSize = true;
            this.displayStreet.Location = new System.Drawing.Point(6, 108);
            this.displayStreet.Name = "displayStreet";
            this.displayStreet.Size = new System.Drawing.Size(44, 15);
            this.displayStreet.TabIndex = 13;
            this.displayStreet.Text = "label10";
            // 
            // displayCountry
            // 
            this.displayCountry.AutoSize = true;
            this.displayCountry.Location = new System.Drawing.Point(6, 32);
            this.displayCountry.Name = "displayCountry";
            this.displayCountry.Size = new System.Drawing.Size(14, 15);
            this.displayCountry.TabIndex = 11;
            this.displayCountry.Text = "d";
            this.displayCountry.Visible = false;
            this.displayCountry.Click += new System.EventHandler(this.label9_Click);
            // 
            // displayZipcode
            // 
            this.displayZipcode.AutoSize = true;
            this.displayZipcode.Location = new System.Drawing.Point(6, 84);
            this.displayZipcode.Name = "displayZipcode";
            this.displayZipcode.Size = new System.Drawing.Size(44, 15);
            this.displayZipcode.TabIndex = 12;
            this.displayZipcode.Text = "label10";
            this.displayZipcode.Visible = false;
            // 
            // displayCity
            // 
            this.displayCity.AutoSize = true;
            this.displayCity.Location = new System.Drawing.Point(6, 60);
            this.displayCity.Name = "displayCity";
            this.displayCity.Size = new System.Drawing.Size(38, 15);
            this.displayCity.TabIndex = 10;
            this.displayCity.Text = "label8";
            this.displayCity.Visible = false;
            this.displayCity.Click += new System.EventHandler(this.label8_Click);
            // 
            // displayEstateText
            // 
            this.displayEstateText.AutoSize = true;
            this.displayEstateText.Location = new System.Drawing.Point(22, 27);
            this.displayEstateText.Name = "displayEstateText";
            this.displayEstateText.Size = new System.Drawing.Size(38, 30);
            this.displayEstateText.TabIndex = 4;
            this.displayEstateText.Text = "label2\r\nfd\r\n";
            this.displayEstateText.Visible = false;
            this.displayEstateText.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // image
            // 
            this.image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.image.Location = new System.Drawing.Point(22, 224);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(476, 155);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.image.TabIndex = 3;
            this.image.TabStop = false;
            this.image.Click += new System.EventHandler(this.image_Click);
            // 
            // chooseImageFile
            // 
            this.chooseImageFile.FileName = "openFileDialog1";
            this.chooseImageFile.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF";
            this.chooseImageFile.Title = "Choose Image";
            this.chooseImageFile.FileOk += new System.ComponentModel.CancelEventHandler(this.chooseImageFile_FileOk);
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Location = new System.Drawing.Point(20, 435);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(32, 15);
            this.errorText.TabIndex = 30;
            this.errorText.Text = "Error";
            this.errorText.Visible = false;
            this.errorText.Click += new System.EventHandler(this.errorText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 451);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Modern Real Estates by André Sturesson & Johannes Böök";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.DisplayAddressGroup.ResumeLayout(false);
            this.DisplayAddressGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox countryComboBox;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Address;
        private GroupBox groupBox3;
        private ComboBox comboBox2;
        private Label type;
        private Label label1;
        private Label cityLabel;
        private TextBox cityTextBox;
        private TextBox streetTextBox;
        private Label streetLabel;
        private Label zipcodeLabel;
        private TextBox zipCodeTextBox;
        private TextBox roomsTextBox;
        private Label roomsLabel;
        private TextBox sizeTextBox;
        private Label sizeLabel;
        private GroupBox groupBox4;
        private Label sizesqmLabel;
        private TextBox rentLabelText;
        private Label rentLabel;
        private TextBox plotSizeText;
        private Label plotSizeLabel;
        private ComboBox garageComboBox;
        private Label garageLabel;
        private ComboBox apartmentTypeComboBox;
        private Label AppartmentTypeText;
        private Label BrowseFilesLabel;
        private PictureBox image;
        private Button browseFilesButton;
        private TextBox chooseImageTextBox;
        private OpenFileDialog chooseImageFile;
        private Label errorText;
        private TextBox apartmentNumberTextBox;
        private Label apartmentNumberLabel;
        private Label displayZipcode;
        private Label displayCountry;
        private Label displayCity;
        private Label displayEstateText;
        private GroupBox DisplayAddressGroup;
        private Label displayseeEstate;
        private Label displayStreet;
    }
}