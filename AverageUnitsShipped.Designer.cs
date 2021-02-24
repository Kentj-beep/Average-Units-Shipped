
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
            this.textboxPastEntries = new System.Windows.Forms.TextBox();
            this.labelAverageOutput = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelUnitsPrompt
            // 
            this.labelUnitsPrompt.Location = new System.Drawing.Point(64, 21);
            this.labelUnitsPrompt.Name = "labelUnitsPrompt";
            this.labelUnitsPrompt.Size = new System.Drawing.Size(100, 23);
            this.labelUnitsPrompt.TabIndex = 0;
            this.labelUnitsPrompt.Text = "&Units:";
            this.labelUnitsPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textboxUnitsShipped
            // 
            this.textboxUnitsShipped.Location = new System.Drawing.Point(117, 21);
            this.textboxUnitsShipped.Name = "textboxUnitsShipped";
            this.textboxUnitsShipped.Size = new System.Drawing.Size(100, 23);
            this.textboxUnitsShipped.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textboxUnitsShipped, "Enter the current days entries here");
            // 
            // labelDay
            // 
            this.labelDay.Location = new System.Drawing.Point(223, 21);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(100, 23);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "Day 1";
            this.labelDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textboxPastEntries
            // 
            this.textboxPastEntries.BackColor = System.Drawing.SystemColors.Window;
            this.textboxPastEntries.Location = new System.Drawing.Point(64, 63);
            this.textboxPastEntries.Multiline = true;
            this.textboxPastEntries.Name = "textboxPastEntries";
            this.textboxPastEntries.ReadOnly = true;
            this.textboxPastEntries.Size = new System.Drawing.Size(207, 116);
            this.textboxPastEntries.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textboxPastEntries, "Past entries for this week");
            // 
            // labelAverageOutput
            // 
            this.labelAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAverageOutput.Location = new System.Drawing.Point(64, 192);
            this.labelAverageOutput.Name = "labelAverageOutput";
            this.labelAverageOutput.Size = new System.Drawing.Size(207, 23);
            this.labelAverageOutput.TabIndex = 4;
            this.labelAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelAverageOutput, "Average number of units shipped for this week");
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(49, 232);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 23);
            this.buttonEnter.TabIndex = 5;
            this.buttonEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.buttonEnter, "Submit the current entered units to the list");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnterClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(130, 232);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.buttonReset, "Reset the program. Clearing the current entry and past entries.");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(211, 232);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.buttonExit, "Exit the program");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // formAverageUnitsShipped
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(350, 293);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelAverageOutput);
            this.Controls.Add(this.textboxPastEntries);
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
        private System.Windows.Forms.TextBox textboxPastEntries;
        private System.Windows.Forms.Label labelAverageOutput;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

