namespace SectionB_Question2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCitizen.Items.Add("South African");
            cmbCitizen.Items.Add("Permanent Resident");
            cmbCitizen.Items.Add("Visitor");

            cmbCitizen.SelectedIndex = 0;
        }

        CitizenProfile profile;

        private void btnValidate_Click(object sender, EventArgs e)
        {
            profile = new CitizenProfile(
                txtName.Text,
                txtID.Text,
                cmbCitizen.Text
                );
            lblResults.Text = profile.ValidId();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (profile == null)
            {
                MessageBox.Show("Please validate first");
            }

            txtOutput.Text =
                "==== DIGITAL CITIZEN SUMMARY ===\r\n" +
                $"Name: {profile.FullName}\r\n" +
                $"ID Number: {profile.IDNumber}\r\n" +
                $"Age: {profile.age}\r\n" +
                $"Citizenship {profile.Citizenshipstatus}\r\n" +
                $"Validation: {profile.ValidId()}\r\n" +
                $"Processed at: Home Affairs Digital Desk\r\n" +
                $"TimeStamp: {DateTime.Now}";
        }
    }
}
