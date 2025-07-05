using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplicationAPI.Models;

namespace WebApplicationAPI.Controllers
{
    public class UserController : ApiController
    {

        public IHttpActionResult Get()
        {
            List<NewEmploye> data = new List<NewEmploye>
            {



                new NewEmploye() { Id = 1, Name = " Amit" },
                new NewEmploye() { Id = 2, Name = "Deepak" },
                new NewEmploye() { Id = 3, Name = "Ashok 2" },
                new NewEmploye() { Id = 2, Name = "Shayam 2" }


            };

            return Ok(data);


        }




    }
}
