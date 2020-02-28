# How to enable the MultiSelection in GridComboBoxColumn of DataGrid SfDataGrid 

## About the sample
This example illustrates how to enable the MultiSelection in GridComboBoxColumn of DataGrid SfDataGrid

By default, we can select one item from GridComboBoxColumn in SfDataGrid. If you want to select multiple item, this can be achieved by overriding the [OnInitializeEditView](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfDataGrid.XForms~Syncfusion.SfDataGrid.XForms.GridCellComboBoxRenderer~OnInitializeEditView.html) and set SfComboBox.MultiSelectMode as Delimiter in [GridComboBoxCellRenderer](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms~Syncfusion.SfDataGrid.XForms.GridCellComboBoxRenderer~OnInitializeEditView.html).

```c#
this.dataGrid.CellRenderers.Remove("ComboBox");
this.dataGrid.CellRenderers.Add("ComboBox", new CustomComboBoxRenderer());

public class CustomComboBoxRenderer : GridCellComboBoxRenderer
{
    public override void OnInitializeEditView(DataColumnBase dataColumn, GridComboBox view)
    {
        view.Text = null;
        view.SelectedIndices = null;
        base.OnInitializeEditView(dataColumn, view);
        view.MultiSelectMode = Syncfusion.XForms.ComboBox.MultiSelectMode.Delimiter;
    }

    public override object GetControlValue()
    {
        return CurrentCellRendererElement.GetValue(SfComboBox.TextProperty);
    }
}
```

## Requirements to run the demo
Visual Studio 2015 and above versions
