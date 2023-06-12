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
    /// Логика взаимодействия для CreateProduct.xaml
    /// </summary>
    public partial class CreateProduct : Window
    {
        public DB.Product NewProduct { get; set; } 
        public CreateProduct()
        {
            InitializeComponent();
            NewProduct = new DB.Product();
            
            DataContext = this;
        }

        private void UpBut_Click(object sender, RoutedEventArgs e)
        {
            Admin.connect.Product.Add(NewProduct);
            int result = Admin.connect.SaveChanges();

            if (result != 0)
            {
                Admin.Products.Add(NewProduct);
                NewProduct = new DB.Product();

                ProductPanel.GetBindingExpression(DataContextProperty).UpdateTarget();

                MessageBox.Show("Материал добавлен!");
            }
        }
    }
}
