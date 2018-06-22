using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFClassLibrary
{
    public class TourEvents
    {
            private string tourname;
            private double eventfee;
            private DateTime eventdate;

            public string Tourname
            {
                  get { return tourname; }
                  set { tourname = value; }
            }

            public double Eventfee
            {
                  get { return eventfee; }
                  set { eventfee = value; }
            }

            public DateTime EventDate
            {
                  get { return eventdate; }
                  set { eventdate = value; }
            }
      }
}
