using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFGHIJ
{
    internal class JNDInterface
    {
        private int reversalNumber = 0; // Number of reversals, initialised to 0, max 6
        private int trialNumber = 0; // Number of trials
        private int? V1 = 32767; // Permanent initial reference stimuli or "V1", default 32767 or 50% ("?" notation so can be nullable for assignment possibility)
        private int V2; // Compared stimuli value or "V2"
        private double VDiff = 20.0; // Difference (as percentage) between V1 and V2, default 20% of maximum (65535)
        private double VDiffMutator = 0.5; // Mutator value for percentage difference, default 0.5% of maximum (65535)
        private bool lastResponseWasCorrect = true; // Previous user input state tracker for reversal detection
        private Random randomGen = new Random(); // Generate random number for V1 initialisation (and V2 sign)

        public JNDInterface() // Constructor of JND Interface
        {
            generateStimuliValues(); // Initialise V1 and generate V2 value
        }
        public int checkReversalAndCalculateVDiff(bool IsLowerUserInput)
        {
            // Check if the user is correct
            bool UserCorrect = ((V2 < V1) && IsLowerUserInput) || ((V2 > V1) && !IsLowerUserInput);
            // Check if reversal has occured 
            bool ReversalOccured = UserCorrect != lastResponseWasCorrect;
            // If reversal has occured and it is not the first trial, increment reversal number
            if (ReversalOccured && trialNumber != 1)
            {
                reversalNumber++;
            }
            // Calculate new VDiff value
            if (UserCorrect) // If user is correct
            {
                VDiff = VDiff - VDiffMutator; // Move closer towards V1
            }
            else // If the user is incorrect
            { 
                VDiff = VDiff + VDiffMutator; // Move further from V1
            }
            // Ensure VDiff cannot go below 0 (occurs if VDiffMutator is changed to less "round" number)
            // Side note: Also ensures that consistent correct answers eventually lead to V1 = V2, and therefore mandatory reversal
            VDiff = Math.Max(0,VDiff);
            // Record current state (including current temp variables) and write to file
            recordCurrentState(IsLowerUserInput, UserCorrect, ReversalOccured);
            // Update last response correct state
            lastResponseWasCorrect = UserCorrect;
            // Calculate the new V2 value and return it
            // Note: Program acknowledges reversal occurance by checking reversal number after calling this function
            return generateStimuliValues();
        }
        private int generateStimuliValues() // Initialise V1 and generate V2 value
        {
            // If V1 unassigned (By removing initialise value above)
            if (V1 == null)
            {
                V1 = randomGen.Next(13762, 51773); // Generate random value for V1 (between 21% and 79% of maximum)
            }
            // Generate sign for V2
            int v2IsNegative = randomGen.Next(0,2); // Randomly check if V2 will be negative or positive
            if (v2IsNegative == 1)
            {
                V2 = V1.Value - (int)(V1.Value * (VDiff / 100)); // If negative, make V2 lower than V1 by VDiff percentage
            }
            else
            {
                V2 = V1.Value + (int)(V1.Value * (VDiff / 100)); // If positive, make V2 higher than V1 by VDiff percentage
            }
            trialNumber++; // Increment trial number
            return Math.Max(0, Math.Min(65535, V2)); // Ensure V2 is within bounds of controller (0 and 65535), then return V2
        }
        private void recordCurrentState(bool iIsLowerUserInput, bool iUserCorrect, bool iReversalOccured) // Records current state and writes to file for data analysis
        {
            // RECORD USER DATA HERE - TBI
            //
            //
            //
        }
        public int getReversalNumber() // Get reversal number
        { 
            return reversalNumber; 
        }
        public int getV1Value() // Get V1 value (for reference to user)
        {
            return V1.Value;
        }
        public int getV2Value() // Get V2 value (for reference to user)
        {
            return V2;
        }
    }
}
