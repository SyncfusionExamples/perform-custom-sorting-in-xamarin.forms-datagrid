using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MyXamarinApp
{
    class OrderInfo : INotifyPropertyChanged
    {
        private int? orderID;
        private string customerID;
        private string customer;
        private string shipCity;
        private string shipCountry;
        private bool isChecked;

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(String Name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(Name));
        }
       
        public int? OrderID
        {
            get { return orderID; }
            set { this.orderID = value; RaisePropertyChanged("OrderID"); }
        }

        public string CustomerID
        {
            get { return customerID; }
            set { this.customerID = value; RaisePropertyChanged("CustomerID"); }
        }

        public string ShipCountry
        {
            get { return shipCountry; }
            set { this.shipCountry = value; RaisePropertyChanged("ShipCountry"); }
        }

        public string Customer
        {
            get { return this.customer; }
            set { this.customer = value; RaisePropertyChanged("Customer"); }
        }

        public string ShipCity
        {
            get { return shipCity; }
            set { this.shipCity = value; RaisePropertyChanged("ShipCity"); }
        }

        public bool IsChecked
        {
            get { return isChecked; }
            set { this.isChecked = value;RaisePropertyChanged("IsChecked"); }
        }
        public OrderInfo(int? orderId, string customerId, string country, string customer, string shipCity,bool isChecked)
        {
            this.OrderID = orderId;
            this.CustomerID = customerId;
            this.Customer = customer;
            this.ShipCountry = country;
            this.ShipCity = shipCity;
            this.IsChecked = isChecked;
        }
    }
}
