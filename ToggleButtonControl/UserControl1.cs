using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToggleButtonControl
{
    public partial class ToggleButton: UserControl
    {
        public bool IsON { get; set; } = true;
        public Color ONColor { get; set; } = Color.Lime;
        public Color OFFColor { get; set; } = Color.FromArgb(200, 200, 200);
        public string ONText { get; set; } = "ON";
        public string OFFText { get; set; } = "OFF";

        public ToggleButton()
        {
            InitializeComponent();
        }

        private void SwitchButton_Click(object sender, EventArgs e)
        {
            if (IsON)
            {
                //ON->OFF
                SwitchButton.Dock = DockStyle.Right;
                SwitchPanel.BackColor = OFFColor;
                ToggleButtonLabel.Text = OFFText;

            }
            else
            {
                //OFF->ON
                SwitchButton.Dock = DockStyle.Left;
                SwitchButton.BackColor = ONColor;
                ToggleButtonLabel.Text = ONText;
            }
            IsON = !IsON;
        }

    }
}
