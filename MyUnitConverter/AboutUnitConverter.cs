using System;
using System.Windows.Forms;

namespace MyUnitConverter
{
    public partial class AboutUnitConverter : Form
    {
        public AboutUnitConverter()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}