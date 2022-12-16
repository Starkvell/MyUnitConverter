using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

    }
}