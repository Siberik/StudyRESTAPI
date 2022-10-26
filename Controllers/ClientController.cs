using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        TestDBContext context = new TestDBContext();
        //GET api/ClientController
        [HttpGet]
        public IEnumerable<Client> GetClients()
        {
            return context.Client.ToList();
        }

       
    }
}
