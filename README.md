# How to Programmatically Select Items in WinForms MultiSelectionComboBox
The MultiSelectionComboBox control from Syncfusion allows users to select multiple items from a dropdown list. In many scenarios, you may need to pre-select items based on application logic, user preferences, or saved data. This guide demonstrates how to programmatically select items in the MultiSelectionComboBox.

## Why This Is Useful
- Initialize with Defaults: Pre-select items when the form loads.
- Dynamic Updates: Change selections based on user actions or external data.
- Improved UX: Provide a personalized experience in dashboards or forms.

## Key Implementation Steps
- Initialize the MultiSelectionComboBox with a data source.
- Access the SelectedItem property.
- Assign the desired item(s) to SelectedItem.
- Optionally, update the UI or trigger events based on the selection.

## Example: Programmatically Select an Item
**C#**
```C#
public Form1()
{
    InitializeComponent();

    // Enable checkboxes for multiple selection
    multiSelectionComboBox1.ShowCheckBox = true;

    // Bind data source
    multiSelectionComboBox1.DataSource = new List<string>()
    {
        "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
    };

    // Programmatically select an item (e.g., Friday)
    multiSelectionComboBox1.SelectedItem = multiSelectionComboBox1.Items[4];
}
```

## Notes
- The SelectedItem property sets a single item. For multiple selections, use SelectedItems or iterate through the collection.
- Ensure the data source is initialized before setting the selection.

## Reference
For more details, refer to the official Syncfusion Knowledge Base: https://www.syncfusion.com/kb/11708/how-to-select-the-item-programmatically-in-winforms-multiselectioncombobox
