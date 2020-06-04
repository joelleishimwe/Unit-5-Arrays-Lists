/*
 * Created by: Joelle Ishimwe
 * Created on: 3-June-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #38 - Find Min Value
 * This program that has an array size of 10 cells. It 
 * populates the array with 10 random numbers between 
 * 0 - 500. Then a function is called to traverse the 
 * array and find the min value. The min value is then 
 * displayed in a label 
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

namespace FindMinValue
{
    public partial class frmFindMinValue : Form
    {
        public frmFindMinValue()
        {
            InitializeComponent();

            //hide the label with the min value
            this.lblMinValue.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare variables and constants
            const int MAX_ARRAY_SIZE = 10;
            const int MAX_NUMBER = 500;
            const int MIN_NUMBER = 0;
            int[] arrayOfNumber = new int[MAX_ARRAY_SIZE];
            int randomNumber;
            int counter;
            int minValue;

            //create a generator that will choose a random number
            Random RandomGenerator = new Random();

            //clear the listbox
            lstArrayOfValues.Items.Clear();

            //loop that will generate random numbers and add the array to the listbox 
            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                randomNumber = RandomGenerator.Next(MIN_NUMBER, MAX_NUMBER + 1);
                lstArrayOfValues.Items.Add(randomNumber);
                arrayOfNumber[counter] = randomNumber;
            }

            //get the min value
            minValue = GetMinValue(arrayOfNumber);

            //display the answer in a label
            this.lblMinValue.Show();
            lblMinValue.Text = "The minimum value is:  " + minValue;
        }

        private int GetMinValue(int[] tempArrayOfNumbers)
        {
            //declare variables
            int tempMinValue = 501;
            int tempCounter;

            //loop that will associate the array lenth to the counter to find the min value
            for (tempCounter = 0; tempCounter < tempArrayOfNumbers.Length; tempCounter++)
            {
                if (tempArrayOfNumbers[tempCounter] < tempMinValue)
                {
                    tempMinValue = tempArrayOfNumbers[tempCounter];
                }
            }

            //return the value
            return tempMinValue;
        }
    }
}
