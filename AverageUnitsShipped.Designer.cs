
namespace Lab_1
{
    partial class formAverageUnitsShipped
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelUnitsPrompt = new System.Windows.Forms.Label();
            this.textboxUnitsShipped = new System.Windows.Forms.TextBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.textBoxPastEntries1 = new System.Windows.Forms.TextBox();
            this.labelAverageOutput = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxPastEntries2 = new System.Windows.Forms.TextBox();
            this.textBoxPastEntries3 = new System.Windows.Forms.TextBox();
            this.labelEmployeeAverage1 = new System.Windows.Forms.Label();
            this.labelEmployeeAverage2 = new System.Windows.Forms.Label();
            this.labelEmployeeAverage3 = new System.Windows.Forms.Label();
            this.labelEmployee1 = new System.Windows.Forms.Label();
            this.labelEmployee2 = new System.Windows.Forms.Label();
            this.labelEmployee3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUnitsPrompt
            // 
            this.labelUnitsPrompt.Location = new System.Drawing.Point(18, 45);
            this.labelUnitsPrompt.Name = "labelUnitsPrompt";
            this.labelUnitsPrompt.Size = new System.Drawing.Size(56, 23);
            this.labelUnitsPrompt.TabIndex = 0;
            this.labelUnitsPrompt.Text = "&Units:";
            this.labelUnitsPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textboxUnitsShipped
            // 
            this.textboxUnitsShipped.Location = new System.Drawing.Point(64, 45);
            this.textboxUnitsShipped.Name = "textboxUnitsShipped";
            this.textboxUnitsShipped.Size = new System.Drawing.Size(72, 23);
            this.textboxUnitsShipped.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textboxUnitsShipped, "Enter the current days entries here");
            // 
            // labelDay
            // 
            this.labelDay.Location = new System.Drawing.Point(18, 19);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(56, 23);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "Day 1";
            this.labelDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.labelDay, "Current day for entry.");
            // 
            // textBoxPastEntries1
            // 
            this.textBoxPastEntries1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPastEntries1.Location = new System.Drawing.Point(21, 107);
            this.textBoxPastEntries1.Multiline = true;
            this.textBoxPastEntries1.Name = "textBoxPastEntries1";
            this.textBoxPastEntries1.ReadOnly = true;
            this.textBoxPastEntries1.Size = new System.Drawing.Size(115, 116);
            this.textBoxPastEntries1.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxPastEntries1, "Past entries for Employee 1 this week.");
            // 
            // labelAverageOutput
            // 
            this.labelAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageOutput.Location = new System.Drawing.Point(21, 254);
            this.labelAverageOutput.Name = "labelAverageOutput";
            this.labelAverageOutput.Size = new System.Drawing.Size(357, 23);
            this.labelAverageOutput.TabIndex = 4;
            this.labelAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelAverageOutput, "Average number of units shipped by all employees for this week.");
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(21, 289);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(115, 23);
            this.buttonEnter.TabIndex = 5;
            this.buttonEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.buttonEnter, "Submit the current entered units to the list");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnterClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(142, 289);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(115, 23);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.buttonReset, "Reset the program. Clearing the current entry and ALL past entries.");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(263, 289);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(115, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.buttonExit, "Exit the program");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // textBoxPastEntries2
            // 
            this.textBoxPastEntries2.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPastEntries2.Location = new System.Drawing.Point(142, 107);
            this.textBoxPastEntries2.Multiline = true;
            this.textBoxPastEntries2.Name = "textBoxPastEntries2";
            this.textBoxPastEntries2.ReadOnly = true;
            this.textBoxPastEntries2.Size = new System.Drawing.Size(115, 116);
            this.textBoxPastEntries2.TabIndex = 11;
            this.toolTip1.SetToolTip(this.textBoxPastEntries2, "Past entries for Employee 2 this week.");
            // 
            // textBoxPastEntries3
            // 
            this.textBoxPastEntries3.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPastEntries3.Location = new System.Drawing.Point(263, 107);
            this.textBoxPastEntries3.Multiline = true;
            this.textBoxPastEntries3.Name = "textBoxPastEntries3";
            this.textBoxPastEntries3.ReadOnly = true;
            this.textBoxPastEntries3.Size = new System.Drawing.Size(115, 116);
            this.textBoxPastEntries3.TabIndex = 12;
            this.toolTip1.SetToolTip(this.textBoxPastEntries3, "Past entries for Employee 3 this week.");
            // 
            // labelEmployeeAverage1
            // 
            this.labelEmployeeAverage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEmployeeAverage1.Location = new System.Drawing.Point(21, 226);
            this.labelEmployeeAverage1.Name = "labelEmployeeAverage1";
            this.labelEmployeeAverage1.Size = new System.Drawing.Size(115, 23);
            this.labelEmployeeAverage1.TabIndex = 13;
            this.labelEmployeeAverage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelEmployeeAverage1, "Average number of units shipped for this week");
            // 
            // labelEmployeeAverage2
            // 
            this.labelEmployeeAverage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEmployeeAverage2.Location = new System.Drawing.Point(142, 226);
            this.labelEmployeeAverage2.Name = "labelEmployeeAverage2";
            this.labelEmployeeAverage2.Size = new System.Drawing.Size(115, 23);
            this.labelEmployeeAverage2.TabIndex = 14;
            this.labelEmployeeAverage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelEmployeeAverage2, "Average number of units shipped by Employee 2 for this week.\r\n");
            // 
            // labelEmployeeAverage3
            // 
            this.labelEmployeeAverage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEmployeeAverage3.Location = new System.Drawing.Point(263, 226);
            this.labelEmployeeAverage3.Name = "labelEmployeeAverage3";
            this.labelEmployeeAverage3.Size = new System.Drawing.Size(115, 23);
            this.labelEmployeeAverage3.TabIndex = 15;
            this.labelEmployeeAverage3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelEmployeeAverage3, "Average number of units shipped by Employee 3 for this week.");
            // 
            // labelEmployee1
            // 
            this.labelEmployee1.AutoSize = true;
            this.labelEmployee1.Location = new System.Drawing.Point(44, 89);
            this.labelEmployee1.Name = "labelEmployee1";
            this.labelEmployee1.Size = new System.Drawing.Size(68, 15);
            this.labelEmployee1.TabIndex = 8;
            this.labelEmployee1.Text = "Employee 1";
            // 
            // labelEmployee2
            // 
            this.labelEmployee2.AutoSize = true;
            this.labelEmployee2.Location = new System.Drawing.Point(165, 89);
            this.labelEmployee2.Name = "labelEmployee2";
            this.labelEmployee2.Size = new System.Drawing.Size(68, 15);
            this.labelEmployee2.TabIndex = 9;
            this.labelEmployee2.Text = "Employee 2";
            // 
            // labelEmployee3
            // 
            this.labelEmployee3.AutoSize = true;
            this.labelEmployee3.Location = new System.Drawing.Point(286, 89);
            this.labelEmployee3.Name = "labelEmployee3";
            this.labelEmployee3.Size = new System.Drawing.Size(68, 15);
            this.labelEmployee3.TabIndex = 10;
            this.labelEmployee3.Text = "Employee 3";
            // 
            // formAverageUnitsShipped
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(400, 331);
            this.Controls.Add(this.labelEmployeeAverage3);
            this.Controls.Add(this.labelEmployeeAverage2);
            this.Controls.Add(this.labelEmployeeAverage1);
            this.Controls.Add(this.textBoxPastEntries3);
            this.Controls.Add(this.textBoxPastEntries2);
            this.Controls.Add(this.labelEmployee3);
            this.Controls.Add(this.labelEmployee2);
            this.Controls.Add(this.labelEmployee1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelAverageOutput);
            this.Controls.Add(this.textBoxPastEntries1);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.textboxUnitsShipped);
            this.Controls.Add(this.labelUnitsPrompt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAverageUnitsShipped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Units Shipped";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUnitsPrompt;
        private System.Windows.Forms.TextBox textboxUnitsShipped;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.TextBox textBoxPastEntries1;
        private System.Windows.Forms.Label labelAverageOutput;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelEmployee1;
        private System.Windows.Forms.Label labelEmployee2;
        private System.Windows.Forms.Label labelEmployee3;
        private System.Windows.Forms.TextBox textBoxPastEntries2;
        private System.Windows.Forms.TextBox textBoxPastEntries3;
        private System.Windows.Forms.Label labelEmployeeAverage1;
        private System.Windows.Forms.Label labelEmployeeAverage2;
        private System.Windows.Forms.Label labelEmployeeAverage3;
    }
}

