using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace EFGHIJ
{
    internal class ScoreboardInterface
    {
        private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "GamifiedTrialResults", "GamifiedScoreboard.xlsx"); // Variable for the path to excel sheet(s)
        private string contestantInitials; // Variable for the contestant's initials
        private double currentScore; // Variable for the current score
        private int? contestantRow = null; // Contestant's row
        public ScoreboardInterface(string iContestantInitials)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Set EPPlus license to non-commercial
            contestantInitials = iContestantInitials.Substring(0, Math.Min(3, iContestantInitials.Length)); // Set contestant initials (if over 3 chars, truncate rest over first 3)
            initialiseSaving(); // Initialise saving (and create a new contestent scoreboard if necessary)
        }
        private void initialiseSaving()
        {
            if (!File.Exists(filePath)) // If the file doesnt exist already in path
            {
                using (ExcelPackage package = new ExcelPackage())
                {
                    makeNewScoreboardWorksheet(package); // Create new scoreboard worksheet
                    package.SaveAs(new FileInfo(filePath)); // Save As the file to the filepath
                }
            }
        }
        private void makeNewScoreboardWorksheet(ExcelPackage iPackage)
        {
            ExcelWorksheet ContestantScoreboard = iPackage.Workbook.Worksheets.Add("Scoreboard");
            ContestantScoreboard.Cells[1, 1].Value = "Initials";
            ContestantScoreboard.Cells[1, 2].Value = "Score";
        }
        private void updateScoreboard() // Update the scoreboard
        {
            using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet scoreboardWorksheet = package.Workbook.Worksheets[0]; // Open current worksheet (0 indexed)
                int currentNewRow = scoreboardWorksheet.Dimension.End.Row + 1; // Get the final row and add 1 to get the next row to write in

                for (int i = 2; i <= scoreboardWorksheet.Dimension.End.Row; i++) // Check if the contestant's initials already exists
                {
                    if (scoreboardWorksheet.Cells[i, 1].Text == contestantInitials)
                    {
                        contestantRow = i;
                        break;
                    }
                }
                if (contestantRow == null) // If the contestant's initials doesn't exist, add to the bottom
                {
                    scoreboardWorksheet.Cells[currentNewRow, 1].Value = contestantInitials;
                    scoreboardWorksheet.Cells[currentNewRow, 2].Value = currentScore;
                }
                else // Else update the existing record
                {
                    scoreboardWorksheet.Cells[contestantRow.Value, 2].Value = currentScore;
                }
                package.Save();
            }
        }
        public void updateScoreValue(double iScore) // Update the current score to the new score
        {
            currentScore = iScore;
            updateScoreboard(); // Update the scoreboard
        }
        public DataTable GetScoreboardForDGV()
        {
            DataTable dataTable = new DataTable(); // Create datatable object
            dataTable.Columns.Add("Initials"); // Add the initials column header
            dataTable.Columns.Add("Score", typeof(double)); // Add the score column header

            using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet scoreboardWorksheet = package.Workbook.Worksheets[0]; // Open current worksheet (0 indexed)

                for (int i = 2; i <= scoreboardWorksheet.Dimension.End.Row; i++) // Ignoring the header row
                {
                    string contestantInitials = scoreboardWorksheet.Cells[i, 1].Text; // Add each contestant's initials
                    double contestantScore = double.Parse(scoreboardWorksheet.Cells[i, 2].Text); // Add each contestant's score
                    dataTable.Rows.Add(contestantInitials, contestantScore); // To the datatable object
                }
            }
            DataView dataView = dataTable.DefaultView; // Create a data view object
            dataView.Sort = "Score DESC"; // Sort the data view by descending score (so highest at top)
            return dataView.ToTable(); // Return the datatable
        }
    }
}
