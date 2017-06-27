using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkHours.Data;
using WorkHours.Data.Models;
using WorkHours.Data.Repositories;

namespace WorkHours.Api.Controllers
{
    [Route("api/[controller]")]
    public class ShiftsController : Controller
    {
        private ShiftsRepository _repo;

        public ShiftsController()
        {
            // todo: change with DI
            _repo = new ShiftsRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Json(_repo.GetAllShifts());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Shift shift)
        {
            _repo.AddShift(shift);
            return Ok();
        }

    }
}
