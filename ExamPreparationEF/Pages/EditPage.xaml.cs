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
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        Children thisChildren;

        public EditPage(Children childrenSelected)
        {
            InitializeComponent();
            Name.Text = childrenSelected.Name;
            Birthday.Text = childrenSelected.Birthday;
            Gender.Text = childrenSelected.Gender;
            thisChildren = childrenSelected;
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < childrens.Count; i++)
            {
                if (childrens[i].Id == thisChildren.Id)
                {
                    childrens[i].Name = Name.Text;
                    childrens[i].Birthday = Birthday.Text;
                    childrens[i].Gender = Gender.Text;
                    db.SaveChanges();
                    Manager.frame.Navigate(new MainPage());

                }
            }
            foreach (Children item in CurrentList.childrens)
            {
                if (item.Id == thisChildren.Id)
                {
                    item.Name = Name.Text;
                    item.Birthday = Birthday.Text;
                    item.Gender = Gender.Text;
                    db.SaveChanges();
                    Manager.frame.Navigate(new MainPage());
                }
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.GoBack();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            db.Childrens.Remove(thisChildren);
            db.SaveChanges();
            Manager.frame.Navigate(new MainPage());
        }
    }
}
