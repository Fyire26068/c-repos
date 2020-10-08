using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_gui
{
    public partial class startPage : Form
    {
        public startPage()
        {
            InitializeComponent();
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            usernameLbl.Text = "Changed on startup";
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            submitButton.BackColor = Color.Green;
            submissionSpin.Value = submissionSpin.Value+1;
            statusBar.Value = statusBar.Value + 1;
            if (statusBar.Value == 101) { 
                statusBar.Value = 1;
            };

                

        }
    }
}
