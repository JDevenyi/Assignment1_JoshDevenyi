using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01486790.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Takes the input number and applies four mathemical oppertations that are unknown to the user. 
        /// <example> GET api/NumberMachine/22 -> 385 </example> 
        /// </summary>
        /// <param name="id"> The Input Number </param>
        /// <returns> A mysterious new number whose calculation is unknown to the user. </returns>

        // GET api/NumberMachine/{id} 
        public int Get(int id)
        {
            int diffNumber = id * 36 / 2 + 3 - 14;
            return diffNumber;
        }

    }
}
