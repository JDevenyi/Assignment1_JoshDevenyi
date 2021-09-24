using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01486790.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Adds 10 to the input number.
        /// <example> GET api/AddTen/1 -> 11 </example> 
        /// </summary>
        /// <param name="id"> The Input Number </param>
        /// <returns> The input number plus ten. </returns>

        // GET api/AddTen/{id}
        public int Get(int id)
        {
            int biggerNum = id + 10;
            return biggerNum;
        }

    }
}
