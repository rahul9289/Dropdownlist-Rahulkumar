using System.Collections.Generic;
using System.Web.Mvc;
using WebApplicationAPI.Models;

namespace WebApplicationAPI.Controllers
{

    public class UserAPIController : Controller
    {
        // GET: UserAPI
        public List<NewEmploye> Get()
        {

            List<NewEmploye> data = new List<NewEmploye>
            {



                new NewEmploye() { Id = 1, Name = " Amit" }, 
                new NewEmploye() { Id = 2, Name = "Deepak" },
                new NewEmploye() { Id = 3, Name = "Ashok 2" },
                new NewEmploye() { Id = 2, Name = "Shayam 2" }


            };

            return (data);
        }


        public ActionResult GetUser()
        {
            return View();
        }

    }
}