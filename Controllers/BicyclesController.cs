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

        // GET: api/bicycles/free and api/bicycles/isRenting
        [HttpGet("{status}")]
        public async Task<ActionResult<IEnumerable<Bicycle>>> Get(string status)
        {
            if (status == "free")
            {
                return await db.Bicycles.Where(bike => bike.Status == "free").ToListAsync();
            }
            else if (status == "isRenting")
            {
                return await db.Bicycles.Where(bike => bike.Status == "isRenting").ToListAsync();
            }
            else
            {
                return BadRequest();
            }
        }

        //POST: - api/bicycles
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
