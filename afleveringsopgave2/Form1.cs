using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace afleveringsopgave2
{
    public partial class Form1 : Form
    {
        string[] arrayNames = new string[10];
        int array = 0;
        int numToRemove = 0;

        public Form1()
        {
            InitializeComponent();
            UpdateTextPosition();
        }

        //Code to handle input in the textNavnBox which is added to an array when button addName is clicked
        private void AddName_Click(object sender, EventArgs e)
        {
            try
            {
                arrayNames[array] = "Pos. " + (array) + ": " + textNavnBox.Text;
                while (textNavnBox.Text != "")
                {
                    ++array;
                    textNavnBox.Text = "";
                    foreach (String item in arrayNames)
                    {
                        textDisplayNavne.Lines = arrayNames;
                    }
                }
            }
            catch (IndexOutOfRangeException) //Popup shown for exception
            {
                MessageBox.Show("You have entered 10 names");
            }
        }

        //Code to chose a position in the array and delete the content
        private void DeletePosition_Click(object sender, EventArgs e)
        {
            try
            {
                numToRemove = Convert.ToInt32(textArrayPosition.Text);
                arrayNames = arrayNames.Where(w => w != arrayNames[numToRemove]).ToArray();
                textArrayPosition.Text = "";
                foreach (String item in arrayNames)
                {
                    textDisplayNavne.Lines = arrayNames;
                }
            }
            catch (IndexOutOfRangeException)
            {

            }
        }

        //Code to sort the array in ascending order
        private void SortAscending_Click(object sender, EventArgs e)
        {
            Array.Sort(arrayNames);
            foreach (String item in arrayNames)
            {
                textDisplayNavne.Lines = arrayNames;
            }
        }

        //Code to sort the array in descending order
        private void SortDescending_Click(object sender, EventArgs e)
        {
            Array.Sort(arrayNames);
            Array.Reverse(arrayNames);
            foreach (String item in arrayNames)
            {
                textDisplayNavne.Lines = arrayNames;
            }
        }

        //Code to align the title name center of the form
        private void UpdateTextPosition()
        {
            Graphics g = this.CreateGraphics();
            Double startingPoint = (this.Width / 2) - (g.MeasureString(this.Text.Trim(), this.Font).Width / 2);
            Double widthOfASpace = g.MeasureString(" ", this.Font).Width;
            String tmp = " ";
            Double tmpWidth = 0;

            while ((tmpWidth + widthOfASpace) < startingPoint)
            {
                tmp += " ";
                tmpWidth += widthOfASpace;
            }

            this.Text = tmp + this.Text.Trim();
        }
    }
}
