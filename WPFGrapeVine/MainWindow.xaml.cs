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
using WPFClassLibrary;

namespace WPFGrapeVine
{
      /// <summary>
      /// Interaction logic for MainWindow.xaml
      /// </summary>
      public partial class MainWindow : Window
      {
            APIClient apiClient;
            List<TourEvents> tourevents;

            public MainWindow()
            {
                  InitializeComponent();
                  DataContext = this;
            }

            private async void Window_Loaded(object sender, RoutedEventArgs e)
            {
                  apiClient = new APIClient();

                  // get all users in DB
                  tourevents = await apiClient.GetTourEvents();

                  var toureventsdata = from eventtour in tourevents                                      
                                    select eventtour;

                  // set listbox item source to student as could not get XAML binding to work...
                  toureventlistbox.ItemsSource = toureventsdata;
            }

            private void Button_Click(object sender, RoutedEventArgs e)
            {
                  Bookings bookings = new Bookings((TourEvents)(toureventlistbox.SelectedItem));
                  this.Hide();
                  bookings.Show();

                  //all the data for visibility <Run Text="{Binding EventDate}"></Run>  
                       // < Run Text = "{Binding Eventfee}" ></ Run >


            }
      }
}
