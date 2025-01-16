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
        private ControllerInterface controllerInterface; // Intialise controller interface
        private JNDInterface jndInterface = new JNDInterface(true); // Initialise JND interface
        private int reversalNumber; // Number of reversals, initialised to 0, max 6
        private int trialNumber; // Number of trials
        private int V1; // Record V1 value in variable
        private int V2; // Record V2 value in variable 
        public VanillaForm()
        {
            InitializeComponent();
            controllerInterface = new ControllerInterface(this); // Create controller instance (listener enabled by default)
            controllerInterface.DisableListener(); // Disable listener while instructions are up
            VanillaInstructionsForm vanillaInstructionsForm = new VanillaInstructionsForm(); // Create the instructions form
            vanillaInstructionsForm.FormClosed += new FormClosedEventHandler(vanillaInstructionsFormClosed); // Add event handler to re-enable listener when instructions form is closed
            vanillaInstructionsForm.ShowDialog(); // Ensure users cannot interact with components while the instructions form exists
            createNextTrial(true);
        }
        private void vanillaInstructionsFormClosed(object sender, FormClosedEventArgs e) // Event handler to re-enable listener when instrunctions form is closed
        {
            controllerInterface.EnableListener();
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
        }
        private async void getOriginalStimuliButton_Click(object sender, EventArgs e)
        {
            disableAllButtons(); // Disable all buttons so user cannot input multiple commands
            controllerInterface.DisableListener(); // Disable listener so user cannot input multiple commands (via controller)
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
            disableAllButtons(); // Disable all buttons so user cannot input multiple commands
            controllerInterface.DisableListener(); // Disable listener so user cannot input multiple commands (via controller)
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
            disableAllButtons(); // Disable all buttons so user cannot input multiple commands (Just in case of noise/multiple successive inputs)
            controllerInterface.DisableListener(); // Disable listener so user cannot input multiple commands (via controller)
            // Check if user is correct and if reversal occurs (User input is that V2 is lower than V1), then get new V2 value
            V2 = jndInterface.checkReversalAndCalculateVDiff(true);
            // Update revesal number to check if reversal has occured
            reversalNumber = jndInterface.getReversalNumber();
            // Check if 6 reversals have occured, and if so, conclude this game (In gamified, include pin/visual logic by checking if a reversal has just occured)
            if (reversalNumber == 6)
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
            disableAllButtons(); // Disable all buttons so user cannot input multiple commands (Just in case of noise/multiple successive inputs)
            controllerInterface.DisableListener(); // Disable listener so user cannot input multiple commands (via controller)
            // Check if user is correct and if reversal occurs (User input is that V2 is higher than V1), then get new V2 value
            V2 = jndInterface.checkReversalAndCalculateVDiff(false);
            // Update revesal number to check if reversal has occured
            reversalNumber = jndInterface.getReversalNumber();
            // Check if 6 reversals have occured, and if so, conclude this game (In gamified, include pin/visual logic by checking if a reversal has just occured)
            if (reversalNumber == 6)
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
