using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeRent_Back_End.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BikeRent_Back_End.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BicyclesController : ControllerBase
    {
        BicyclesContext db;
        public BicyclesController(BicyclesContext context)
        {
            db = context;
        }
    }
}
