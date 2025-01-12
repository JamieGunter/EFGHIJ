using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX.DirectInput;
using SharpDX.XInput;

namespace EFGHIJ
{
    internal class ControllerInterface
    {
        private Controller controller;
        public ControllerInterface()
        {
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

        public void SetVibration(int leftMotor, int rightMotor)
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
    }
}
