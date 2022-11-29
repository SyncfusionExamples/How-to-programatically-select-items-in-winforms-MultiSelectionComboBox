# How-to-programatically-select-items-in-winforms-MultiSelectionComboBox
This example demonstrates how to use the MultiSelectionComboBox in Winforms to programmatically select items. For more details please refer [How to programatically select items in MultiSelectionComboBox](https://www.syncfusion.com/kb/11708/how-to-select-the-item-programmatically-in-winforms-multiselectioncombobox)

# C#
    public Form1()
            {
                InitializeComponent();
                multiSelectionComboBox1.ShowCheckBox = true;
                multiSelectionComboBox1.DataSource = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

                //Set the select item in MultiSelectionComboBox
                multiSelectionComboBox1.SelectedItem = multiSelectionComboBox1.Items[4];
            }
