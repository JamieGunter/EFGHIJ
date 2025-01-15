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
    public partial class VanillaInstructionsForm : Form
    {
        public VanillaInstructionsForm()
        {
            InitializeComponent();
        }

        private void beginTaskButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
