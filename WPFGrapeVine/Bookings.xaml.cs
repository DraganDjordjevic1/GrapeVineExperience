﻿using System;
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
using System.Windows.Shapes;
using WPFClassLibrary;

namespace WPFGrapeVine
{
      /// <summary>
      /// Interaction logic for Bookings.xaml
      /// </summary>
      public partial class Bookings : Window
      {
            
            TourEvents tourevents;
            

            public Bookings(TourEvents ptourevents)
            {
                  InitializeComponent();
                  tourevents = ptourevents;
                  DataContext = tourevents;
                 

            }
      }
}
