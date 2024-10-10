using RealEstateBLL.Commercial;
using RealEstateBLL.Institutional;
using RealEstateBLL.Residential;
using RealEstateBLL;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Apu_Real_Estate__ARE_
{
    public partial class Form1 : Form
    {
        //fields
        public int idIndex = 10;
        private Estate estate;
        private EstateManager estateManager = new EstateManager();
        private System.Drawing.Image placeholder;

        //create a file dilog
        private OpenFileDialog file = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();

            //set comboboxes values
            cmbCountry.DataSource = Enum.GetValues(typeof(Countries));
            cmbLegalForm.DataSource = Enum.GetValues(typeof(LegalForm));
            cmbTypeEstate.DataSource = Enum.GetValues(typeof(EstateType));
            cmbCountry.SelectedIndex = (int)Countries.Sverige;

            placeholder = picBoxEstate.Image;
        }

        // Add data from the form to estate
        private void AddEstate(bool isUpdate)
        {
            CreateEstate();
            ReadGeneralData(isUpdate);
            ReadCategoryData();
        }

        //update GUI
        private void UpdateGUI()
        {
            //clear the list
            lstEstate.Items.Clear();
            lstEstate.Items.AddRange(estateManager.ToStringArray());
        }

        //read category data from the form
        private void ReadCategoryData()
        {
            try
            {
                EstateType category = (EstateType)cmbTypeEstate.SelectedIndex;

                // Validate and parse numRooms, default to 1 if invalid
                int numRooms = int.TryParse(txtCategory1.Text, out int parsedRooms) ? parsedRooms : 1;
                double area = double.TryParse(txtCategory2.Text, out double parsedArea) ? parsedArea : 1;

                // Validate and parse numFloors or area based on the estate type
                switch (category)
                {
                    case EstateType.Residential:
                        int numFloors = int.TryParse(txtCategory2.Text, out int parsedFloors) ? parsedFloors : 1;
                        AssignResidentialData(numRooms, numFloors);
                        break;

                    case EstateType.Commercial:
                        AssignCommercialData(numRooms, area);
                        break;

                    case EstateType.Institutional:
                        AssignInstitutionalData(numRooms, area);
                        break;

                    default:
                        throw new InvalidOperationException("Invalid estate type selected.");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input: Please enter valid numbers for numRooms, numFloors, and area.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //assign category data to residential type estate
        private void AssignResidentialData(int numRooms, int numFloors)
        {
            try
            {
                var residentialEstate = (Residential)estate;
                residentialEstate.NumOfFloors = numFloors;
                residentialEstate.NumOfRooms = numRooms;
                residentialEstate.ResidentialType = (ResidentialType)cmbCategorySpecific3.SelectedIndex;
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately, e.g., log it or display an error message
                MessageBox.Show("Error setting residential data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //assign category data to Commercial type estate
        private void AssignCommercialData(int numRooms, double area)
        {
            try
            {
                var commercialEstate = (Commercial)estate;
                commercialEstate.Area = area;
                commercialEstate.NumberOfRooms = numRooms;
                commercialEstate.CommercialType = (CommercialType)cmbCategorySpecific3.SelectedIndex;
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately, e.g., log it or display an error message
                MessageBox.Show("Error setting Commercial data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //assign category data to Commercial type estate
        private void AssignInstitutionalData(int numRooms, double area)
        {
            try
            {
                var institutionalEstate = (Institutional)estate;
                institutionalEstate.NumberOfRooms = numRooms;
                institutionalEstate.Area = area;
                institutionalEstate.InstitutionalType = (InstitutionalType)cmbCategorySpecific3.SelectedIndex;
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately, e.g., log it or display an error message
                MessageBox.Show("Error setting Institutional data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //read img path, address, legalform from the form
        private void ReadGeneralData(bool isUpdate)
        {
            if (estate != null)
            {
                //set id, idIndex is not changed if update button pressed
                if (!isUpdate)
                {
                    estate.ID = idIndex;
                    idIndex++;
                }
                else
                {
                    estate.ID = idIndex;
                }
                //set address, legal form,
                estate.Address = new Address(txtStreet.Text, txtCity.Text, txtZipCode.Text, (Countries)cmbCountry.SelectedIndex);
                estate.LegalForm = (LegalForm)cmbLegalForm.SelectedIndex;

                //set img file path
                //if (file.ShowDialog() == DialogResult.OK)
                //{
                //    if (!string.IsNullOrEmpty(file.FileName))
                //    {
                //        try
                //        {
                //            estate.ImagePath = file.FileName;
                //            picBoxEstate.Image = Image.FromFile(estate.ImagePath);
                //        }
                //        catch (Exception ex) // Catch a broader exception for various file issues
                //        {
                //            MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        }
                //    }
                //}
                // hardcoded path
                estate.ImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Resources\Asg1.jpg");
                picBoxEstate.Image = Image.FromFile(estate.ImagePath);

            }
        }

        // Creates a new estate object based on the selected type.
        private void CreateEstate()
        {
            estate = null;
            EstateType estateType = (EstateType)cmbTypeEstate.SelectedIndex;
            switch (estateType)
            {
                case EstateType.Residential:
                    CreateResidentialType();
                    break;
                case EstateType.Commercial:
                    CreateCommercialType();
                    break;
                case EstateType.Institutional:
                    CreateInstitutionalType();
                    break;
            }
        }
        private void CreateInstitutionalType()
        {
            // Get category data
            int numRooms;
            if (!int.TryParse(txtCategory1.Text, out numRooms))
            {
                throw new ArgumentException("Invalid input: Please enter a valid number for number of rooms.");
            }
            if (numRooms <= 0)
            {
                throw new ArgumentException("Number must be positive.");
            }
            double area;
            if (!double.TryParse(txtCategory2.Text, out area))
            {
                throw new ArgumentException("Invalid input: Please enter a valid number for area.");
            }
            if (area <= 0)
            {
                throw new ArgumentException("Number must be positive.");
            }
            InstitutionalType institutionalType = (InstitutionalType)cmbCategorySpecific3.SelectedIndex;

            // Get object specified data
            LocationType locationType = (LocationType)cmbObjectSpecific1.SelectedIndex;
            string owner = txtObjectSpecific2.Text;

            // Creates different estate objects based on the institutional type.
            switch (institutionalType)
            {
                case InstitutionalType.Hospital:
                    estate = new Hospitals(locationType, owner);
                    break;
                case InstitutionalType.School:
                    estate = new Schools(locationType, owner);
                    break;
                case InstitutionalType.University:
                    estate = new Universities(locationType, owner);
                    break;
                default:
                    throw new InvalidOperationException("Invalid institutional type.");
            }
        }
        private void CreateCommercialType()
        {

            // Get category data
            int numRooms;
            if (!int.TryParse(txtCategory1.Text, out numRooms))
            {
                throw new ArgumentException("Invalid input: enter a valid number for number of rooms.");
            }
            if (numRooms <= 0)
            {
                throw new ArgumentException("Number must be positive.");
            }
            double area;
            if (!double.TryParse(txtCategory2.Text, out area))
            {
                throw new ArgumentException("Invalid input: enter a valid number for area.");
            }
            if (area <= 0)
            {
                throw new ArgumentException("Number must be positive.");
            }

            CommercialType commercialType = (CommercialType)cmbCategorySpecific3.SelectedIndex;

            // Get object specified data
            Parking isAllowParking = (Parking)cmbObjectSpecific1.SelectedIndex;
            string orgNum = txtObjectSpecific2.Text;

            // Creates different estate objects based on the commercial type.
            switch (commercialType)
            {
                case CommercialType.Factory:
                    estate = new Factories(isAllowParking, orgNum);
                    break;
                case CommercialType.Hotel:
                    estate = new Hotels(isAllowParking, orgNum);
                    break;
                case CommercialType.Shop:
                    estate = new Shops(isAllowParking, orgNum);
                    break;
                case CommercialType.Warehouse:
                    estate = new Warehouse(isAllowParking, orgNum);
                    break;
                default:
                    throw new InvalidOperationException("Invalid commercial type.");
            }

        }

        private void CreateResidentialType()
        {
            try
            {
                // Get category data
                int numRooms = Int32.Parse(txtCategory1.Text);
                int numFloors = Int32.Parse(txtCategory2.Text);
                ResidentialType residentialType = (ResidentialType)cmbCategorySpecific3.SelectedIndex;

                // Get object specified data
                NotUsed notUsed = (NotUsed)cmbObjectSpecific1.SelectedIndex;
                int constructionYear = Int32.Parse(txtObjectSpecific2.Text);

                // Validate input data
                if (numRooms <= 0 || numFloors <= 0 || constructionYear <= 0)
                {
                    throw new ArgumentException("Invalid input: must be positive.");
                }

                // Creates different estate objects based on the residential type.
                switch (residentialType)
                {
                    case ResidentialType.Apartment:
                        estate = new Apartment(notUsed, constructionYear);
                        break;
                    case ResidentialType.TownHouse:
                        estate = new TownHouse(notUsed, constructionYear);
                        break;
                    case ResidentialType.Villa:
                        estate = new Villa(notUsed, constructionYear);
                        break;
                    default:
                        throw new InvalidOperationException("Invalid residential type.");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input: enter valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Creates a view for the selected estate type, showing relevant category and object-specific labels and controls.
        private void CreateCategoryObjectView()
        {
            EstateType estateType = (EstateType)cmbTypeEstate.SelectedIndex;

            switch (estateType)
            {
                case (EstateType.Residential):
                    CreateResidentialView();
                    break;
                case (EstateType.Commercial):
                    CreateCommercialView();
                    break;
                case (EstateType.Institutional):
                    CreateInstitutionalView();
                    break;
            }
        }

        // Creates a view for a residential estate, setting labels and controls for category and object-specific data.
        private void CreateResidentialView()
        {
            lblCategorySpecific1.Text = "No. of rooms";
            lblCategorySpecific2.Text = "No. of floors";
            lblcategorySpecific3.Text = "Residential type";
            cmbCategorySpecific3.DataSource = Enum.GetValues(typeof(ResidentialType));

            lblObjectSpecific1.Text = "Not used!";
            cmbObjectSpecific1.DataSource = Enum.GetValues(typeof(NotUsed));
            lblObjectSpecific2.Text = "Year Construction";
        }

        // Creates a view for a commercial estate, setting labels and controls for category and object-specific data.
        private void CreateCommercialView()
        {
            lblCategorySpecific1.Text = "No. of rooms";
            lblCategorySpecific2.Text = "Area (optional unit)";
            lblcategorySpecific3.Text = "Organization type";
            cmbCategorySpecific3.DataSource = Enum.GetValues(typeof(CommercialType));

            lblObjectSpecific1.Text = "Parking";
            cmbObjectSpecific1.DataSource = Enum.GetValues(typeof(Parking));
            lblObjectSpecific2.Text = "Organization number";
        }

        // Creates a view for a institutional estate, setting labels and controls for category and object-specific data.
        public void CreateInstitutionalView()
        {
            lblCategorySpecific1.Text = "No. of rooms";
            lblCategorySpecific2.Text = "Area (optional unit)";
            lblcategorySpecific3.Text = "Institutional type";
            cmbCategorySpecific3.DataSource = Enum.GetValues(typeof(InstitutionalType));

            lblObjectSpecific1.Text = "Location Type";
            cmbObjectSpecific1.DataSource = Enum.GetValues(typeof(LocationType));
            lblObjectSpecific2.Text = "Entity";
        }

        // Fills data from a string array (partsData) into the form controls based on the estate type.
        private void FillDataToForm(string data)
        {
            // Splits the input data into parts and removes prefixes based on the estate type.
            string[] partsData = data.Split(",");

            for (int i = 0; i < partsData.Length; i++)
            {
                partsData[i] = RemovePrefix(partsData[i], "Address ");
                partsData[i] = RemovePrefix(partsData[i], "Legal Form ");

                if (partsData[6] == "Residential")
                {
                    partsData[i] = RemovePrefix(partsData[i], "Floor ");
                    partsData[i] = RemovePrefix(partsData[i], "Number of Room ");
                    partsData[i] = RemovePrefix(partsData[i], "isUsed ");
                    partsData[i] = RemovePrefix(partsData[i], "constructionYear ");
                }
                else if (partsData[6] == "Commercial")
                {
                    if (partsData[i].StartsWith("Area "))
                    {
                        partsData[i] = ExtractAreaValue(partsData[i], "m");
                    }
                    partsData[i] = RemovePrefix(partsData[i], "Number of Room ");
                    partsData[i] = RemovePrefix(partsData[i], "Organization number ");
                    partsData[i] = RemovePrefix(partsData[i], "Parking Allowance ");
                }
                else // Institutional or other types
                {
                    if (partsData[i].StartsWith("Area "))
                    {
                        partsData[i] = ExtractAreaValue(partsData[i], "m");
                    }
                    partsData[i] = RemovePrefix(partsData[i], "Number of Room ");
                    partsData[i] = RemovePrefix(partsData[i], "locationType ");
                    partsData[i] = RemovePrefix(partsData[i], "owner ");
                }
            }

            // fills data into the form controls for address, estate type, legal form, and specific details.
            cmbTypeEstate.SelectedItem = Enum.Parse(typeof(EstateType), partsData[6]);
            cmbLegalForm.SelectedItem = Enum.Parse(typeof(LegalForm), partsData[5]);

            //fill in address
            txtStreet.Text = partsData[1];
            txtZipCode.Text = partsData[2];
            txtCity.Text = partsData[3];
            cmbCountry.SelectedItem = Enum.Parse(typeof(Countries), partsData[4]);
            //fill in category and object
            txtCategory2.Text = partsData[8];
            txtCategory1.Text = partsData[9];
            txtObjectSpecific2.Text = partsData[11];

            EstateType estatetype = (EstateType)cmbTypeEstate.SelectedIndex;
            switch (estatetype)
            {
                case EstateType.Residential:
                    cmbCategorySpecific3.SelectedItem = Enum.Parse(typeof(ResidentialType), partsData[7]);
                    cmbObjectSpecific1.SelectedItem = Enum.Parse(typeof(NotUsed), partsData[10]);
                    break;
                case EstateType.Commercial:
                    cmbCategorySpecific3.SelectedItem = Enum.Parse(typeof(CommercialType), partsData[7]);
                    cmbObjectSpecific1.SelectedItem = Enum.Parse(typeof(Parking), partsData[10]);
                    break;
                case EstateType.Institutional:
                    cmbCategorySpecific3.SelectedItem = Enum.Parse(typeof(InstitutionalType), partsData[7]);
                    cmbObjectSpecific1.SelectedItem = Enum.Parse(typeof(LocationType), partsData[10]);
                    break;
            }
        }
        //remove comma
        private string RemovePrefix(string data, string prefix)
        {
            return data.StartsWith(prefix) ? data.Replace(prefix, "") : data;
        }
        //get area value
        private string ExtractAreaValue(string data, string endCharacter)
        {
            int startIndex = data.IndexOf(' ') + 1;
            int endIndex = data.IndexOf(endCharacter);
            return data.Substring(startIndex, endIndex - startIndex);
        }
        // reset all text inputs
        private void ResetAllTextField()
        {
            lblEstateItem.ResetText();
            txtStreet.ResetText();
            txtZipCode.ResetText();
            txtCity.ResetText();
            txtCategory1.ResetText();
            txtCategory2.ResetText();
            txtObjectSpecific2.ResetText();
        }
        //add button event, create estate object, add to estate manager list, update gui and reset all text boxes
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEstate(false);
            //add estate to ListManager
            estateManager.Add(estate);
            UpdateGUI();
            ResetAllTextField();
        }

        //change view of category and object group when estate type changed
        private void cmbTypeEstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateCategoryObjectView();
        }

        //show estate item to lblestate and fills form data.
        private void lstEstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (lstEstate.SelectedIndex != -1)
            {
                string selectedItem = lstEstate.SelectedItem?.ToString() ?? "No item selected";
                lblEstateItem.Text = selectedItem;
                FillDataToForm(selectedItem);
            }
        }

        // Removes the selected item from the listbox, remove picture and resets related data.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstEstate.SelectedIndex;
            lstEstate.Items.RemoveAt(index);
            estateManager.DeleteAt(index);
            picBoxEstate.Image = null;
            ResetAllTextField();
        }

        //update estate event
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = lstEstate.SelectedIndex;
            AddEstate(true);
            //change estate in ListManager
            estateManager.ChangeAt(estate, index);
            UpdateGUI();
            lblEstateItem.ResetText();
            ResetAllTextField();
        }
        // delete all
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            lstEstate.Items.Clear();
            estateManager.DeleteAll();
            lblEstateItem.ResetText();
            picBoxEstate.Image = null;
            ResetAllTextField();
        }
    }
}
