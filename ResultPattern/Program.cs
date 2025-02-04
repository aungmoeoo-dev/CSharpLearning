// See https://aka.ms/new-console-template for more information

using ResultPattern;



var result = Result<Human>.Success(new Human { Name = "Kiwi", Age = 22 });

result.Match(
	OnSuccess: (man) =>
	{
		Console.WriteLine(man.Name);
		return man;
	},
	OnFailure: (error, man) =>
	{
		Console.WriteLine($"Error: {error}");
		return man;
	});

class Human
{
	public string Name { get; set; }
	public int Age { get; set; }
}