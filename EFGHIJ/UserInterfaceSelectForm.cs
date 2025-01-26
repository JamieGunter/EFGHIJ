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

        private void vanillaButtonVersion1_Click_1(object sender, EventArgs e)
        {
            VanillaForm vanillaForm = new VanillaForm(1);
            vanillaForm.Show();
            this.Hide();
        }

        private void vanillaButtonVersion2_Click(object sender, EventArgs e)
        {
            VanillaForm vanillaForm = new VanillaForm(2);
            vanillaForm.Show();
            this.Hide();
        }

        private void vanillaButtonVersion3_Click(object sender, EventArgs e)
        {
            VanillaForm vanillaForm = new VanillaForm(3);
            vanillaForm.Show();
            this.Hide();
        }
        private void gamifiedButtonVersion1_Click(object sender, EventArgs e)
        {
            GamifiedForm gamifiedForm = new GamifiedForm();
            gamifiedForm.Show();
            this.Hide();
        }

        private void gamifiedButtonVersion2_Click(object sender, EventArgs e)
        {

        }

        private void gamifiedButtonVersion3_Click(object sender, EventArgs e)
        {

        }
    }
}
