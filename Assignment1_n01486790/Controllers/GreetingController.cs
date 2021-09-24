using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01486790.Controllers
{
    public class GreetingController : ApiController
    {

        /// <summary>
        /// Sends a greeting to the entire world.
        /// <example> POST api/Greeting -> "Hello World!" </example> 
        /// </summary>
        /// <returns> The message "Hello World!". </returns>

        // POST api/Greeting
        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// Greets a designated number of people.
        /// <example> GET api/Greeting/36 -> "Greetings to 36 People!" </example> 
        /// </summary>
        /// <param name="id"> The Number of People to Greet </param>
        /// <returns> A greeting message for the number of people designated by the id. </returns>

        // GET api/Greeting/{id} 
        public string Get(int id)
        {
            return "Greetings to " + id.ToString() + " people!";
        }

    }
}

