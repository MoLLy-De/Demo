using AF_WPF.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; //ObservableCollection колекция для списков
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AF_WPF
{
    /// <summary>
    /// Логика взаимодействия для Orderslist.xaml
    /// </summary>
    public partial class Orderslist : Window
    {
        public static yvelirkaEntities connect = new yvelirkaEntities();
        public static ObservableCollection<DB.Order> Orders { get; set; }
        private EfitOrder editorder;
        public Orderslist()
        {
            InitializeComponent();
            Orders = new ObservableCollection<DB.Order>(connect.Order.ToList());
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CreateOrder create = new CreateOrder();
            create.Show();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (editorder != null) return;
            var selectetorder = OrderList.SelectedItem as DB.Order;
            editorder = new EfitOrder(selectetorder);
            editorder.Closed += Editorder_Closed;
            editorder.Show();
        }

        private void Editorder_Closed(object sender, EventArgs e)
        {
            editorder= null;
        }
    }
}
