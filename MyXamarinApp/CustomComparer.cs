using Syncfusion.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyXamarinApp
{
    class CustomComparer : IComparer<object>, ISortDirection
    {
        public ListSortDirection SortDirection { get;set; }

        public int Compare(object x, object y)
        {
            int valueX;
            int valueY;

            if(x.GetType() == typeof(OrderInfo))
            {
                valueX = ((OrderInfo)x).ShipCountry.Length;
                valueY = ((OrderInfo)y).ShipCountry.Length;
            }
            else
            {
                valueX = x.ToString().Length;
                valueY = y.ToString().Length;
            }

            if(valueX.CompareTo(valueY) >0)
            {
                return SortDirection == ListSortDirection.Ascending ? 1:-1;
            }
            else if(valueX.CompareTo(valueY) ==-1)
            {
                return SortDirection == ListSortDirection.Ascending ? -1:1;
            }
            else return 0;
        }
    }
}
