/*
 * Created by: Joelle Ishimwe
 * Created on: 24-May-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #36 - Introduction to Arrays
 * This program creates an array of size 10. When the user 
 * clicks on the "Start" button. It generates 10 random numbers, 
 * each between 1 and 10 and for each random number, it displays 
 * it in a list box. It also  assigns it to the subsequent cell in 
 * the array. When the user clicks on the "Calculate Average" button, 
 * it calculates the average of the sum of the 10 numbers in the array.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayAverage
{
    public partial class frmArrayAverage : Form
    {
        //declare global variables and constants
        const int MAX_ARRAY_SIZE = 10;
        int[] arrayOfNumbers = new int[MAX_ARRAY_SIZE];

        public frmArrayAverage()
        {
            InitializeComponent();

            //hide items
            this.lblAverage.Hide();
            this.lstArray.Hide();
            this.btnAverage.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //have the button disapear
            this.btnStart.Hide();

            //Show items
            this.lstArray.Show();
            this.btnAverage.Show();

            //declare variables and constants
            int randomNumber;
            int counter;
            Random randomNumberGenerator = new Random();

            //clear listbox
            this.lstArray.Items.Clear();

            //a for loop that displays 10 random numbers in a listbox
            for (counter = 0; counter < MAX_ARRAY_SIZE; counter ++)
            {
                //generate a new random number between 1 and the max array size
                randomNumber = randomNumberGenerator.Next(1, MAX_ARRAY_SIZE + 1);

                //assign randomNumber to the cell at position "counter" in the array
                arrayOfNumbers[counter] = randomNumber;

                //add the random number to the listbox
                lstArray.Items.Add(randomNumber); 

                //REFRESH
                this.Refresh();
            }

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            //declare variables and constants
            double average = 0;
            double sum = 0;
            int counter;

            //calculate the sum of all the values in the array
            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                sum = sum + arrayOfNumbers[counter];
            }

            //calculate the average of all the values in the array
            average = sum / arrayOfNumbers.Length;

            //display answer in label
            this.lblAverage.Text = "The average is:  " + average;
            this.lblAverage.Show();
        }

        private void mniNew_Click(object sender, EventArgs e)
        {
            //restart
            Application.Restart();
        }
    }
}
