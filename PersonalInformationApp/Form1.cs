using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformationApp
{
    public partial class personalInfoUI : Form
    {
        public personalInfoUI()
        {
            InitializeComponent();
        }

        List<string> personalInfo = new List<string>();
        private void saveButton_Click(object sender, EventArgs e)
        {
            string firstName, lastName, fathersName, mothersName, address;

            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            fathersName = fatherNameTextBox.Text;
            mothersName = motherNameTextBox.Text;
            address = addressTextBox.Text;

            personalInfo.Add(firstName);
            personalInfo.Add(lastName);
            personalInfo.Add(fathersName);
            personalInfo.Add(mothersName);
            personalInfo.Add(address);

            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            fatherNameTextBox.Clear();
            motherNameTextBox.Clear();
            addressTextBox.Clear();
        }

        private void allInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fisrt Name = " + personalInfo[0] + 
                "\nLast Name = " + personalInfo[1] +
                "\nFather's name = " + personalInfo[2] +
                "\nMother's Name = "+ personalInfo[3] + 
                "\nAddress = " + personalInfo[4]);
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fisrt Name = " + personalInfo[0] + "\nLast Name = " + personalInfo[1]);
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\nAddress = " + personalInfo[4]);
        }

        private void parentsNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\nFather's name = " + personalInfo[2] + "\nMother's Name = " + personalInfo[3]);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

    }
}
