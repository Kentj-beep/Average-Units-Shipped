// Student Name: Jacob Kent
// Date: Jan 21, 2021
// Program Name: Average Units Shipped
// Description: Take inputs of 7 numbers, valdiate them, and output their average in a functional form with accessbility features.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class formAverageUnitsShipped : Form
    {
        int currentDay = 1;
        int runningTotal = 0;
        public formAverageUnitsShipped()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Close the program when the Exit button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Reset the form to a default state, re-enabled disabled controls, and set focus to the input box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonResetClick(object sender, EventArgs e)
        {
            // Clear input feilds
            textboxUnitsShipped.Clear();
            textboxPastEntries.Clear();
            labelAverageOutput.Text = String.Empty;

            // Reset the global variables
            currentDay = 1;
            runningTotal = 0;

            // Re-enable controls
            textboxUnitsShipped.Enabled = true;
            buttonEnter.Enabled = true;

            // Set focus
            textboxUnitsShipped.Focus();
        }
        /// <summary>
        /// Functionaly for entering a value. Including validation of the entry and the final calculation and output of the average.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnterClick(object sender, EventArgs e)
        {
            // Declare constants and variables.
            const int MinimumUnits = 0;
            const int MaximumUnits = 5000;
            const int MaximumDays = 7;
            int lastEntry;

            // Validate that the number entered is a whole number
            if (int.TryParse(textboxUnitsShipped.Text, out lastEntry))
            {
                // Validate that the number entered is between 0 and 5000
                if (lastEntry >= MinimumUnits && lastEntry <= MaximumUnits)
                {
                    // Add the newest entry to the list of past entries
                    textboxPastEntries.Text += lastEntry + "\r\n";
                    // Add to the current total by the entry
                    runningTotal += lastEntry;
                    // Increment the day by 1
                    currentDay++;
                    // Clear the entry textbox after each valid entry
                    textboxUnitsShipped.Clear();

                    // If the day is > 7
                    if (currentDay > MaximumDays)
                    {
                        // Determine the average
                        double averageUnits;
                        averageUnits = (double)runningTotal / (double)MaximumDays;
                        // Output the result
                        labelAverageOutput.Text = "Average per day: " + Math.Round(averageUnits, 2);
                        // Disable controls
                        textboxUnitsShipped.Enabled = false;
                        buttonEnter.Enabled = false;

                    }
                    // If the day is <= 7
                    else
                    {
                        // Display the current day up to 7
                        labelDay.Text = "Day " + currentDay;
                    }

                }
                else
                {
                    // The value entered is outside the accepted range
                    MessageBox.Show("Enter a value between " + MinimumUnits + 
                        " and " + MaximumUnits + ".", "Invalid Entry");
                    textboxUnitsShipped.SelectAll();
                    textboxUnitsShipped.Focus();

                }

            }
            else
            {
                // The value entered is not an integer
                MessageBox.Show("Entry must be a number value.", "Invalid Entry");
                textboxUnitsShipped.SelectAll();
                textboxUnitsShipped.Focus();
            }

        }
    }
}
