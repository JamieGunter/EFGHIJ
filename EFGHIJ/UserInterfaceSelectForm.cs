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
    public partial class userInterfaceSelectForm : Form
    {
        public userInterfaceSelectForm()
        {
            InitializeComponent();
        }

        private void gamifiedButton_Click(object sender, EventArgs e)
        {
            GamifiedForm gamifiedForm = new GamifiedForm();
            gamifiedForm.Show();
            this.Hide();
        }

        private void vanillaButton_Click_1(object sender, EventArgs e)
        {
            VanillaForm vanillaForm = new VanillaForm();
            vanillaForm.Show();
            this.Hide();
        }
    }
}
