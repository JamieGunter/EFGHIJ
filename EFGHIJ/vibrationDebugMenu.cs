using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SharpDX.DirectInput;
using SharpDX.XInput;
using System.Threading;


namespace EFGHIJ
{
    public partial class vibrationDebugMenu : Form
    {
        private ControllerInterface controllerInterface;
        public vibrationDebugMenu()
        {
            InitializeComponent();
            controllerInterface = new ControllerInterface(this);
        }

        private void OffButton_Click(object sender, EventArgs e)
        {
            controllerInterface.SetVibration(0,0);
        }

        private void QuarterPercent_Click(object sender, EventArgs e)
        {
            controllerInterface.SetVibration(16383, 16383);
        }

        private void FiftyPercent_Click(object sender, EventArgs e)
        {
            controllerInterface.SetVibration(32767, 32767);
        }

        private void ThreeQuarterPercent_Click(object sender, EventArgs e)
        {
            controllerInterface.SetVibration(49151, 49151);
        }

        private void MaxPercent_Click(object sender, EventArgs e)
        {
            controllerInterface.SetVibration(65535, 65535);
        }

        private void vibrationTrackBar_Scroll(object sender, EventArgs e)
        {
            int vibrationValue = vibrationTrackBar.Value;
            vibrationLabel.Text = vibrationValue.ToString();
            int scaledValue = (int)(vibrationValue * 655.35);
            controllerInterface.SetVibration(scaledValue, scaledValue);
        }
    }
}
