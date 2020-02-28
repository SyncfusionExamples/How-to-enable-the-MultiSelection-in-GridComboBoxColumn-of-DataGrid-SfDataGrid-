using Syncfusion.SfDataGrid.XForms.DataPager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Syncfusion.SfDataGrid.XForms;
using Syncfusion.Data;
using System.Reflection;
using System.Globalization;
using System.IO;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections;
using Syncfusion.SfDataGrid.XForms.Renderers;
using Syncfusion.XForms.ComboBox;

namespace DataGridDemo
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public MainPage()
        {
            InitializeComponent();
            this.dataGrid.CellRenderers.Remove("ComboBox");
            this.dataGrid.CellRenderers.Add("ComboBox", new CustomComboBoxRenderer());
        }
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
    }
}
