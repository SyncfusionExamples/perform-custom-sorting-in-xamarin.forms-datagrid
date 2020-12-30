using Syncfusion.Data;
using Syncfusion.SfDataGrid.XForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyXamarinApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //dataGrid.AllowSorting = true;
            //dataGrid.SortComparers.Add( new SortComparer()
            //{
            //    PropertyName = "ShipCountry",
            //    Comparer = new CustomComparer()
            //});
        }
    }
}
