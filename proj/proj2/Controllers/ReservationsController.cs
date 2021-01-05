using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proj2.Models;
using System.Data.SqlClient;
using Dapper;
using System.Net.Http;
namespace proj2.Controllers
{
    [Route("reservations")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        [HttpGet("{email}")]

        public IActionResult Get(string email)
        {
            SqlConnection sql = new SqlConnection("Server=tcp:asroomdbsrv.database.windows.net,1433;Initial Catalog=project2;Persist Security Info=False;User ID=albin;Password=Energiankulutus1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            sql.Open();

            IEnumerable<Reservation> reservations = sql.Query<Reservation>("SELECT * FROM reservations WHERE booker = "+"'"+email+"'");
            sql.Close();
            return StatusCode(200, reservations);

        }

        [HttpPost]

        public IActionResult Post([FromBody] Reservation reservation)
        {
            try
            {
                SqlConnection sql = new SqlConnection("Server=tcp:asroomdbsrv.database.windows.net,1433;Initial Catalog=project2;Persist Security Info=False;User ID=albin;Password=Energiankulutus1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                sql.Open();
                string Query = "INSERT INTO reservations (serviceType, cabin, datum, booker) values(@serviceType, @cabin, @datum, @booker)";
                sql.Query(Query, reservation);
                sql.Close();
                return StatusCode(201, reservation);
            }catch(Exception b)
            {
                return StatusCode(400);
            }

        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Reservation reservation)
        {
            SqlConnection sql = new SqlConnection("Server=tcp:asroomdbsrv.database.windows.net,1433;Initial Catalog=project2;Persist Security Info=False;User ID=albin;Password=Energiankulutus1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            sql.Open();
            string Query = "UPDATE reservations set serviceType = @serviceType, cabin = @cabin, datum = @datum WHERE id =" + id;
            sql.Query(Query, reservation);
            sql.Close();
            return StatusCode(200, reservation);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            SqlConnection sql = new SqlConnection("Server=tcp:asroomdbsrv.database.windows.net,1433;Initial Catalog=project2;Persist Security Info=False;User ID=albin;Password=Energiankulutus1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            sql.Open();

            string Query = "DELETE FROM reservations WHERE id=" + id;
            sql.Query(Query);
            sql.Close();
            return StatusCode(200, "reservation deleted");
        }

    }
}
