using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCodeCamp.Data;

namespace MyCodeCamp.Controllers
{
    [Route("api/[controller]")]
    public class CampsController : Controller
    {
        private readonly ICampRepository _repo;

        public CampsController(ICampRepository repo)
        {
            repo = _repo;
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok(_repo.GetAllCamps());
        }

    }
}
