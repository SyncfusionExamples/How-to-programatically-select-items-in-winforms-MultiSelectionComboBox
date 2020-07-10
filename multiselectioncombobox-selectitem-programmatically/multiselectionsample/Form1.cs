using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiselectionsample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            multiSelectionComboBox1.ShowCheckBox = true;
            multiSelectionComboBox1.DataSource = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            //Set the select item in MultiSelectionComboBox
            multiSelectionComboBox1.SelectedItem = multiSelectionComboBox1.Items[4];
        }
    }
}
