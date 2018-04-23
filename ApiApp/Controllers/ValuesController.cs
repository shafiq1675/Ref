using ApiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;

namespace ApiApp.Controllers
{
    public class StudentController : ApiController
    {
        // GET myApi/values
        public IEnumerable<Student> Get()
        {
            List<Student> li=new List<Student>();
            Student aList=new Student ();
            Student aList2=new Student ();

            aList.ID="1";
            aList.Name="Khan";
            aList.Address="Dhaka";

            aList2.ID = "2";
            aList2.Name = "Shafiq";
            aList2.Address = "Dhaka";

            li.Add(aList);
            li.Add(aList2);

            return li;
           
        }

        // GET myApi/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST myApi/values
        public void Post([FromBody]string value)
        {
        }

        // PUT myApi/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE myApi/values/5
        public void Delete(int id)
        {
        }
    }
}