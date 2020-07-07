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
            multiSelectionComboBox1.SelectedItem = multiSelectionComboBox1.Items[4];

        }

        private void Form1_Load1(object sender, EventArgs e)
        {
            List<string> tempList = new List<string>();
            for (int i = 0; i < this.multiSelectionComboBox1.Items.Count; i++)
            {
                var value = this.multiSelectionComboBox1.Items[i];
                if ((value.Equals("Monday") && !tempList.Contains("Monday")) || (value.Equals("Tuesday") && !tempList.Contains("Tuesday")))
                {
                    tempList.Add(value.ToString());
                    this.multiSelectionComboBox1.SelectedItems.Add(value.ToString());
                }
            }
        }
    }
}
