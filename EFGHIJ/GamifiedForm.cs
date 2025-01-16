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
    public partial class GamifiedForm : Form
    {
        private ControllerInterface controllerInterface; // Intialise controller interface
        private JNDInterface jndInterface = new JNDInterface(false); // Initialise JND interface
        private int reversalNumber; // Number of reversals, initialised to 0, max 6
        private int trialNumber; // Number of trials
        private int V1; // Record V1 value in variable
        private int V2; // Record V2 value in variable 
        private double previousVDiff; // Record previous VDiff value in variable
        private double Score = 1000.0; // Player's score, initialised to 1000.0
        private int Streak = 0; // Player's streak, initialised to 0
        public GamifiedForm()
        {
            InitializeComponent();
            controllerInterface = new ControllerInterface(this); // Create controller instance (listener enabled by default)
            controllerInterface.DisableListener(); // Disable listener while instructions are up
            GamifiedInstructionsForm gamifiedInstructionsForm = new GamifiedInstructionsForm(); // Create the instructions form
            gamifiedInstructionsForm.FormClosed += new FormClosedEventHandler(gamifiedInstructionsFormClosed); // Add event handler to re-enable listener when instructions form is closed
            gamifiedInstructionsForm.ShowDialog(); // Ensure users cannot interact with components while the instructions form exists
            GamifiedTaskNumberTitle.Text = "Trial: " + trialNumber.ToString(); // Initialise task number label
            GamifiedScoreTitle.Text = "Score: " + Score.ToString(); // Initialise score label
            GamifiedStreakTitle.Text = "Streak: " + Streak.ToString(); // Initialise streak label
            createNextTrial(true);
        }
        private void gamifiedInstructionsFormClosed(object sender, FormClosedEventArgs e) // Event handler to re-enable listener when instrunctions form is closed
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
            else
            {
                if (jndInterface.getVDiff() < previousVDiff) // Won last trial
                {
                    Score += 100.0 + (50 * Streak); // Add 100 score + Streak bonus
                }
                else // Lost last trial
                {
                    Score -= 100.0 - (50 * Streak); ; // Remove 100 score + Streak bonus (Negative multiplier)
                }
                updateScoreLabel(); // Update the score visually
            }
            V1 = jndInterface.getV1Value(); // Get V1 value
            V2 = jndInterface.getV2Value(); // Get V2 value
            previousVDiff = jndInterface.getVDiff(); // Get previous VDiff value
            trialNumber = jndInterface.getTrialNumber(); // Get current trial number
            GamifiedTaskNumberTitle.Text = "Trial: " + trialNumber.ToString(); // Update trial number label
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
            int tempReversalCount = reversalNumber; // Store temp reversal number for streak calculation
            V2 = jndInterface.checkReversalAndCalculateVDiff(true); // Get new V2 value
            // Update revesal number to check if reversal has occured
            reversalNumber = jndInterface.getReversalNumber();
            if (tempReversalCount == reversalNumber) // If no reversal has occured (Current streak is ongoing)
            {
                if (jndInterface.getVDiff() < previousVDiff) // Won last trial (Win streak)
                {
                    Streak++; // Increment streak
                }
                else // Lost last trial (Loss streak)
                {
                    Streak--; // Decrement streak
                }
            }
            else // If a reversal has occured, reset streak to 0
            {
                Streak = 0;
                PictureBox tempLives = this.Controls.Find($"Lives{7 - reversalNumber}Picture", true)[0] as PictureBox; // Get the specific "lives" picture box  
                tempLives.BackColor = Color.DarkRed; // Change background colour to red to signify loss of a life
            }
            updateStreakLabel(); // Update the streak visually
            // Check if 6 reversals have occured, and if so, conclude this game (In gamified, include pin/visual logic by checking if a reversal has just occured)
            if (reversalNumber == 6)
            {
                // Do final visual score update
                if (jndInterface.getVDiff() < previousVDiff) // Won last trial
                {
                    Score += 100.0; // Add 100 score
                }
                else // Lost last trial
                {
                    Score -= 100.0; // Remove 100 score
                }
                updateScoreLabel(); // Update the score visually
                TaskConclusionForm taskConclusionForm = new TaskConclusionForm(this);
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
            int tempReversalCount = reversalNumber; // Store temp reversal number for streak calculation
            V2 = jndInterface.checkReversalAndCalculateVDiff(false); // Get new V2 value
            // Update revesal number to check if reversal has occured
            reversalNumber = jndInterface.getReversalNumber();
            if (tempReversalCount == reversalNumber) // If no reversal has occured (Current streak is ongoing)
            {
                if (jndInterface.getVDiff() < previousVDiff) // Won last trial (Win streak)
                {
                    Streak++; // Increment streak
                }
                else // Lost last trial (Loss streak)
                {
                    Streak--; // Decrement streak
                }
            }
            else // If a reversal has occured, reset streak to 0
            {
                Streak = 0; // Reset streak
                PictureBox tempLives = this.Controls.Find($"Lives{7 - reversalNumber}Picture", true)[0] as PictureBox; // Get the specific "lives" picture box  
                tempLives.BackColor = Color.DarkRed; // Change background colour to red to signify loss of a life
            }
            updateStreakLabel(); // Update the streak visually
            // Check if 6 reversals have occured, and if so, conclude this game (In gamified, include pin/visual logic by checking if a reversal has just occured)
            if (reversalNumber == 6)
            {
                // Do final visual score update
                if (jndInterface.getVDiff() < previousVDiff) // Won last trial
                {
                    Score += 100.0; // Add 100 score
                }
                else // Lost last trial
                {
                    Score -= 100.0; // Remove 100 score
                }
                updateScoreLabel(); // Update the score visually
                TaskConclusionForm taskConclusionForm = new TaskConclusionForm(this);
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
        private void updateScoreLabel()
        {
            GamifiedScoreTitle.Text = "Score: " + Score.ToString(); // Update score label
        }
        private void updateStreakLabel()
        {
            GamifiedStreakTitle.Text = "Streak: " + Streak.ToString(); // Update streak label
        }
    }
}
