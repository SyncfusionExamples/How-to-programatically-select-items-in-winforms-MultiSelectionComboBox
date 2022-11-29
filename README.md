# How-to-programatically-select-items-in-winforms-MultiSelectionComboBox
We can programmatically choose an item using the selected item property. For more details please refer [How to programatically select items in MultiSelectionComboBox](https://www.syncfusion.com/kb/11708/how-to-select-the-item-programmatically-in-winforms-multiselectioncombobox)

# C#
    public Form1()
            {
                InitializeComponent();
                multiSelectionComboBox1.ShowCheckBox = true;
                multiSelectionComboBox1.DataSource = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

                //Set the select item in MultiSelectionComboBox
                multiSelectionComboBox1.SelectedItem = multiSelectionComboBox1.Items[4];
            }
