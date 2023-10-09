using FizzBuzzAPI.DTOs;

namespace FizzBuzzAPI.Interfaces
{
    public interface IFizzBuzzSolverService
    {
        FizzBuzzResult SolveFizzBuzz(FizzBuzzConfiguration configuration);
    }
}
