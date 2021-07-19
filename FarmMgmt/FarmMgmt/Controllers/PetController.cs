using FarmMgmt.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System.Collections.Generic;

namespace FarmMgmt.Controllers
{
	using FarmMgmt.Interfaces;

	[ApiController]
    [Route("api/[controller]")]
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
        public IEnumerable<Pet> List()
        {
            return _petService.List();
        }

        [HttpGet("Add")]
        public ActionResult Add(string petName)
        {
            _logger.LogInformation($"Receieved Add call with petName `{petName}`");
	        var opResult = _petService.Add(petName);
            if (opResult)
            {
                _logger.LogInformation($"Pet `{petName}` added successfully");
                return Ok($"Pet `{petName}` successfully added!");
            }
            else
            {
                _logger.LogWarning($"Pet {petName} already exists! Cannot add duplicate one.");
                return BadRequest($"Pet {petName} already exists! Cannot add duplicate one. Please check your glasses)");
            }
        }

        [HttpGet("Remove")]
        public ActionResult Remove(string petName)
        {
            _logger.LogInformation($"Receieved Remove call with petName `{petName}`");
            var opResult = _petService.Remove(petName);
            if (opResult)
            {
                _logger.LogInformation($"Pet {petName} successfully removed.");
                return Ok($"Pet {petName} successfully removed!");
            }
            else
            {
                _logger.LogWarning($"Pet {petName} does not exists! Cannot remove pet `{petName}`");
                return BadRequest($"Pet {petName} does not exists! Please check your glasses)");
            }
        }
    }
}
