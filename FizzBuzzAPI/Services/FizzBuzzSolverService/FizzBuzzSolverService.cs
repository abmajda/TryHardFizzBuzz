using FizzBuzzAPI.DTOs;
using FizzBuzzAPI.Interfaces;

namespace FizzBuzzAPI.Services.FizzBuzzSolverService
{
    public class FizzBuzzSolverService : IFizzBuzzSolverService
    {
        public FizzBuzzResult SolveFizzBuzz(FizzBuzzConfiguration configuration)
        {
            var solver = new FizzBuzzSolver(configuration);
            return solver.SolveFizzBuzz();
        }
    }
}
