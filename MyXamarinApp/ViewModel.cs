using System.Collections.ObjectModel;

namespace MyXamarinApp
{
    class ViewModel
    {
        public ObservableCollection<OrderInfo> OrderInfoCollection { get; set; }

        public ViewModel ()
        {
            OrderInfoCollection = new ObservableCollection<OrderInfo> ();
            GenerateOrders ();
        }

        private void GenerateOrders ()
        {
            OrderInfoCollection.Add(new OrderInfo(1001, "Maria Anders", "Mexico", "ANATR", "Mexico D.F.",true));
            OrderInfoCollection.Add(new OrderInfo(1002, "Ana Trujillo", "Mexico", "ANTON", "Mexico D.F.", true));
            OrderInfoCollection.Add(new OrderInfo(1003, "Ant Fuller", "UK", "AROUT", "London", true));
            OrderInfoCollection.Add(new OrderInfo(1004, "Thomas Hardy", "Sweden", "BERGS", "Berlin", true));
            OrderInfoCollection.Add(new OrderInfo(1005, "Lenny Lin", "Germany", "BLAUS", "Mannheim", true));
            OrderInfoCollection.Add(new OrderInfo(1006, "John Carter", "France", "BLONP", "Strasbourg", true));
            OrderInfoCollection.Add(new OrderInfo(1007, "Laura King", "Spain", "BOLID", "Madrid", true));
            OrderInfoCollection.Add(new OrderInfo(1008, "Hanna Moos", "France", "BONAP", "Marseille", false));
            OrderInfoCollection.Add(new OrderInfo(1009, "Lenny Lin", "Canada", "BOTTM", "Tsawassen", false));
            OrderInfoCollection.Add(new OrderInfo(1010, "Hanna Moos", "UK", "AROUT", "London", false));
            OrderInfoCollection.Add(new OrderInfo(1011, "John Carter", "Germany", "BLAUS", "Mannheim", false));
            OrderInfoCollection.Add(new OrderInfo(1012, "Tim Adams", "France", "BLONP", "Strasbourg", true));
            OrderInfoCollection.Add(new OrderInfo(1013, "Hanna Moos", "UK", "AROUT", "London", false));
            OrderInfoCollection.Add(new OrderInfo(1014, "John Carter", "Germany", "ALFKI", "Berlin", true));
            OrderInfoCollection.Add(new OrderInfo(1015, "Hanna Moos", "Mexico", "ANATR", "Mexico D.F.", false));
            OrderInfoCollection.Add(new OrderInfo(1016, "Laura King", "Mexico", "ANTON", "Mexico D.F.", false));
            OrderInfoCollection.Add(new OrderInfo(1017, "Len Lin", "UK", "AROUT", "London", false));
            OrderInfoCollection.Add(new OrderInfo(1018, "Thomas Hardy", "Sweden", "BERGS", "Berlin", true));
            OrderInfoCollection.Add(new OrderInfo(1019, "Lenny Lin", "Germany", "BLAUS", "Mannheim", true));
            OrderInfoCollection.Add(new OrderInfo(1020, "Gina Irene", "France", "BLONP", "Strasbourg", true));
            OrderInfoCollection.Add(new OrderInfo(1021, "Laura King", "Spain", "BOLID", "Madrid", false));
            OrderInfoCollection.Add(new OrderInfo(1022, "Anne Wilson", "France", "BONAP", "Marseille", true));
            OrderInfoCollection.Add(new OrderInfo(1023, "Lenny Lin", "Canada", "BOTTM", "Tsawassen", false));
            OrderInfoCollection.Add(new OrderInfo(1024, "Gina Irene", "UK", "AROUT", "London", true));
            OrderInfoCollection.Add(new OrderInfo(1025, "Thomas Hardy", "Germany", "BLAUS", "Mannheim", true));
            OrderInfoCollection.Add(new OrderInfo(1026, "Anne Wilson", "France", "BLONP", "Strasbourg", false));
            OrderInfoCollection.Add(new OrderInfo(1027, "Laura King", "UK", "AROUT", "London", true));
            OrderInfoCollection.Add(new OrderInfo(1028, "Anne Wilson", "France", "BLONP", "Strasbourg", true));
            OrderInfoCollection.Add(new OrderInfo(1029, "Gina Irene", "UK", "AROUT", "London", false));
            OrderInfoCollection.Add(new OrderInfo(1030, "Anne Wilson", "Germany", "ALFKI", "Berlin", false));
            OrderInfoCollection.Add(new OrderInfo(1031, "Tim Adams", "Mexico", "ANATR", "Mexico D.F.", true));
            OrderInfoCollection.Add(new OrderInfo(1032, "Hnne Wils", "Mexico", "ANTON", "Mexico D.F.", true));
            OrderInfoCollection.Add(new OrderInfo(1033, "Gina Irene", "UK", "AROUT", "London", false));
            OrderInfoCollection.Add(new OrderInfo(1034, "Ant Fuller", "Sweden", "BERGS", "Berlin", true));
            OrderInfoCollection.Add(new OrderInfo(1035, "Thomas Hardy", "Germany", "BLAUS", "Mannheim", false));
            OrderInfoCollection.Add(new OrderInfo(1036, "Gina Irene", "France", "BLONP", "Strasbourg", true));
            OrderInfoCollection.Add(new OrderInfo(1037, "Hanna Moos", "Spain", "BOLID", "Madrid", false));
            OrderInfoCollection.Add(new OrderInfo(1038, "Anne Wilson", "France", "BONAP", "Marseille", false));
            OrderInfoCollection.Add(new OrderInfo(1039, "Thomas Hardy", "Canada", "BOTTM", "Tsawassen", true));
            OrderInfoCollection.Add(new OrderInfo(1040, "Tim Adams", "UK", "AROUT", "London", true));
            OrderInfoCollection.Add(new OrderInfo(1041, "Anne Wilson", "Germany", "BLAUS", "Mannheim", true));
            OrderInfoCollection.Add(new OrderInfo(1042, "Thomas Wel", "France", "BLONP", "Strasbourg", false));
            OrderInfoCollection.Add(new OrderInfo(1043, "Han Moos", "UK", "AROUT", "London", true));
            OrderInfoCollection.Add(new OrderInfo(1044, "John Wick", "Germany", "ALFKI", "Berlin", false));
        }
    }
}
