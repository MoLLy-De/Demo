using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static System.Net.Mime.MediaTypeNames;

namespace AF_WPF
{
    /// <summary>
    /// Логика взаимодействия для OrderProduct.xaml
    /// </summary>
    public partial class OrderProduct : Window
    {
        public DB.OrderProduct Product { get; set; }
        public DB.Order Order { get; set; }

        public static ObservableCollection<DB.OrderProduct> OrderProducts { get; set; }
        public OrderProduct(DB.Order NewOrder, DB.OrderProduct product)
        {
            InitializeComponent();
            OrderProducts = Klient.OrderProducts;
            Product = product;
            Order= NewOrder;
            DataContext= this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Klient.connect.Order.Add(Order);
            Klient.connect.SaveChanges();
            Klient.connect.OrderProduct.Add(Product);
            Klient.connect.SaveChanges();
            Klient.OrderProducts.Clear();
            MessageBox.Show("Заказ оформлен!");
            Klient.orderyes = false;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((sender as TextBox).Text == "0") 
            {
                Klient.OrderProducts.Remove(Product); 
                Product = null;
            }
        }
    }
}
