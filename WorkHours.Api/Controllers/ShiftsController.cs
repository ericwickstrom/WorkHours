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
        private IShiftsRepository _repo;

        public ShiftsController(IShiftsRepository repo)
        {
            // todo: change with DI
            _repo = repo;
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
