using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeRent_Back_End.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BikeRent_Back_End.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("AllowAllOrigin")]
    public class BicyclesController : ControllerBase
    {
        BicyclesContext db;
        public BicyclesController(BicyclesContext context)
        {
            db = context;
        }

        // GET api/bicycles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bicycle>>> Get()
        {
            return await db.Bicycles.ToListAsync();
        }

        //POST - api/bicycles - saveBicycleToDb(bicycle: Bicycle) method on the client
        [HttpPost]
        public IActionResult Post(Bicycle bike)
        {
            if (bike == null)
            {
                return BadRequest();
            }

            db.Bicycles.Add(bike);
            db.SaveChanges();
            return Ok(bike);
        }
    }
}
