using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FernandezA_MiniChallenge_1Again_Endpoint_.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public string SayHello(string name){
            return "Hello " + name +"!";
        }
    }
}