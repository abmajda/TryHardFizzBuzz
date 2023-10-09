namespace FizzBuzzAPI.DTOs
{
    public class FizzBuzzConfiguration
    {
        public List<FizzBuzzLineConfiguration> LineConfigurations {  get; set; }
        public int NumberOfLines { get; set; }
    }

    public class FizzBuzzLineConfiguration
    {
        public int LineNumber { get; set; }
        public string Word { get; set; }
    }
}
