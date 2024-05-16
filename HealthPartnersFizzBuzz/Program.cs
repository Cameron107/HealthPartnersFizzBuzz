// See https://aka.ms/new-console-template for more information
using HealthPartnersFizzBuzz;
List<string> output;

var fizzBuzzInitializer = new FizzBuzzInitializer();

output = fizzBuzzInitializer.RunFizzBuzz();

foreach (var number in output)
{
    Console.WriteLine(number);
}