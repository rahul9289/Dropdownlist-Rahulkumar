using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplicationAPI.Models;

namespace WebApplicationAPI.Controllers
{
    [RoutePrefix("elect")]
    public class ElectronicController : ApiController
    {
        [HttpGet]
        [Route("cls1")]
       public IHttpActionResult Get()
        {
            List<Company> data = new List<Company>
            {



                new Company() { Id = 1, Name = " Amit" },
                new Company() { Id = 2, Name = "Deepak" },
                new Company() { Id = 3, Name = "Ashok 2" },
                new Company() { Id = 2, Name = "Shayam 2" }


            };
            return Ok(data);

        }
        [HttpGet]
        [Route("cls2")]
        public IHttpActionResult Get2()
      {
        List<Class1> obj = new List<Class1>
            {



                new  Class1() { id = 1, name="Amit" ,Desgination="Lavel1",Department="Employwe"},
                new  Class1() { id = 2,  name="ramesh" ,Desgination="Lavel2",Department="HR"},
                new  Class1() { id = 3, name="deepak" ,Desgination="Lavel3",Department="Admin"},
                new  Class1() { id = 4,  name="akash" ,Desgination="Lavel4",Department="Complain"}


            };
            return Ok(obj);

        }



    }


}

    

