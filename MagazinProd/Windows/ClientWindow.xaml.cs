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
    public partial class ClientWindow : Window
    {
        public static MagazinEntities DB = new MagazinEntities();
        public ClientWindow()
        {
            InitializeComponent();
            CBT.ItemsSource = DB.TypeTelephones.ToList();
        }

        private void AddTel(object sender, RoutedEventArgs e)
        {
            if (TBName.Text == "")
            {
                MessageBox.Show("Введите ваши данные!");
            }
            else
            {
                Telephones tel = new Telephones();
                tel.Name = TBName.Text;

                var IdDC = CBT.SelectedItem;
                var Id = ((TypeTelephones)IdDC).Id_type;
                tel.Id_type = Id;

                tel.CountTel = TBNum.Text;

                DB.Telephones.Add(tel);
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
                    CBT.Text = "";
                    TBNum.Text = "";
                }
            }
        }
    }
}
