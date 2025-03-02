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
using System.Diagnostics;

namespace EFGHIJ
{
    public partial class VanillaForm : Form
    {
        private ControllerInterface controllerInterface; // Intialise controller interface
        private JNDInterface jndInterface; // Initialise JND interface
        private int reversalNumber; // Number of reversals, initialised to 0, max 6
        private int trialNumber; // Number of trials
        private int V1; // Record V1 value in variable
        private int V2; // Record V2 value in variable 
        private int boundaryNumber = 0; // Times the boundary numbers have been hit
        private double timeRemaining = 3; // Time remaining (3 second default)
        private Stopwatch stopwatchTimer; // Initialise Stopwatch timer
        private System.Timers.Timer timeOutTimer; // Initialise Time-Out timer
        public VanillaForm(int VersionNumber)
        {
            jndInterface = new JNDInterface(true, VersionNumber); // Initialise JND interface
            InitializeComponent();
            controllerInterface = new ControllerInterface(this); // Create controller instance (listener enabled by default)
            controllerInterface.DisableListener(); // Disable listener while instructions are up
            VanillaInstructionsForm vanillaInstructionsForm = new VanillaInstructionsForm(); // Create the instructions form
            vanillaInstructionsForm.FormClosed += new FormClosedEventHandler(vanillaInstructionsFormClosed); // Add event handler to re-enable listener when instructions form is closed
            vanillaInstructionsForm.ShowDialog(); // Ensure users cannot interact with components while the instructions form exists
            getOriginalStimuliButton.Enabled = false;
            getNewStimuliButton.Enabled = false;
            stopwatchTimer = new Stopwatch();
            timeOutTimer = new System.Timers.Timer(50); // Initialise the Time-Out timer with 0.05 second interval (for UI)
            timeOutTimer.Elapsed += timeOutTimerTick; // Event handler for timeout timer ticks
            timeOutTimer.AutoReset = true;
            createNextTrial(true);
        }
        private void vanillaInstructionsFormClosed(object sender, FormClosedEventArgs e) // Event handler to re-enable listener when instrunctions form is closed
        {
            controllerInterface.EnableListener();
        }
        private void timeOutTimerTick(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                double elapsedTime = stopwatchTimer.Elapsed.TotalSeconds; // Get elapsed time
                timeRemaining = 3.0 - elapsedTime;
                if (timeRemaining <= 0) // Handle a timeout
                {
                    stopwatchTimer.Stop();
                    timeOutTimer.Stop(); // Stop the timer
                    disableAllButtons(); // Disable all buttons so user cannot input multiple commands (Just in case of noise/multiple successive inputs)
                    controllerInterface.DisableListener(); // Disable listener so user cannot input multiple commands (via controller)
                    V2 = jndInterface.userTimeOut(elapsedTime); // Call timeout handler in JND Interface object
                    boundaryNumber = jndInterface.getBoundsNumber();
                    if (boundaryNumber == 3) // Check if boundary limit has been hit
                    {
                        TaskConclusionFormVanilla taskConclusionForm = new TaskConclusionFormVanilla(this);
                        taskConclusionForm.Show();
                    }
                    else
                    {
                        // Create next trial if game has not concluded
                        createNextTrial(false);
                    }
                }
                else
                {
                    timeRemainingValueLabel.Text = timeRemaining.ToString("F2"); // Update the time remaining label, F2 denotes 2 decimal places
                }
            }));
        }
        public async void createNextTrial(bool firstRun) // Create the next trial
        {
            disableAllButtons(); // Disable all buttons so user cannot input multiple commands
            controllerInterface.DisableListener(); // Disable listener so user cannot input multiple commands (via controller)
            if (firstRun)
            {
                await Task.Delay(2000); // Wait 2 Seconds
            }
            V1 = jndInterface.getV1Value(); // Get V1 value
            V2 = jndInterface.getV2Value(); // Get V2 value
            trialNumber = jndInterface.getTrialNumber(); // Get current trial number
            trialNumberLabel.Text = trialNumber.ToString(); // Update trial number label
            controllerInterface.SetVibration(V1, V1); // Vibrate at V1 value
            getOriginalStimuliButton.BackColor = Color.Green; // Change to green to signify showing stimuli
            await Task.Delay(2000); // Allow vibration for 2 seconds
            controllerInterface.SetVibration(0, 0); // Stop vibration
            getOriginalStimuliButton.BackColor = Color.LightGray; // Change back to white to signify no longer showing stimuli
            await Task.Delay(1000); // Allow vibration for 1 second
            controllerInterface.SetVibration(V2, V2); // Vibrate at V2 value
            getNewStimuliButton.BackColor = Color.Green; // Change to green to signify showing stimuli
            await Task.Delay(2000); // Allow vibration for 2 seconds
            controllerInterface.SetVibration(0, 0); // Stop vibration
            getNewStimuliButton.BackColor = Color.LightGray; // Change back to white to signify no longer showing stimuli
            enableAllButtons(); // Enable all buttons so user can input again
            controllerInterface.EnableListener(); // Enable listener so user can input again (via controller)
            timeRemaining = 3.0; // Reset time back to 3 seconds
            timeRemainingValueLabel.Text = timeRemaining.ToString("F2"); // Update time remaining label, F2 denotes 2 decimal places
            stopwatchTimer.Restart(); // Restart the timer
            timeOutTimer.Start(); // Start the timer again
        }
        private async void getOriginalStimuliButton_Click(object sender, EventArgs e)
        {
            controllerInterface.DisableListener(); // Disable listener so user cannot input multiple commands (via controller)
            disableAllButtons(); // Disable all buttons so user cannot input multiple commands
            controllerInterface.SetVibration(V1, V1); // Vibrate at V1 value
            getOriginalStimuliButton.BackColor = Color.Green; // Change to green to signify showing stimuli
            await Task.Delay(2000); // Allow vibration for 2 seconds
            controllerInterface.SetVibration(0, 0); // Stop vibration
            getOriginalStimuliButton.BackColor = Color.LightGray; // Change back to white to signify no longer showing stimuli
            enableAllButtons(); // Enable all buttons so user can input again
            controllerInterface.EnableListener(); // Enable listener so user can input again (via controller)
        }
        private async void getNewStimuliButton_Click(object sender, EventArgs e)
        {
            controllerInterface.DisableListener(); // Disable listener so user cannot input multiple commands (via controller)
            disableAllButtons(); // Disable all buttons so user cannot input multiple commands
            controllerInterface.SetVibration(V2, V2); // Vibrate at V2 value
            getNewStimuliButton.BackColor = Color.Green; // Change to green to signify showing stimuli
            await Task.Delay(2000); // Allow vibration for 2 seconds
            controllerInterface.SetVibration(0, 0); // Stop vibration
            getNewStimuliButton.BackColor = Color.LightGray; // Change back to white to signify no longer showing stimuli
            enableAllButtons(); // Enable all buttons so user can input again
            controllerInterface.EnableListener(); // Enable listener so user can input again (via controller)
        }
        private void V2IsLowerButton_Click(object sender, EventArgs e)
        {
            stopwatchTimer.Stop(); // Stop the stopwatch
            timeOutTimer.Stop(); // Stop the timer
            double timeTaken = 3.0 - timeRemaining; // Calculate time taken for response
            controllerInterface.DisableListener(); // Disable listener so user cannot input multiple commands (via controller)
            disableAllButtons(); // Disable all buttons so user cannot input multiple commands (Just in case of noise/multiple successive inputs)
            // Check if user is correct and if reversal occurs (User input is that V2 is lower than V1), then get new V2 value
            V2 = jndInterface.checkReversalAndCalculateVDiff(true, timeTaken);
            // Update revesal number to check if reversal has occured
            reversalNumber = jndInterface.getReversalNumber();
            // Update boundary number to check if boundary limit has been hit
            boundaryNumber = jndInterface.getBoundsNumber();
            // Check if 6 reversals have occured, and if so, conclude this game (In gamified, include pin/visual logic by checking if a reversal has just occured)
            if (reversalNumber == 6)
            {
                TaskConclusionFormVanilla taskConclusionForm = new TaskConclusionFormVanilla(this);
                taskConclusionForm.Show();
            }
            else if (boundaryNumber == 3)
            {
                TaskConclusionFormVanilla taskConclusionForm = new TaskConclusionFormVanilla(this);
                taskConclusionForm.Show();
            }
            else
            {
                // Create next trial if game has not concluded
                createNextTrial(false);
            }
        }
        private void V2IsNotLowerButton_Click(object sender, EventArgs e)
        {
            stopwatchTimer.Stop();
            timeOutTimer.Stop(); // Stop the timer
            double timeTaken = 3.0 - timeRemaining; // Calculate time taken for response
            controllerInterface.DisableListener(); // Disable listener so user cannot input multiple commands (via controller)
            disableAllButtons(); // Disable all buttons so user cannot input multiple commands (Just in case of noise/multiple successive inputs)
            // Check if user is correct and if reversal occurs (User input is that V2 is higher than V1), then get new V2 value
            V2 = jndInterface.checkReversalAndCalculateVDiff(false, timeTaken);
            // Update revesal number to check if reversal has occured
            reversalNumber = jndInterface.getReversalNumber();
            // Update boundary number to check if boundary limit has been hit
            boundaryNumber = jndInterface.getBoundsNumber();
            // Check if 6 reversals have occured, and if so, conclude this game (In gamified, include pin/visual logic by checking if a reversal has just occured)
            if (reversalNumber == 6)
            {
                TaskConclusionFormVanilla taskConclusionForm = new TaskConclusionFormVanilla(this);
                taskConclusionForm.Show();
            }
            else if (boundaryNumber == 3)
            {
                TaskConclusionFormVanilla taskConclusionForm = new TaskConclusionFormVanilla(this);
                taskConclusionForm.Show();
            }
            else
            {
                // Create next trial if game has not concluded
                createNextTrial(false);
            }
        }
        private void disableAllButtons() // Disable all buttons
        {
            foreach (Control interactableElement in this.Controls)
            {
                if (interactableElement is Button)
                {
                    interactableElement.Enabled = false;
                }
            }
            timeOutTimer.Stop(); // Stop the timer
        }
        private void enableAllButtons() // Enable all buttons
        {
            foreach (Control interactableElement in this.Controls)
            {
                if (interactableElement is Button)
                {
                    interactableElement.Enabled = true;
                }
            }
        }
    }
}
