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
    public partial class TaskConclusionForm : Form
    {
        private Form parentForm;
        public TaskConclusionForm(Form iParentForm)
        {
            InitializeComponent();
            parentForm = iParentForm;
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
