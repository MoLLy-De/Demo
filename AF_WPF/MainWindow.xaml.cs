using AF_WPF.DB;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AF_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static yvelirkaEntities connect = new yvelirkaEntities();
        public MainWindow()
        {
            InitializeComponent();

#if DEBUG
            LoginText.Text = "5lfozwx7erq2@outlook.com";
            PasText.Text = "JlFRCZ";
#endif
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string log = LoginText.Text;
            string pas = PasText.Text;

            DB.User user = (DB.User)connect.User.Where(u => u.UserLogin == log && u.UserPassword == pas).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Данные введены не верно!");
            }
            else
            {
                if (user.UserRole == 1)
                {
                    Admin admin = new Admin(user.UserSurname + " " + user.UserName + " " + user.UserPatronymic);
                    admin.Show();
                    this.Close();
                } else if (user.UserRole == 2)
                {
                    Meneger meneger = new Meneger(user.UserSurname + " " + user.UserName + " " + user.UserPatronymic);
                    meneger.Show();
                    this.Close();
                } else if (user.UserRole == 3)
                {
                    Klient meneger = new Klient(user.UserSurname + " " + user.UserName + " " + user.UserPatronymic);
                    meneger.Show();
                    this.Close();
                }
            }
        }
    }
}
