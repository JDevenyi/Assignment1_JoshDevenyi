using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01486790.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Squares the input number.
        /// <example> GET api/Square/4 -> 16 </example> 
        /// </summary>
        /// <param name="id"> The Input Number </param>
        /// <returns> The input number multiplied by itself. </returns>

        // GET api/Square/{id}
        public int Get(int id)
        {
            int numSquared = id * id;
            return numSquared;
        }

    }
}
