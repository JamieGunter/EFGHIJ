using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX.DirectInput;
using SharpDX.XInput;

namespace EFGHIJ
{
    public partial class GamifiedForm : Form
    {
        private DirectInput directInput;
        private Joystick joystick;
        private Controller controller;
        public GamifiedForm()
        {
            InitializeComponent();
        }
    }
}
