using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddNameWithArrayApps
{
    public partial class AddNameUI : Form
    {
        public AddNameUI()
        {
            InitializeComponent();
        }

        string[] name = new string[10];


        int temp;
        private void addButton_Click(object sender, EventArgs e)
        {

            name[temp] = nameTextBox.Text;
            countLabel.Text = (temp+1).ToString();

            temp++;
            nameTextBox.Text = "";

            if (countLabel.Text== "10")
            {
                addButton.Enabled = false;

                nameListBox.Items.Clear();
                for (int count = 0; count < name.Length; count++)
                {
                    nameListBox.Items.Add((count + 1) + ". " + name[count]);
                }

            }
            
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            nameListBox.Items.Clear();

            for (int count = 0; count < Convert.ToInt16(countLabel.Text); count++)
            {
                nameListBox.Items.Add((count+1)+ ". "+ name[count]);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            nameListBox.Items.Clear();
            countLabel.Text = "";

            temp = 0;
        }
    }
}
