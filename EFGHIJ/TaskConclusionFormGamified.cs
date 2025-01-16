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
        public TaskConclusionFormGamified(Form iParentForm)
        {
            InitializeComponent();
            parentForm = iParentForm;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            parentForm.Close();
            userInterfaceSelectForm userInterfaceSelectForm = new userInterfaceSelectForm();
            userInterfaceSelectForm.Show();
        }
    }
}
