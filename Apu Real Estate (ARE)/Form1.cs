using System.Xml.Linq;

namespace Apu_Real_Estate__ARE_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddEstateType();
        }

        private void AddEstateType()
        {
            cmbTypeEstate.Items.Add("Residential");
            cmbTypeEstate.Items.Add("Commercial");
            cmbTypeEstate.Items.Add("Institutional");
            cmbLegalForm.Items.Add("Ownership");
            cmbLegalForm.Items.Add("Tenement");
            cmbLegalForm.Items.Add("Rental");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
   
        }
    }
}
