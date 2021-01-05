using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

using Dapper;
using Microsoft.AspNetCore.Mvc;

using System.Text;
using Nancy.Json;
using proj2.Models;
using System.ComponentModel.DataAnnotations;

namespace RoomBookingApiDemo.Controllers
{
    [Route("cabins")]
    [ApiController]
    public class CabinController : ControllerBase
    {
        [HttpGet("{email}")]
        public async Task<IActionResult> GetAsync(string email)
        {
            try
            {
                
                
                
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("https://projekt2new.azurewebsites.net/cabins");
                HttpContent content = response.Content;
                string jsonObject = await content.ReadAsStringAsync();
                List<Cabin> stugus = new List<Cabin>();
                JavaScriptSerializer js = new JavaScriptSerializer();
                List<Cabin> cabins = js.Deserialize<List<Cabin>>(jsonObject);
                for (int i = 0; i < cabins.Count; i++)
                {
                    if (email == cabins[i].owner)
                    {
                        stugus.Add(cabins[i]);
                    }
                }
                return StatusCode(200, stugus);



                //saöka s ervices och reservations
                /* SqlConnection sql = new SqlConnection("Server=tcp:asroomdbsrv.database.windows.net,1433;Initial Catalog=roombookingdb;Persist Security Info=False;User ID=albin;Password=Energiankulutus1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                 sql.Open();

                 IEnumerable<Room> rooms = sql.Query<Room>("SELECT * FROM Rooms");
                 sql.Close();
                */

            }
            catch (Exception e)
            {
                return StatusCode(401, e.Message);
            }
        }

/*        [Route("users/")]
        [HttpGet("{email}")]
        public async Task<IActionResult> getCabinAsync()
        {
            Uri myUri = new Uri("https://projekt2.azurewebsites.net/users");


            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(https://projekt2.azurewebsites.net/users);
            HttpContent content = response.Content;
            string jsonObject = await content.ReadAsStringAsync();
            
            JavaScriptSerializer js = new JavaScriptSerializer();
            var users = js.Deserialize<List<User>>(jsonObject);

            return StatusCode(401, "aaa");
        }*/

        [HttpPost]
        //sätt in seevices reservs
        public IActionResult Post([FromBody]Cabin room)
        {

            SqlConnection sql = new SqlConnection("Server=tcp:asroomdbsrv.database.windows.net,1433;Initial Catalog=roombookingdb;Persist Security Info=False;User ID=albin;Password=Energiankulutus1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            sql.Open();
            string Query = "INSERT INTO Rooms (name, seats, computers) values(@name, @seats, @computers)";
            sql.Query(Query, room);
            sql.Close();
            return StatusCode(201, room);

        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Cabin room)
        {
            SqlConnection sql = new SqlConnection("Server=tcp:asroomdbsrv.database.windows.net,1433;Initial Catalog=roombookingdb;Persist Security Info=False;User ID=albin;Password=Energiankulutus1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            sql.Open();
            string Query = "UPDATE Rooms set name = @name, seats = @seats, computers = @computers WHERE id ="+id;
            sql.Query(Query, room);
            sql.Close();
            return StatusCode(200);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            SqlConnection sql = new SqlConnection("Server=tcp:asroomdbsrv.database.windows.net,1433;Initial Catalog=roombookingdb;Persist Security Info=False;User ID=albin;Password=Energiankulutus1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            sql.Open();

            string Query = "DELETE FROM Rooms WHERE id=" + id;
            sql.Query(Query);
            sql.Close();
            return StatusCode(200);
        }
    }

}
