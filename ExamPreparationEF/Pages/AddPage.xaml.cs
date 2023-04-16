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
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        public AddPage()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new MainPage());
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            List<Children> childrens = new List<Children> { new Children() };
            childrens[0].Name = Name.Text;
            childrens[0].Birthday = Birthday.Text;
            childrens[0].Gender = Gender.Text;
            db.Childrens.Add(childrens[0]);
            db.SaveChanges();
            Manager.frame.Navigate(new MainPage());
        }
    }
}
