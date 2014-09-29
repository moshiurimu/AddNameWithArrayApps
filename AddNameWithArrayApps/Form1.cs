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



        List<string> nameList = new List<string>();
        int setCount=0;
        int temp=0;
        private void addButton_Click(object sender, EventArgs e)
        {

            nameList.Add(nameTextBox.Text);
            countLabel.Text = Convert.ToString(++temp);
            nameTextBox.Text = "";
            if (temp== setCount)
            {
                nameListView.Items.Clear();
                foreach (string myName in nameList)
                {
                    nameListView.Items.Add(myName);
                }
                addButton.Enabled = false;
            }

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            nameListView.Items.Clear();
            foreach (string myName in nameList)
            {
                nameListView.Items.Add(myName);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = false;
            setButton.Enabled = true;
            
            countLabel.Text = "";
            nameList = new List<string>();

            nameListView.Items.Clear();

            temp = 0;
            setCount = 0;

        }

        private void setButton_Click(object sender, EventArgs e)
        {
            setCount = Convert.ToInt32(setTextBox.Text);
            setTextBox.Text = "";
            addButton.Enabled = true;
            setButton.Enabled = false;
        }

        private void AddNameUI_Load(object sender, EventArgs e)
        {
            addButton.Enabled = false;

        }
    }
}
