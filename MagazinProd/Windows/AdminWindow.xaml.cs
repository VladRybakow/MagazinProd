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
using System.Windows.Shapes;

namespace MagazinProd.Windows
{
    public partial class AdminWindow : Window
    {
        public static MagazinEntities DB = new MagazinEntities();
        public AdminWindow()
        {
            InitializeComponent();

            LVTel.ItemsSource = DB.Telephones.ToList();
            LVCl.ItemsSource = DB.Client.ToList();
        }

        private void AddClient(object sender, RoutedEventArgs e)
        {
            if (TBName.Text == "")
            {
                MessageBox.Show("Введите ваши данные!");
            }
            else
            {
                Client client = new Client();
                client.Name = TBName.Text;
                client.NumberTelephone = TBNum.Text;

                DB.Client.Add(client);
                try
                {
                    DB.SaveChanges();

                }
                catch
                {
                    MessageBox.Show("Такие данные уже существует!");
                }
                finally
                {
                    MessageBox.Show("Сохранено");
                    TBName.Text = "";
                    TBNum.Text = "";
                }
            }
        }
    }
}
