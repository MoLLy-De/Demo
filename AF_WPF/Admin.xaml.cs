using AF_WPF.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; //ObservableCollection колекция для списков
using System.ComponentModel;//ObservableCollection колекция для списков
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
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public static yvelirkaEntities connect = new yvelirkaEntities();
        public static ObservableCollection<DB.Product> Products { get; set; }
        public static ObservableCollection<DB.Provider> Providers { get; set; }
        private EditProduct editproduct;
        public Admin(string user)
        {
            InitializeComponent();
            Products = new ObservableCollection<DB.Product>(connect.Product.ToList());
            Providers = new ObservableCollection<DB.Provider>(connect.Provider.ToList());
            DataContext= this;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (editproduct != null) return;

            var selectedproduct = ListProduct.SelectedItem as Product;
            editproduct = new EditProduct(selectedproduct);
            editproduct.Closed += Editproduct_Closed;
            editproduct.Show();
        }

        private void Editproduct_Closed(object sender, EventArgs e)
        {
            editproduct = null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CreateProduct create = new CreateProduct();
            create.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Orderslist orderslist = new Orderslist();
            orderslist.Show();
        }
    }
}
