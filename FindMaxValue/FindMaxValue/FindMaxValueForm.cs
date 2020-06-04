/*
 * Created by: Joelle Ishimwe
 * Created on: 1-June-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - Find Max Value
 * This program that has an array size of 10 cells. It 
 * populates the array with 10 random numbers between 
 * 0 - 500. Then a function is called to traverse the 
 * array and find the max value. The max value is then 
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

namespace FindMaxValue
{
    public partial class frmFindMaxValue : System.Windows.Forms.Form
    {
        public frmFindMaxValue()
        {
            InitializeComponent();
            
            //hide the label with the max value
            this.lblMaxValue.Hide();
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
            int maxValue;

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

            //get the max value
            maxValue = GetMaxValue(arrayOfNumber);

            //display the answer in a label
            this.lblMaxValue.Show();
            lblMaxValue.Text = "The maximum value is:  " + maxValue;
        }

        private int GetMaxValue(int[] tempArrayOfNumbers)
        {
            //declare variables
            int tempMaxValue = -1;
            int tempCounter;

            //loop that will associate the array lenth to the counter to find the max value
            for (tempCounter = 0; tempCounter < tempArrayOfNumbers.Length; tempCounter++)
            {
                if(tempArrayOfNumbers[tempCounter] > tempMaxValue)
                {
                    tempMaxValue = tempArrayOfNumbers[tempCounter];
                }
            }
            
            //return the value
            return tempMaxValue;
        }
    }
}
