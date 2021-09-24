using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01486790.Controllers
{
    public class HostingCostController : ApiController
    {

        /// <summary>
        /// Calculates the cost of web hosting per the amount of elapsed fortnights 
        /// <example> GET api/NumberMachine/28 -> 3 fortnights at $5.50/FN = $16.50 CAD
        ///                                       HST 13% = $2.14 CAD
        ///                                       Total = $18.64 CAD                                
        ///</example> 
        /// </summary>
        /// <param name="id"> The number of days web hosting has been in use </param>
        /// <returns> The initial cost before tax, the HST cost, and the total cost of the service. </returns>

        // GET api/HostingCost/{id} 
        public IEnumerable<string> Get(int id) 
        {

            int fortnights = id / 14 + 1;
            decimal initialCost;
            decimal HST;
            decimal totalCost;


            initialCost = Math.Round(fortnights * 5.50M, 2); 
            HST = Math.Round(initialCost * .13M, 2); 
            totalCost = Math.Round(initialCost + HST, 2);

            return new string[] { fortnights.ToString() + " fortnights at $5.50/FN = $" + initialCost.ToString() + " CAD", "HST 13% = $" + HST.ToString() + " CAD", "Total = $" + totalCost.ToString() + " CAD" };

        }

    }
}
