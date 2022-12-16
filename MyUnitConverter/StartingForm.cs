using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnitsNet;

namespace MyUnitConverter
{
    public partial class StartingForm : Form
    {
        private StatusBarController _statusBarController;
        private int _quantitySelected = 0;
        List<ToolStripMenuItem> roundOffMenuItems = new List<ToolStripMenuItem>();
        private readonly QuantityInfo[] _quantityInfos = {Length.Info,Mass.Info,Speed.Info,Area.Info,Energy.Info,Force.Info};
        public StartingForm()
        {
            InitializeComponent();
            _statusBarController = new StatusBarController(StatusBarStrip, StatusLabel);
            QuantityPicker.SelectedIndex = 0;
            //MainBoxMenuStrip.Renderer = new SelectorColourRenderer(); хз зачем пока
            UpdateComboBoxes(_quantityInfos[0]);
        }

        public void UpdateComboBoxes(QuantityInfo quantity)
        {
            UnitInfo[] unitNames = quantity.UnitInfos;
            FromUnitPicker.Items.Clear();
            ToUnitPicker.Items.Clear();
        
            foreach (UnitInfo unitName in unitNames)
            {
                FromUnitPicker.Items.Add(unitName.Name);
                ToUnitPicker.Items.Add(unitName.Name);
            }
        
            FromUnitPicker.SelectedIndex = 0;
            ToUnitPicker.SelectedIndex = 1;
        }
        
        private void QuantityPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            _quantitySelected = QuantityPicker.SelectedIndex;
            UpdateComboBoxes(_quantityInfos[_quantitySelected]);
            ClearAll();
        }
        
        private void SetQuantitySelected(int value)
        {
            _quantitySelected = value;
        }
        
        private int GetQuantitySelected()
        {
            return _quantitySelected;
        }
        
        private void ClearAll()
        {
            InputBox.Text = "";
            _statusBarController.SetToReady();
        }
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            AboutUnitConverter aboutUnitConverter = new AboutUnitConverter(); 
            if (this.TopMost)
                aboutUnitConverter.TopMost = true;
            aboutUnitConverter.Show();
        }
        
        private void Calculate()
        {
            string fromUnitName = (string)FromUnitPicker.SelectedItem;
            string toUnitName = (string)ToUnitPicker.SelectedItem;
            if (fromUnitName == null || toUnitName == null) return;
            bool canParse = double.TryParse(InputBox.Text, out double inputValue);
            if (canParse)
            {
                var result = UnitConverter.ConvertByName(inputValue, QuantityPicker.SelectedItem.ToString(),
                    fromUnitName,
                    toUnitName);
                OutputBox.Text = result.ToString();
                _statusBarController.SetToDone();
            }
            else if (string.IsNullOrWhiteSpace(InputBox.Text))
            {
                OutputBox.Text = "0";
                _statusBarController.SetToReady();
            }

            else
            {
                OutputBox.Text = "0";
                _statusBarController.SetToInvalidInput();
            }
        }
        
        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void FromUnitPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void ToUnitPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void SwapButton_Click(object sender, EventArgs e)
        {
            (FromUnitPicker.SelectedIndex, ToUnitPicker.SelectedIndex) = (ToUnitPicker.SelectedIndex, FromUnitPicker.SelectedIndex);
        }
    }
}