using System;
using System.Windows.Forms;


namespace Question_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Add button Action
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string language = txtLanguage.Text.Trim();

            //Check if the input of the search box that the user can enter is Empty

            if (string.IsNullOrEmpty(language))
            {
                MessageBox.Show("Please enter a programming language, Dont search an empty seach box", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listLanguages.Items.Contains(language))
            {

                MessageBox.Show($"'{language}' is allready in the list. Please add any other programming languages", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            listLanguages.Items.Add(language);

            string timeadded = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");
            lblStatus.Text = $"Added '{language}' at {timeadded}";

            txtLanguage.Clear();
        }


        // Remove button Action
        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (listLanguages.SelectedItem == null)
            {
                MessageBox.Show("Please select a language to remove. ", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedLanguage = listLanguages.SelectedItem.ToString();

            listLanguages.Items.Remove(listLanguages.SelectedItem);

            string timereoved = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");
            lblStatus.Text = $"Removed '{selectedLanguage}' at {timereoved}";
        }
    }
}
