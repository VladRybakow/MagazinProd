using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MagazinProd.DB;
using MagazinProd.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MagazinProd
{
    public partial class MainWindow : Window
    {
        public static MagazinEntities DB = new MagazinEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTNAuth(object sender, RoutedEventArgs e)
        {
            foreach(var user in DB.Users)
            {
                if (TBLogin.Text == user.Login)
                {
                    if (TBPass.Text == user.Password && user.Id_role == 1)
                    {
                        MessageBox.Show("Добро пожаловать!");
                        ClientWindow CW = new ClientWindow();
                        CW.Show();
                        this.Close();
                    }
                    if (TBPass.Text == user.Password && user.Id_role == 2)
                    {
                        MessageBox.Show("Добро пожаловать!");
                        AdminWindow AW = new AdminWindow();
                        AW.Show();
                        this.Close();
                    }
                    if (TBPass.Text == user.Password && user.Id_role == 3)
                    {
                        MessageBox.Show("Добро пожаловать!");
                        MasterWindow MW = new MasterWindow();
                        MW.Show();
                        this.Close();
                    }
                    if (TBPass.Text == user.Password && user.Id_role == 4)
                    {
                        MessageBox.Show("Добро пожаловать!");
                        SkladWindow Sklad = new SkladWindow();
                        Sklad.Show();
                        this.Close();
                    }
                }
            }
        }
    }
}
