using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WPFClassLibrary;

namespace WPFGrapeVine
{
      public class APIClient
      {
            HttpClient client;

            public async Task<List<TourEvents>> GetTourEvents()
            {
                  client = new HttpClient();

                  client.BaseAddress = new Uri("http://grapevinesexperience.azurewebsites.net/api/");

                  HttpResponseMessage response = await client.GetAsync("TourEvents");

                  var content = await response.Content.ReadAsStringAsync();

                  List<TourEvents> tourevents = JsonConvert.DeserializeObject<List<TourEvents>>(content);

                  return tourevents;
            }


            public async Task PostTourEvents(TourEvents ptourevents)
            {
                  client = new HttpClient();

                  client.BaseAddress = new Uri("http://grapevinesexperience.azurewebsites.net/api/");

                  // turn pUser into JSON
                  string toureventsJSON = JsonConvert.SerializeObject(ptourevents, Formatting.None);

                  // turn JSON into httpContent for PUT command
                  var httpContent = new StringContent(toureventsJSON, Encoding.UTF8, "application/json");

                  // run put command
                  var response = await client.PostAsync("TourEvents/" + ptourevents.Tourname, httpContent);
            }



            public async Task<List<Bookings>> GetBookings()
            {
                  client = new HttpClient();

                  client.BaseAddress = new Uri("http://digitalwallet2api.azurewebsites.net/api/");

                  HttpResponseMessage response = await client.GetAsync("Bookings");

                  var content = await response.Content.ReadAsStringAsync();

                  List<Bookings> bookings = JsonConvert.DeserializeObject<List<Bookings>>(content);

                  return bookings;
            }

            public async Task PostBookings(Bookings pbookings)
            {
                  client = new HttpClient();

                  client.BaseAddress = new Uri("http://grapevinesexperience.azurewebsites.net/api/");

                  // turn pUser into JSON
                  string bookingsJSON = JsonConvert.SerializeObject(pbookings, Formatting.None);

                  // turn JSON into httpContent for PUT command
                  var httpContent = new StringContent(bookingsJSON, Encoding.UTF8, "application/json");

                  // run put command
                  var response = await client.PostAsync("Bookings/" + pbookings.ClientID, httpContent);
            }

      }
}