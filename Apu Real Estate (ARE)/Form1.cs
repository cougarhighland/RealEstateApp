using Apu_Real_Estate__ARE_.Commercial;
using Apu_Real_Estate__ARE_.Institutional;
using Apu_Real_Estate__ARE_.Residential;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Apu_Real_Estate__ARE_
{
    public partial class Form1 : Form
    {
        public int idIndex = 10;

        private Estate estate;
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

        private void AddEstate()
        {
            CreateEstate();
            ReadGeneralData();
            ReadCategoryData();
        }

        private void UpdateGUI()
        {
            lstEstate.Items.Add(estate);
        }

        private void ReadCategoryData()
        {
            EstateType category = (EstateType)cmbTypeEstate.SelectedIndex;

            // Validate and parse numRooms, default to 1 if invalid
            int numRooms = int.TryParse(txtCategory1.Text, out int parsedRooms) ? parsedRooms : 1;
            double area = double.TryParse(txtCategory2.Text, out double parsedArea) ? parsedArea : 1;

            // Validate and parse numFloors or area based on the estate type
            switch (category)
            {
                case EstateType.Residential:
                    int numFloors = int.TryParse(txtCategory2.Text, out int parsedFloor) ? parsedFloor : 1;
                    AssignResidentialData(numRooms, numFloors);
                    break;

                case EstateType.Commercial:
                    AssignCommercialData(numRooms, area);
                    break;

                case EstateType.Institutional:
                    AssignInstitutionalData(numRooms, area);
                    break;
            }
        }

        private void AssignResidentialData(int numRooms, int numFloors)
        {
            var residentialEstate = (Residential.Residential)estate;
            residentialEstate.NumOfFloors = numFloors;
            residentialEstate.NumOfRooms = numRooms;
        }

        private void AssignCommercialData(int numRooms, double area)
        {
            var commercialEstate = (Commercial.Commercial)estate;
            commercialEstate.Area = area;
            commercialEstate.NumberOfRooms = numRooms;
        }

        private void AssignInstitutionalData(int numRooms, double area)
        {
            var institutionalEstate = (Institutional.Institutional)estate;
            institutionalEstate.NumberOfRooms = numRooms;
            institutionalEstate.Area = area;
        }

        private void ReadGeneralData()
        {
            if (estate != null) 
            { 
                //set id
                estate.ID = idIndex;
                idIndex++;

                //set address, legal form,
                estate.Address = new Address(txtStreet.Text, txtCity.Text, txtZipCode.Text, (Countries)cmbCountry.SelectedIndex);
                estate.LegalForm = (LegalForm)cmbLegalForm.SelectedIndex;

                //set img file path
                if (file.ShowDialog() == DialogResult.OK) 
                {
                    if (!string.IsNullOrEmpty(file.FileName)) 
                    {
                        estate.ImagePath = file.FileName; 
                    }
                }

            }
        }
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
            //get category data
            int numRooms = Int32.Parse(txtCategory1.Text);
            double area = Double.Parse(txtCategory2.Text);
            InstitutionalType institutionalType = (InstitutionalType)cmbCategorySpecific3.SelectedIndex;
            //get object specified data
            LocationType locationType = (LocationType)cmbObjectSpecific1.SelectedIndex;
            string owner = txtObjectSpecific2.Text;
            switch (institutionalType)
            {
                case InstitutionalType.Hospital:
                    estate = new Hospitals();
                    break;
                case InstitutionalType.School:
                    estate = new Schools();
                    break;
                case InstitutionalType.University:
                    estate = new Universities();
                    break;
            }
        }
        private void CreateCommercialType()
        {
            //get category data
            int numRooms = Int32.Parse(txtCategory1.Text);
            double area = Double.Parse(txtCategory2.Text);
            OrgType commercialType = (OrgType)cmbCategorySpecific3.SelectedIndex;
            //get object specified data
            Parking isAllowParking = (Parking)cmbObjectSpecific1.SelectedIndex;
            string orgNum = txtObjectSpecific2.Text;
            switch (commercialType)
            {
                case OrgType.Factory:
                    estate = new Factories(isAllowParking, orgNum);
                    break;
                case OrgType.Hotel:
                    estate = new Hotels(isAllowParking, orgNum);
                    break;
                case OrgType.Shop:
                    estate = new Shops(isAllowParking, orgNum);
                    break;
                case OrgType.Warehouse:
                    estate = new Warehouse(isAllowParking, orgNum);
                    break;
            }
        }

        private void CreateResidentialType()
        {
            //get category data
            int numRooms = Int32.Parse(txtCategory1.Text);
            int numFloors = Int32.Parse(txtCategory2.Text);
            ResidentialType residentialType = (ResidentialType)cmbCategorySpecific3.SelectedIndex;
            //get object specified data
            NotUsed notUsed = (NotUsed)cmbObjectSpecific1.SelectedIndex;
            int constructionYear = Int32.Parse(txtObjectSpecific2.Text);
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
            }
        }
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

        private void CreateCommercialView()
        {
            lblCategorySpecific1.Text = "No. of rooms";
            lblCategorySpecific2.Text = "Area (optional unit)";
            lblcategorySpecific3.Text = "Organization type";
            cmbCategorySpecific3.DataSource = Enum.GetValues(typeof(OrgType));

            lblObjectSpecific1.Text = "Parking";
            cmbObjectSpecific1.DataSource = Enum.GetValues(typeof(Parking));
            lblObjectSpecific2.Text = "Organization number";
        }

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


        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEstate();
            UpdateGUI();
        }

        private void cmbTypeEstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateCategoryObjectView();
        }
    }
}
