using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace EFGHIJ
{
    internal class JNDInterface
    {
        private const int VMax = 65535; // Constant for maximum vibration value of each motor
        private int versionNumber; // Version number of the JND interface
        private int reversalNumber = 0; // Number of reversals, initialised to 0, max 6
        private int trialNumber = 0; // Number of trials
        private int V1; // Permanent initial reference stimuli or "V1", assigned at initialisation
        private int V2; // Compared stimuli value or "V2"
        private double VDiff = 20.0; // Difference (as percentage) between V1 and V2, default 20% of maximum (65535)
        private bool? lastResponseWasCorrect = null; // Previous user input state tracker for reversal detection (nullable for first run having no previous result)
        private bool isVanilla; // Flag for if it is vanilla trial (saving purposes)
        private string filePath; // Variable for the path to excel sheet(s)
        private int contestantNumber; // Current contestant number (for speadsheet)
        private int boundsNumber = 0; // Number of bounds (either vDiff Max or 0) the user hits, 3 results in trial conclusion
        private Random randomGen = new Random(); // Generate random number for V1 initialisation (and V2 sign)

        public JNDInterface(bool iIsVanilla, int iVersionNumber) // Constructor of JND Interface
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Set EPPlus license to non-commercial
            isVanilla = iIsVanilla; // Set vanilla flag
            versionNumber = iVersionNumber;
            switch (versionNumber) // Switch the version number and thus the initial V1 value
            {
                case 1:
                    V1 = VMax / 4; // Set V1 to 25% of maximum
                    break;
                case 2:
                    V1 = VMax / 2; // Set V1 to 50% of maximum
                    break;
                case 3:
                    V1 = (int)(VMax * 0.75); // Set V1 to 75% of maximum
                    break;
            }
            generateStimuliValues(); // Initialise V1 and generate V2 value
            initialiseSaving(); // Initialise saving (and create a new contestent spreadsheet)
        }
        public int userTimeOut() // If the user exceeds the 3 second timer, count as incorrect but do not consider reversal logic
        {
            // Record current state (including current temp variables) and write to file
            recordCurrentState(null, null, false);
            // Apply incorrect logic to VDiff
            VDiff = (VDiff + (VDiff * 0.5)) + 0.1; // Move further from V1 by adding 50% of vDiff (if incorrect), then add 0.1%, so if a user hits 0% vDiff, they can rise above 0%
            // Ensure VDiff cannot go below 0
            // Side note: Also ensures that consistent correct answers eventually lead to V1 = V2, and therefore mandatory reversal
            VDiff = Math.Max(0, Math.Min(100, VDiff));
            // Note: Program acknowledges reversal occurance by checking reversal number after calling this function
            return generateStimuliValues();
        }
        public int checkReversalAndCalculateVDiff(bool IsLowerUserInput)
        {
            bool ReversalOccured = false; // Initialised to false, unless proven otherwise later
            // Check if the user is correct
            bool UserCorrect = ((V2 < V1) && IsLowerUserInput) || ((V2 > V1) && !IsLowerUserInput);
            // Check if reversal has occured (and it isn't the first trial)
            if (lastResponseWasCorrect.HasValue)
            {
                ReversalOccured = (UserCorrect != lastResponseWasCorrect);
                // If reversal has occured, increment reversal number
                if (ReversalOccured)
                {
                    reversalNumber++;
                }
            }
            // Record current state (including current temp variables) and write to file
            recordCurrentState(IsLowerUserInput, UserCorrect, ReversalOccured);
            // Update last response correct state
            lastResponseWasCorrect = UserCorrect;
            // Calculate new VDiff value
            if (UserCorrect) // If user is correct
            {
                VDiff = (VDiff / 2) - 0.1; // Move closer towards V1 by halving difference (if correct), then subtract 0.1% so the user can reach 0% vDiff (flat mutation value) and get a reversal
            }
            else // If the user is incorrect
            {
                VDiff = (VDiff + (VDiff * 0.5)) + 0.1; // Move further from V1 by adding 50% of vDiff (if incorrect), then add 0.1%, so if a user hits 0% vDiff, they can rise above 0%
            }
            // Ensure VDiff cannot go below 0
            // Side note: Also ensures that consistent correct answers eventually lead to V1 = V2, and therefore mandatory reversal
            VDiff = Math.Max(0, Math.Min(100, VDiff));
            // Note: Program acknowledges reversal occurance by checking reversal number after calling this function
            return generateStimuliValues();
        }
        private int generateStimuliValues() // Initialise V1 and generate V2 value (return value for potential design choice)
        {
            // Generate sign for V2
            int v2IsNegative = randomGen.Next(0,2); // Randomly check if V2 will be negative or positive
            if (v2IsNegative == 1)
            {
                V2 = V1 - (int)(VMax * (VDiff / 100)); // If negative, make V2 lower than V1 by VDiff percentage
            }
            else
            {
                V2 = V1 + (int)(VMax * (VDiff / 100)); // If positive, make V2 higher than V1 by VDiff percentage
            }
            trialNumber++; // Increment trial number
            V2 = Math.Max(0, Math.Min(VMax, V2)); // Ensure V2 is within bounds of controller (0 and 65535), then return V2
            if (V2 == VMax || V2 == 0)
            {
                boundsNumber++; // Increment bounds number if V2 is a boundary value
            }
            return V2; 
        }
        private void initialiseSaving()
        {
            if (isVanilla)
            {
                filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "VanillaTrialResults", "VanillaResults.xlsx"); // Set file path to the Vanilla trial folder
            }
            else
            {
                filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "GamifiedTrialResults", "GamifiedResults.xlsx"); // Set file path to the Gamified trial folder
            }
            if (!File.Exists(filePath)) // If the file doesnt exist already in path
            {
                using (ExcelPackage package = new ExcelPackage())
                {
                    makeNewContestantWorksheet(package); // Create new contestant worksheet
                    package.SaveAs(new FileInfo(filePath)); // Save As the file to the filepath
                }
            }
            else // If the file does exist in path
            {
                using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
                {
                    makeNewContestantWorksheet(package); // Create new contestant worksheet
                    package.Save(); // Save the file to the filepath
                }
            }
        }
        private void makeNewContestantWorksheet(ExcelPackage iPackage)
        {
            contestantNumber = iPackage.Workbook.Worksheets.Count + 1;
            ExcelWorksheet GamifiedResults = iPackage.Workbook.Worksheets.Add($"Contestant{contestantNumber}Version{versionNumber}");
            GamifiedResults.Cells[1, 1].Value = "trialNumber";
            GamifiedResults.Cells[1, 2].Value = "v1Value";
            GamifiedResults.Cells[1, 3].Value = "v2Value";
            GamifiedResults.Cells[1, 4].Value = "vDiffValue";
            GamifiedResults.Cells[1, 5].Value = "userInput";
            GamifiedResults.Cells[1, 6].Value = "isInputCorrect";
            GamifiedResults.Cells[1, 7].Value = "isLastResponseCorrect";
            GamifiedResults.Cells[1, 8].Value = "isReversal";
            GamifiedResults.Cells[1, 9].Value = "totalReversalNumberInclusive";
            GamifiedResults.Cells[1, 10].Value = "boundsNumber";
        }
        private void recordCurrentState(bool? iIsLowerUserInput, bool? iUserCorrect, bool iReversalOccured) // Records current state and writes to file for data analysis
        {
            string IsLowerUserInputString;
            if (iIsLowerUserInput == true) // Convert the user input boolean into readable string for saving
            {
                IsLowerUserInputString = "Lower";
            }
            else if (iIsLowerUserInput == false)
            {
                IsLowerUserInputString = "Higher";
            }
            else
            {
                IsLowerUserInputString = "TimeOut";
            }
            using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet currentContestant = package.Workbook.Worksheets[package.Workbook.Worksheets.Count - 1]; // Open current worksheet (0 indexed)
                int currentNewRow = currentContestant.Dimension.End.Row + 1; // Get the final row and add 1 to get the next row to write in
                currentContestant.Cells[currentNewRow, 1].Value = trialNumber;
                currentContestant.Cells[currentNewRow, 2].Value = V1;
                currentContestant.Cells[currentNewRow, 3].Value = V2;
                currentContestant.Cells[currentNewRow, 4].Value = VDiff;
                currentContestant.Cells[currentNewRow, 5].Value = IsLowerUserInputString;
                currentContestant.Cells[currentNewRow, 6].Value = iUserCorrect;
                currentContestant.Cells[currentNewRow, 7].Value = lastResponseWasCorrect;
                currentContestant.Cells[currentNewRow, 8].Value = iReversalOccured;
                currentContestant.Cells[currentNewRow, 9].Value = reversalNumber;
                currentContestant.Cells[currentNewRow, 10].Value = boundsNumber;
                package.Save(); // Save the file to the filepath
            }
        }
        public int getReversalNumber() // Get reversal number
        { 
            return reversalNumber; 
        }
        public int getTrialNumber() // Get trial number
        {
            return trialNumber;
        }
        public int getV1Value() // Get V1 value (for reference to user)
        {
            return V1;
        }
        public int getV2Value() // Get V2 value (for reference to user)
        {
            return V2;
        }
        public double getVDiff() // Get VDiff value (to calculate score in gamified verison)
        {
            return VDiff;
        }
        public int getBoundsNumber() // Get Bound number (to calculate if user has exceeded boundary limit)
        {
            return boundsNumber;
        }
    }
}
