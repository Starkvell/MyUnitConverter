using System.Drawing;
using System.Windows.Forms;

namespace MyUnitConverter
{
    public class StatusBarController
    {
        private StatusStrip _statusStrip;
        private ToolStripStatusLabel _statusLabel;

        private readonly Color _errorColour = Color.FromArgb(192, 0, 0);
        private readonly Color _standardColour = Color.FromArgb(210, 90, 0);
        private readonly Color _positiveColour = Color.FromArgb(0, 128, 0);

        public StatusBarController(StatusStrip pStatusStrip, ToolStripStatusLabel pStatusLabel)
        {
            _statusStrip = pStatusStrip;
            _statusLabel = pStatusLabel;
        }

        public void SetToReady()
        {
            _statusStrip.BackColor = _standardColour;
            _statusLabel.BackColor = _standardColour;
            _statusLabel.Text = "Ready";
        }

        public void SetToDone()
        {
            _statusStrip.BackColor = _positiveColour;
            _statusLabel.BackColor = _positiveColour;
            _statusLabel.Text = "Done";
        }

        public void SetToInvalidInput()
        {
            _statusStrip.BackColor = _errorColour;
            _statusLabel.BackColor = _errorColour;
            _statusLabel.Text = "Invalid input(s)!";
        }
    }
}