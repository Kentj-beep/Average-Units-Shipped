// Student Name: Jacob Kent
// Date: Feb 24, 2021
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

        // Declarations
        int currentDay = 1;
        int currentEmployee = 0;

        // Arrays
        int[,] unitsShippedArray = new int[3, 7];
        double[] employeeAveragesArray = new double[3];
           
        TextBox[] pastEntriesArray;
        Label[] averageLabelArray;

        public formAverageUnitsShipped()
        {
            InitializeComponent();

            // Arrays of the textboxes and labels
            pastEntriesArray = new TextBox[] { textBoxPastEntries1, textBoxPastEntries2, textBoxPastEntries3 };
            averageLabelArray = new Label[] { labelEmployeeAverage1, labelEmployeeAverage2, labelEmployeeAverage3 };

            SetDefaults();
        }


        /// <summary>
        /// Function to return the form to its default state.
        /// </summary>
        private void SetDefaults()
        {
            // Clear all input and output fields
            textboxUnitsShipped.Clear();
            ClearControls(pastEntriesArray);
            ClearControls(averageLabelArray);
            labelAverageOutput.Text = String.Empty;

            // Reset the global variables
            currentDay = 1;
            currentEmployee = 0;

            // Rest Day Label
            labelDay.Text = "Day " + currentDay;

            // Clear all contents of the unitsShippedArray
            Array.Clear(unitsShippedArray, 0, unitsShippedArray.Length);

            // Re-enable controls
            textboxUnitsShipped.Enabled = true;
            buttonEnter.Enabled = true;

            // Set focus
            textboxUnitsShipped.Focus();
        }

        /// <summary>
        /// This clears the text property of all controls in the array of controls that is passed in
        /// </summary>
        /// <param name="controlArray">An array of controls with a text property to clear</param>
        private void ClearControls(Control[] controlArray)
        {
            foreach (Control controlToClear in controlArray)
            {
                controlToClear.Text = String.Empty;
            }
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
            SetDefaults();
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
            const int TotalEmployees = 3;
            int lastEntry;

            // Validate that the number entered is a whole number
            if (int.TryParse(textboxUnitsShipped.Text, out lastEntry))
            {
                // Validate that the number entered is between 0 and 5000
                if (lastEntry >= MinimumUnits && lastEntry <= MaximumUnits)
                {
                    // Add the newest entry to the list of past entries for the current employee
                    pastEntriesArray[currentEmployee].Text += lastEntry + "\r\n";
                    // Add the last entry to the unitsShippedArray for the current employee and day
                    unitsShippedArray[currentEmployee, currentDay - 1] = lastEntry;
                    // Increment the day by 1
                    currentDay++;
                    // Clear the entry textbox after each valid entry
                    textboxUnitsShipped.Clear();

                    // If the day is > 7
                    if (currentDay > MaximumDays)
                    {

                        // For loop here to determine current employee average

                        int unitsShipped = 0;
                        double averageUnits = 0;

                        // Count through the array for the current employee to determine their average
                        for(int counter = 0; counter < MaximumDays; counter++)
                        {
                            // Add the value for that employee, on that day, to their units shipped.
                            unitsShipped += unitsShippedArray[currentEmployee, counter];
                        }

                        // Determine and set the average for the current employee
                        averageUnits = (double)unitsShipped / (double)MaximumDays;
                        employeeAveragesArray[currentEmployee] = Math.Round(averageUnits, 2);
                        averageLabelArray[currentEmployee].Text = "Average: " + averageUnits.ToString("F2");

                        // Reset the current day
                        currentDay = 1;
                        labelDay.Text = "Day " + currentDay;
                        // Increment to the next employee
                        currentEmployee++;

                        // If the current employee is now equal to total employees. Disable controls, and calculate the final average
                        if (currentEmployee == TotalEmployees)
                        {
                            // Determine the average
                            averageUnits = 0;
                            double averageShipped = 0;
                            // Count through the array for the current employee to determine their average
                            for (int counter = 0; counter < employeeAveragesArray.Length; counter++)
                            {
                                // Add the average for that employee to the total of the averages
                                averageShipped += employeeAveragesArray[counter];
                            }

                            // Determine and set the average for all employees
                            averageUnits = averageShipped / (double)TotalEmployees;
                            Math.Round(averageUnits, 2);
                            labelAverageOutput.Text = "Average per day: " + averageUnits.ToString("F2");

                            // Testing section
                            // MessageBox.Show("Average 1: " + employeeAveragesArray[0] + "Average 2: " 
                            // + employeeAveragesArray[1] + "Average 3: " + employeeAveragesArray[2]);

                            // Disable controls
                            textboxUnitsShipped.Enabled = false;
                            buttonEnter.Enabled = false;
                        }

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
