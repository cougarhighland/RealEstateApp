using Apu_Real_Estate__ARE_.Commercial;
using Apu_Real_Estate__ARE_.Institutional;
using Apu_Real_Estate__ARE_.Residential;
using System.Xml.Linq;

namespace Apu_Real_Estate__ARE_
{
    public partial class Form1 : Form
    {
        public int idIndex = 100;

        private Estate estate;
        private System.Drawing.Image placeholder;

        //create a file dilog
        private OpenFileDialog file = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();

            //set comboboxes values
            cmbCountry.DataSource = Enum.GetValues(typeof(Countries));
            cmbLegalForm.DataSource = Enum.GetValues(typeof(FormType));
            cmbTypeEstate.DataSource = Enum.GetValues(typeof(EstateType));
            cmbCountry.SelectedIndex = (int)Countries.Sverige;

            placeholder = picBoxEstate.Image;
 

        }

        private void CreateCategoryObjectView()
        {
            estate = null;
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

        }

        private void cmbTypeEstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateCategoryObjectView();
        }
    }
}
