using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webSqlData.Models;

namespace webSqlData.Controllers
{
    public class StudentDataController : ApiController
    {

        string cs = ConfigurationManager.ConnectionStrings["Studentconn"].ToString();

        public IHttpActionResult StudentGet()
        {
            List<studentData> StudentList = new List<studentData>();
                SqlConnection connection = new SqlConnection(cs);
           
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM studentData", conn);
                    conn.Open();

               
                   SqlDataReader reader = command.ExecuteReader();
                   while (reader.Read())
                {
                    studentData.Add(new studentData
                    {
                        id = (int)reader["id"],
                        name = reader["Name"].ToString(),
                        Address = reader["Address"].ToString(),
                       age = (int)reader["age"],
                    });
                }
            }
            return Ok(StudentList);
        }






    }



}


        

