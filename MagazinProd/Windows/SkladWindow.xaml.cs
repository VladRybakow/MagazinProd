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
    public partial class SkladWindow : Window
    {
        public static MagazinEntities DB = new MagazinEntities();
        public SkladWindow()
        {
            InitializeComponent();

            LVMat.ItemsSource = DB.Materials.ToList();
        }

        private void AddMat(object sender, RoutedEventArgs e)
        {
            if (TBName.Text == "")
            {
                MessageBox.Show("Введите ваши данные!");
            }
            else
            {
                Materials mat = new Materials();
                mat.Name = TBName.Text;
                mat.CountMat = TBNum.Text;

                DB.Materials.Add(mat);
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
