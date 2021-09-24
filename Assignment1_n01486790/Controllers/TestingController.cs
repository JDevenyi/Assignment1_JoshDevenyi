using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01486790.Controllers
{
    public class TestingController : ApiController
    {

        public double Get (int id)
        {
       
            return Math.Round(id * 3.5, 2);

        }



    }
}
