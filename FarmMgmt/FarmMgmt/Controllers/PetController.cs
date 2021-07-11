using FarmMgmt.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System.Collections.Generic;

namespace FarmMgmt.Controllers
{
	using FarmMgmt.Interfaces;

	[ApiController]
    [Route("[controller]")]
    public class PetController : ControllerBase
    {
	    private readonly ILogger<PetController> _logger;
	    private readonly IPetService _petService;

        public PetController(ILogger<PetController> logger, IPetService petService)
        {
            _logger = logger;
            _petService = petService;
        }

        [HttpGet("List")]
        public IEnumerable<Pet> List(){
	        return _petService.List();
        }

        [HttpPost("Add")]
        public ActionResult Add(string petName)
        {
	        var opResult = _petService.Add(petName);
	        if (opResult)
		        return Ok($"Pet {petName} successfully added!");
	        else
	        {
		        return BadRequest($"Pet {petName} already exists! Cannot add duplicate one. Please check your glasses)");
	        }
        }

        [HttpPost("Remove")]
        public ActionResult Remove(string petName){
	        var opResult = _petService.Remove(petName);
	        if (opResult)
		        return Ok($"Pet {petName} successfully removed!");
	        else{
		        return BadRequest($"Pet {petName} does not exists! Please check your glasses)");
	        }
        }
    }
}
