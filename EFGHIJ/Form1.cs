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
        private DirectInput directInput;
        private Joystick joystick;
        private Controller controller;
        public vibrationDebugMenu()
        {
            InitializeComponent();
            InitializeController();
        }

        private void InitializeController()
        {
            controller = new Controller(UserIndex.One);
            if (controller.IsConnected)
            {
                MessageBox.Show("Controller is connected.");
            }
            else
            {
                MessageBox.Show("No controller found.");
            }
        }

        private void SetVibration(int leftMotor, int rightMotor)
        {
            if (controller != null && controller.IsConnected)
            {
                var vibration = new Vibration
                {
                    LeftMotorSpeed = (ushort)leftMotor,
                    RightMotorSpeed = (ushort)rightMotor
                };
                controller.SetVibration(vibration);
            }
        }

        private void OffButton_Click(object sender, EventArgs e)
        {
            SetVibration(0,0);
        }

        private void QuarterPercent_Click(object sender, EventArgs e)
        {
            SetVibration(16383, 16383);
        }

        private void FiftyPercent_Click(object sender, EventArgs e)
        {
            SetVibration(32767, 32767);
        }

        private void ThreeQuarterPercent_Click(object sender, EventArgs e)
        {
            SetVibration(49151, 49151);
        }

        private void MaxPercent_Click(object sender, EventArgs e)
        {
            SetVibration(65535, 65535);
        }

        private void vibrationTrackBar_Scroll(object sender, EventArgs e)
        {
            int vibrationValue = vibrationTrackBar.Value;
            vibrationLabel.Text = vibrationValue.ToString();
            int scaledValue = (int)(vibrationValue * 655.35);
            SetVibration(scaledValue, scaledValue);
        }
    }
}
