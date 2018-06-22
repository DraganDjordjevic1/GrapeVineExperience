using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFClassLibrary
{
      public class Bookings
      {

            private string tourname;
            private double payment;
            private DateTime eventdate;
            private DateTime datebooked;
            private int clientid;

            public string Tourname
            {
                  get { return tourname; }
                  set { tourname = value; }
            }

            public double Payment
            {
                  get { return payment; }
                  set { payment = value; }
            }

            public DateTime EventDate
            {
                  get { return eventdate; }
                  set { eventdate = value; }
            }

            public int ClientID
            {
                  get { return clientid; }
                  set { clientid = value; }
            }

            public DateTime Datebooked
            {
                  get { return datebooked; }
                  set { datebooked = value; }
            }
      }
}
