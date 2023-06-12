using AF_WPF.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Логика взаимодействия для Klient.xaml
    /// </summary>
    public partial class Klient : Window
    {
        public static yvelirkaEntities connect = new yvelirkaEntities();
        public static bool orderyes = false;
        private bool prodyes = false;
        public static ObservableCollection<DB.Product> Products { get; set; }
        public static ObservableCollection<DB.Provider> Providers { get; set; }
        public static ObservableCollection<DB.OrderProduct> OrderProducts { get; set; }

        private DB.Order NewOrder = new DB.Order();
        private DB.OrderProduct product = new DB.OrderProduct();
        public DB.Product Product { get; set; }
        public Klient(string user)
        {
            InitializeComponent();
            Products = new ObservableCollection<DB.Product>(connect.Product.ToList());
            Providers = new ObservableCollection<DB.Provider>(connect.Provider.ToList());
            OrderProducts = new ObservableCollection<DB.OrderProduct>();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           OrderProduct orderProduct = new OrderProduct(NewOrder, product);
           orderProduct.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if(orderyes == false) {

                DB.Order o = connect.Order.ToList().Last();
                NewOrder.OrderID = o.OrderID + 1;
                NewOrder.OrderDate = DateTime.Now;
                NewOrder.OrderStatus = "Новый";
                NewOrder.OrderDeliveryDate = o.OrderDeliveryDate;
                NewOrder.OrderPickupPoint = o.OrderPickupPoint;
                NewOrder.OrderCode = o.OrderCode + 1;
                orderyes = true;
            }

            DB.Product p = ListProduct.SelectedItem as DB.Product;
            product.OrderID = NewOrder.OrderID;
            product.ProductArticleNumber = p.ProductArticleNumber;
            product.OrderProductCount = 1;
            AddProd.Visibility= Visibility.Visible;

            foreach (var op in connect.OrderProduct.ToList())
            {
                if(op.OrderID == product.OrderID && op.ProductArticleNumber == product.ProductArticleNumber)
                {
                    product.OrderProductCount++;
                    prodyes = true;
                } 
            }
            if(prodyes == false) { OrderProducts.Add(product); }
            MessageBox.Show("Продукт добавлен в заказ!");

        }
    }
}
