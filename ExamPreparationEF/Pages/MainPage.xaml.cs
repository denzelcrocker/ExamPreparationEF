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

namespace ExamPreparationEF.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        
        public MainPage()
        {
            InitializeComponent();
            childrens = db.Childrens.ToList();
            AllChildrens.ItemsSource = childrens;
        }

        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            string path = Modules.OpenDialog();
            Modules.WriteChildrens(childrens, path);
        }

        private void AllChildrens_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var track = ((DataGrid)sender).SelectedItem as Children;
            if (track != null)
            {
                Manager.frame.Navigate(new EditPage(track));
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new AddPage());
        }
    }
}
