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

namespace WPFGrapeVine
{
      /// <summary>
      /// Interaction logic for MainWindow.xaml
      /// </summary>
      public partial class MainWindow : Window
      {
            APIClient apiClient;
            

            public MainWindow()
            {
                  InitializeComponent();
                  DataContext = this;
            }

            private void Window_Loaded(object sender, RoutedEventArgs e)
            {
                  apiClient = new APIClient();

                  // get all users in DB
                  users = await apiClient.GetUsers();

                  // select only students
                  var students = from user in users
                                 where user.UserRole == "Student"
                                 select user;

                  // set listbox item source to student as could not get XAML binding to work...
                  studentsLbx.ItemsSource = students;
            }
      }
}
