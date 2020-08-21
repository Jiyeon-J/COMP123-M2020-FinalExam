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
        /*The Author's name: Jiyeon Jeon
       Author's student number: #301103064
       Date last Modified: August 20, 2020
       Program description: Character Builder
       Revision History: 1.0 created August 20, 2020 Jiyeon 
       */
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        private void GenerateNames()
        {
            var random = new Random();

            int first = random.Next(0, FirstNameListBox.Items.Count);
            FirstNameTextBox.Text = FirstNameListBox.Items[first].ToString();

            int last = random.Next(0, LastNameListBox.Items.Count);
            LastNameTextBox.Text = LastNameListBox.Items[last].ToString();
        }
        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            this.GenerateNames();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            this.GenerateNames();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.FirstName = FirstNameTextBox.Text;
            character.LastName = LastNameTextBox.Text;
           
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
