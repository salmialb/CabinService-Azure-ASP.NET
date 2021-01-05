
using proj2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Tjänst
{
    class RestApi
    {
        public async Task<List<Cabin>> getCabins(string email)
        {
            //Skicka GET request till /cabins
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("https://proj220201002181550.azurewebsites.net/cabins/" + email);
                HttpContent content = response.Content;
                string jsonObject = await content.ReadAsStringAsync();
                Debug.WriteLine(jsonObject);
                JavaScriptSerializer js = new JavaScriptSerializer();

                return js.Deserialize<List<Cabin>>(jsonObject);
            }
            catch(Exception e)
            {
                Debug.WriteLine("Error här: "+e.Message);
                return null;
            }
        }
        public async Task<List<Service>> getServices()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://proj220201002181550.azurewebsites.net/services/");
            HttpContent content = response.Content;
            string jsonObject = await content.ReadAsStringAsync();
            Debug.WriteLine(jsonObject);
            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Deserialize<List<Service>>(jsonObject);
        }
        public async Task<List<Reservation>> getReservations(string email)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://proj220201002181550.azurewebsites.net/reservations/" + email);
            HttpContent content = response.Content;
            string jsonObject = await content.ReadAsStringAsync();
            Debug.WriteLine(jsonObject);
            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Deserialize<List<Reservation>>(jsonObject);
        }
        public async Task saveReservation(Reservation reservation)
        {
            try
            {
                HttpClient client = new HttpClient();
                JavaScriptSerializer js = new JavaScriptSerializer();
                string jsonObj = js.Serialize(reservation);
                StringContent body = new StringContent(jsonObj, Encoding.UTF8, "application/json");
                Debug.WriteLine(body.ToString());
                await client.PostAsync("https://proj220201002181550.azurewebsites.net/reservations", body);
            }catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }


        }

        public async Task modifyReservation(Reservation reservation, long id)
        {
            try
            {
                HttpClient client = new HttpClient();
                JavaScriptSerializer js = new JavaScriptSerializer();
                string jsonObj = js.Serialize(reservation);
                StringContent body = new StringContent(jsonObj, Encoding.UTF8, "application/json");
               
                Debug.WriteLine(body.ToString());
                await client.PutAsync("https://proj220201002181550.azurewebsites.net/reservations/" + id, body);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }


        }
        public async Task deleteReservation(long id)
        {
            try
            {
                HttpClient client = new HttpClient();
                Debug.WriteLine(id);
                await client.DeleteAsync("https://proj220201002181550.azurewebsites.net/reservations/" + id);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }


        }
        //client.deleteasync
        /* public async Task SaveRoom(Cabin cabin)
         {
             HttpClient client = new HttpClient();
             JavaScriptSerializer js = new JavaScriptSerializer();
             string jsonObj = js.Serialize(cabin);
             StringContent body = new StringContent(jsonObj, Encoding.UTF8, "application/json");

             await client.PostAsync("https://localhost:63379/rooms", body);


         }*/
    }
}


