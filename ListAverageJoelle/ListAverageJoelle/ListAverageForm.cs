/*
 * Created by: Joelle Ishimwe
 * Created on: 9-June-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - List Average
 * This program calculates the average of a list of marks from the user.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListAverageJoelle
{
    public partial class frmListAverage : Form
    {

        //declare globale variles
        List<int> lstOfMarks = new List<int>();

        public frmListAverage()
        {
            InitializeComponent();

            //hide the answer
            this.lblAverage.Hide();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //declare variables
            int usersMark;

            try
            {
                //associating the variable with the it's item.
                usersMark = int.Parse(txtMark.Text);

                if ((usersMark >= 0) && (usersMark <= 100))
                {

                //add the mark to the listbox
                lstMarks.Items.Add(usersMark);

                //add the mark to the list of marks
                lstOfMarks.Add(usersMark);

                }

                else
                {
                    //ouput a message to tghe user, stating what they have to do 
                    MessageBox.Show("Please enter a marker between 1 - 100", "ERROR");
                }
            }
            catch (Exception parseError)
            {
                //output the parse error to the console
                Console.WriteLine(parseError.Message);

                //ouput a message to tghe user, stating what they have to do 
                MessageBox.Show("Please enter a marker between 1 - 100", "ERROR");
            }

            //clear the textbox
            txtMark.Text = "";
        }

        private void btnCalculateAverage_Click(object sender, EventArgs e)
        {
            //declare avriables
            double sum = 0;
            double averge = 0;
            
            //calculate the average of all the list of marks
            for (int counter = 0; counter < lstOfMarks.Count(); counter++)
            {
                //adjust the sum
                sum = sum + lstOfMarks[counter];
            }

            //calculate the average
            averge = sum / lstOfMarks.Count();

            //display the average in the label
            this.lblAverage.Show();
            lblAverage.Text = "The average is:  " + Math.Round(averge);
        }
    }
}
