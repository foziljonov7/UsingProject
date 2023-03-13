using UsingApiAppData.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace UsingApiApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KursController : ControllerBase
    {
        private readonly IKursServices _kursServices;

        public KursController(IKursServices kursServices) 
        {       
            _kursServices = kursServices;
        }
        [HttpGet]
        [Route("getall")]
        public IActionResult GetAll() 
        {
            return Ok(_kursServices.GetAll());
        }

        [HttpGet]
        [Route("get/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_kursServices.GetById(id));
        }
        [HttpGet]
        [Route("getCourse/{Name}")]
        public IActionResult GetCourse(string Name) 
        {
            return Ok(_kursServices.GetByCourse(Name));
        }
    }
}
