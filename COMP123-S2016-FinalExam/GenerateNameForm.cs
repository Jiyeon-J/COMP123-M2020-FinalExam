using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        public void GenerateNames()
        {
            var random = new Random();

            int first = random.Next(0, FirstNameListBox.Items.Count);
            FirstNameTextBox.Text = FirstNameListBox.Items[first].ToString();

            int last = random.Next(0, LastNameListBox.Items.Count);
            LastNameTextBox.Text = LastNameListBox.Items[last].ToString();
        }
        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateNames();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();

            FirstNameTextBox.Text = Program.character.FirstName;
            LastNameTextBox.Text = Program.character.LastName;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();
            this.Hide();
            abilityGeneratorForm.Show();
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
