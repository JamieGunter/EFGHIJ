using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFGHIJ
{
    public partial class VanillaForm : Form
    {
        private ControllerInterface controllerInterface = new ControllerInterface(); // Intialise controller interface
        private JNDInterface jndInterface = new JNDInterface(); // Initialise JND interface
        private int reversalNumber; // Number of reversals, initialised to 0, max 6
        private int trialNumber; // Number of trials
        private int V1; // Record V1 value in variable
        private int V2; // Record V2 value in variable 
        public VanillaForm()
        {
            InitializeComponent();
            createNextTrial(); // Create the first trial
        }
        public void createNextTrial() // Create the next trial
        {
            V1 = jndInterface.getV1Value(); // Get V1 value
            V2 = jndInterface.getV2Value(); // Get V2 value
            trialNumber = jndInterface.getTrialNumber(); // Get current trial number
            trialNumberLabel.Text = trialNumber.ToString(); // Update trial number label
            controllerInterface.SetVibration(V2, V2); // Vibrate at V2 value
            Thread.Sleep(2000); // Allow vibration for 2 seconds
            controllerInterface.SetVibration(0, 0); // Stop vibration
        }
        private void getOriginalStimuliButton_Click(object sender, EventArgs e)
        {
            controllerInterface.SetVibration(V1, V1); // Vibrate at V1 value
            Thread.Sleep(2000); // Allow vibration for 2 seconds
            controllerInterface.SetVibration(0, 0); // Stop vibration
        }
        private void getNewStimuliButton_Click(object sender, EventArgs e)
        {
            controllerInterface.SetVibration(V2, V2); // Vibrate at V2 value
            Thread.Sleep(2000); // Allow vibration for 2 seconds
            controllerInterface.SetVibration(0, 0); // Stop vibration
        }
        private void V2IsLowerButton_Click(object sender, EventArgs e)
        {
            // Check if user is correct and if reversal occurs (User input is that V2 is lower than V1), then get new V2 value
            V2 = jndInterface.checkReversalAndCalculateVDiff(true);
            // Update revesal number to check if reversal has occured
            reversalNumber = jndInterface.getReversalNumber();
            // Check if 6 reversals have occured, and if so, conclude this game (In gamified, include pin/visual logic by checking if a reversal has just occured)
            if (reversalNumber == 6)
            {
                // Conclude game - TBI
            }
            // Create next trial if game has not concluded
            createNextTrial();
        }
        private void V2IsNotLower_Click(object sender, EventArgs e)
        {
            // Check if user is correct and if reversal occurs (User input is that V2 is higher than V1), then get new V2 value
            V2 = jndInterface.checkReversalAndCalculateVDiff(false);
            // Update revesal number to check if reversal has occured
            reversalNumber = jndInterface.getReversalNumber();
            // Check if 6 reversals have occured, and if so, conclude this game (In gamified, include pin/visual logic by checking if a reversal has just occured)
            if (reversalNumber == 6)
            {
                // Conclude game - TBI
            }
            // Create next trial if game has not concluded
            createNextTrial();
        }
    }
}
