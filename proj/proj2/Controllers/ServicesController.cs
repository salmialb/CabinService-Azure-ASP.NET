
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
    [Route("services")]
    [ApiController]
    public class ServicesController : ControllerBase
    {



        [HttpGet]

        public IActionResult Get()
        {
            SqlConnection sql = new SqlConnection("Server=tcp:asroomdbsrv.database.windows.net,1433;Initial Catalog=project2;Persist Security Info=False;User ID=albin;Password=Energiankulutus1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            sql.Open();

            IEnumerable<Service> services = sql.Query<Service>("SELECT * FROM services");
            sql.Close();
            return StatusCode(200, services);

        }


        [HttpPost]

        public IActionResult Post([FromBody] Service service)
        {

            SqlConnection sql = new SqlConnection("Server=tcp:asroomdbsrv.database.windows.net,1433;Initial Catalog=project2;Persist Security Info=False;User ID=albin;Password=Energiankulutus1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            sql.Open();
            string Query = "INSERT INTO services (id, serviceType) values(@ID, @serviceType)";
            sql.Query(Query, service);
            sql.Close();
            return StatusCode(201, service);

        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Service service)
        {
            SqlConnection sql = new SqlConnection("Server=tcp:asroomdbsrv.database.windows.net,1433;Initial Catalog=project2;Persist Security Info=False;User ID=albin;Password=Energiankulutus1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            sql.Open();
            string Query = "UPDATE Services set serviceType = @ServiceType WHERE id =" + id;
            sql.Query(Query, service);
            sql.Close();
            return StatusCode(200, "Service edited" + service);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            SqlConnection sql = new SqlConnection("Server=tcp:asroomdbsrv.database.windows.net,1433;Initial Catalog=project2;Persist Security Info=False;User ID=albin;Password=Energiankulutus1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            sql.Open();

            string Query = "DELETE FROM Services WHERE id=" + id;
            sql.Query(Query);
            sql.Close();
            return StatusCode(200, "Service deleted");
        }
    }
}
