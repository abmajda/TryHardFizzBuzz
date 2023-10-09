using FizzBuzzAPI.DTOs;
using System.Text;

namespace FizzBuzzAPI.Services.FizzBuzzSolverService
{
    public class FizzBuzzSolver
    {
        private FizzBuzzConfiguration _configuration;

        public FizzBuzzSolver(FizzBuzzConfiguration configuration)
        {
            _configuration = configuration;
        }

        public FizzBuzzResult SolveFizzBuzz()
        {
            var result = new FizzBuzzResult();

            for (int i = 1; i <= _configuration.NumberOfLines; i++)
            {
                result.results.Add(HandleLine(i));
            }

            return result;
        }

        private string HandleLine (int line)
        {
            var lineOutput = new StringBuilder(line.ToString() + ": ");

            foreach (FizzBuzzLineConfiguration lineConfig in _configuration.LineConfigurations)
            {
                if (line % lineConfig.LineNumber == 0)
                {
                    lineOutput.Append(lineConfig.Word);
                }
            }

            return lineOutput.ToString();
        }
    }
}
