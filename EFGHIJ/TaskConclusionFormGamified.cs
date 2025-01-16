using System;
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
    public partial class TaskConclusionFormGamified : Form
    {
        private Form parentForm;
        private string contestantInitials; // Initialise Contestant's initials string
        private int contestantRank; // Initialise Contestant's rank
        private double Score; // Initialise score 
        private ScoreboardInterface scoreBoard; // Initialise scoreboard interface
        public TaskConclusionFormGamified(Form iParentForm, string iContestantInitials, double iScore)
        {
            InitializeComponent();
            parentForm = iParentForm;
            contestantInitials = iContestantInitials;
            Score = iScore;
            scoreBoard = new ScoreboardInterface(contestantInitials); // Create scoreboard interface instance
            ScoreLeaderboardDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Make the DVG columns fill the width of the DGV
            ScoreLeaderboardDGV.RowHeadersVisible = false; // Remove row header in DVG
            ScoreLeaderboardDGV.DataSource = scoreBoard.GetScoreboardForDGV(); // Set the data source of the form's DGV to the scoreboard (populate it)
            for (int i = 0; i < ScoreLeaderboardDGV.Rows.Count; i++)
            {
                var tempInitialsRecord = ScoreLeaderboardDGV.Rows[i].Cells["Initials"].Value;
                if (tempInitialsRecord != null && tempInitialsRecord.ToString() == contestantInitials)
                {
                    contestantRank = i + 1; // 0 Indexed, so add 1
                }
            }
            finalScoresLabel.Text = $"Your final score was: {Score}\nThis places you: {contestantRank}/{ScoreLeaderboardDGV.RowCount - 1}!";
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            parentForm.Hide();
            userInterfaceSelectForm userInterfaceSelectForm = new userInterfaceSelectForm();
            userInterfaceSelectForm.Show();
        }
    }
}
