using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using SharpDX.DirectInput;
using SharpDX.XInput;

namespace EFGHIJ
{
    internal class ControllerInterface
    {
        private Controller controller;
        private Form parentForm;
        private Thread listenerThread;
        private Joystick dPad;
        private volatile bool threadBusy;
        private object variableLock = new object();
        public ControllerInterface(Form iParentForm)
        {
            InitializeController();
            parentForm = iParentForm;
            listenerThread = new Thread(listenDPad);
            listenerThread.IsBackground = true;
            listenerThread.Start();
        }
        private void InitializeController() // Initialise by checking if a controller is connected, then initialise dPad
        {
            // Check if a controller is connected, throw error if not
            controller = new Controller(UserIndex.One);
            if (!controller.IsConnected)
            {
                MessageBox.Show("No controller found.");
            }
            // Intialise dPad
            var directInput = new DirectInput();
            var gamePad = directInput.GetDevices(SharpDX.DirectInput.DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices).Select(DeviceInstance => DeviceInstance.InstanceGuid).FirstOrDefault();
            dPad = new Joystick(directInput, gamePad);
            dPad.Properties.BufferSize = 128;
            dPad.Acquire();
        }
        public void SetVibration(int leftMotor, int rightMotor) // Functon to set motor(s) to specific value from 0 to 65535
        {
            if (controller != null && controller.IsConnected) // Check if a controller is connected and exists
            {
                var vibration = new Vibration // Create object with casted parsed values
                {
                    LeftMotorSpeed = (ushort)leftMotor,
                    RightMotorSpeed = (ushort)rightMotor
                };
                controller.SetVibration(vibration); // Set the vibration to the parsed in values
            }
        }
        private async void clickButton(string buttonName, int durationOfAction) // Simulate button click (called by thread), second variable used for denoise/input conflict prevention
        {
            lock (variableLock) // Ensure that only 1 thread can access and manipulate the threadBusy variable at once, thus preventing multiple threads executing the same action
            {
                if (threadBusy) return;
                threadBusy = true; // Flag that action is in progress
            }
            var tempButton = parentForm.Controls.Find(buttonName, true).FirstOrDefault() as Button;
            if (tempButton != null)
            {
                if (tempButton.InvokeRequired)
                {
                    tempButton.Invoke(new Action(() => tempButton.PerformClick()));
                }
                else
                {
                    tempButton.PerformClick();
                }
            }
            await Task.Delay(durationOfAction); // Wait until the action is completed (stimulus duration)
            lock (variableLock)
            {
                threadBusy = false; // Flag that action has concluded
            }
        }
        private void listenDPad()
        {
            while (true) // Keep polling
            {
                if (dPad != null && !threadBusy) // If the dPad exists and there isn't a current action going on
                { 
                    dPad.Poll(); // Poll the dPad
                    var dPadBufferData = dPad.GetBufferedData(); // Get dPad data
                    // For each data entry (direction) in the buffer
                    foreach (var directionState in dPadBufferData)
                    {
                        switch (directionState.Value)
                        {
                            case 0: // Up direction (Get original stimulus again) 
                                clickButton("getOriginalStimuliButton", 2000);
                                break;
                            case 9000: // Right direction (V2 is higher button)
                                clickButton("V2IsNotLowerButton", 6000);
                                break;
                            case 18000: // Down direction (Get new stimulus again)
                                clickButton("getNewStimuliButton", 2000);
                                break;
                            case 27000: // Left direction (V2 is lower button)
                                clickButton("V2IsLowerButton", 6000);
                                break;
                            default: // Neutral/No direction
                                // Do nothing
                                break;
                        }
                    }
                }
                Thread.Sleep(10); // Limit poll amount
            }
        }
        public void EnableListener() // Allows external classes to enable the listener by making threadBusy false
        {
            lock (variableLock)
            {
                threadBusy = false; // Flag that thread is busy
            }
            clearInputBuffer(); // Clears any buffered input received whilst the thread was busy
        }
        public void DisableListener() // Allows external classes to disable the listener by making threadBusy true
        {
            lock (variableLock)
            {
                threadBusy = true; // Flag that thread is no-longer busy
            }
        }
        private async void clearInputBuffer() // Clears any buffered input received whilst the thread was busy
        {
            dPad.Poll(); // Poll the dPad
            dPad.GetBufferedData(); // Get any stale inputs (thus clearing the buffer and not processing them)
        }
    }
}
