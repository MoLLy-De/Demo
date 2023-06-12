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
    /// Логика взаимодействия для EditProduct.xaml
    /// </summary>
    public partial class EditProduct : Window
    {
        public DB.Product Product { get; set; }
        public EditProduct(DB.Product product)
        {
            Product = product;
            InitializeComponent();
            DataContext = this;
        }

        private void UpBut_Click(object sender, RoutedEventArgs e)
        {
            Admin.connect.SaveChanges();
            MessageBox.Show("Продукт обновлен!");
        }

        private void DelBut_Click(object sender, RoutedEventArgs e)
        {
            var op = Admin.connect.OrderProduct.Where(o=> o.ProductArticleNumber == Product.ProductArticleNumber).FirstOrDefault();
            if (op == null) 
            {
                Admin.Products.Remove(Product);
                Admin.connect.Product.Remove(Product);
                Admin.connect.SaveChanges();
                MessageBox.Show("Продукт удален!");
                Close();
                return;
            } else
            {
                MessageBox.Show("Продукт не удален!");
            }
        }
    }
}
