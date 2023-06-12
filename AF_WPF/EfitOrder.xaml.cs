using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для EfitOrder.xaml
    /// </summary>
    public partial class EfitOrder : Window
    {
        public DB.Order Order { get; set; }
        public EfitOrder(DB.Order order)
        {
            InitializeComponent();
            Order = order;
            DataContext= this;
        }

        private void UpBut_Click(object sender, RoutedEventArgs e)
        {
            Orderslist.connect.SaveChanges();
            MessageBox.Show("Заказ обновлен.");
        }

        private void DelBut_Click(object sender, RoutedEventArgs e)
        {
            var op = Orderslist.connect.OrderProduct.Where(o => o.OrderID == Order.OrderID).FirstOrDefault();
            if (op == null)
            {
                Orderslist.Orders.Remove(Order);
                Orderslist.connect.Order.Remove(Order);
                Orderslist.connect.SaveChanges();
                MessageBox.Show("Заказ удален!");
                Close();
                return;
            } else
            {
                MessageBox.Show("Заказ не удален!");
            }
        }
    }
}
