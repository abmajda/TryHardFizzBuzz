using FizzBuzzAPI.DTOs;
using FizzBuzzAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzzAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FizzBuzzController
    {
        private IFizzBuzzSolverService _fizzBuzzSolverService;

        public FizzBuzzController(IFizzBuzzSolverService fizzBuzzSolverService)
        {
            _fizzBuzzSolverService = fizzBuzzSolverService;
        }

        [HttpPost("fizz_buzz")]
        public ActionResult<FizzBuzzResult> SolveFizzBuzz(FizzBuzzConfiguration config)
        {
            var result = _fizzBuzzSolverService.SolveFizzBuzz(config);
            return result;
        }
    }
}
