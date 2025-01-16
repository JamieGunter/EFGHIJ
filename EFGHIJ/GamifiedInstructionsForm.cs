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
    public partial class GamifiedInstructionsForm : Form
    {
        private string Initials;
        public GamifiedInstructionsForm()
        {
            InitializeComponent();
        }
        private void beginTaskButton_Click(object sender, EventArgs e)
        {
            if (initialsTextBox.Text.Length < 3) // If there is less than 3 characters (or left blank)
            {
                Initials = generateInitails(); // Generate random initials
            }
            else
            { 
                Initials = initialsTextBox.Text.Substring(0, 3); // Else use the inputted initials (truncated to first 3 chars)
            }
            this.Close();
        }
        private string generateInitails() // Generate initials if provided input was invalid
        {
            Random randomGen = new Random();
            const string characterPool = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"; // Pool of characters
            char[] initialsBuffer = new char[3]; // Initials buffer
            for (int i = 0; i < initialsBuffer.Length; i++)
            {
                initialsBuffer[i] = characterPool[randomGen.Next(characterPool.Length)];
            }
            return new string(initialsBuffer); // Cast char[] to string
        }
        public string GetInitials()
        {
            return Initials;
        }
    }
}
