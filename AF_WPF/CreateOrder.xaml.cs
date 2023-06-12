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
    /// Логика взаимодействия для CreateOrder.xaml
    /// </summary>
    public partial class CreateOrder : Window
    {
        public DB.Order NewOrder { get; set; }
        public CreateOrder()
        {
            InitializeComponent();
            NewOrder= new DB.Order();
            DataContext = this;
        }

        private void UpBut_Click(object sender, RoutedEventArgs e)
        {
            Orderslist.connect.Order.Add(NewOrder);
            int result = Orderslist.connect.SaveChanges();

            if (result != 0)
            {
                Orderslist.Orders.Add(NewOrder);
                NewOrder = new DB.Order();

                ProductPanel.GetBindingExpression(DataContextProperty).UpdateTarget();

                MessageBox.Show("Заказ создан!");
            }

        }
    }
}
