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
    public partial class SplashForm : Form
    { 
        /*The Author's name: Jiyeon Jeon
        Author's student number: #301103064
        Date last Modified: August 20, 2020
        Program description: Character Builder
        Revision History: 1.0 created August 20, 2020 Jiyeon 
        */

        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            
            Program.generateNameForm.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            SplashFormTimer.Enabled = true;
        }
    }
}
