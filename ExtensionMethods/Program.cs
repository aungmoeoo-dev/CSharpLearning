// See https://aka.ms/new-console-template for more information

using System.Text.Json;

var human = new Human() { Name = "Kiwi" };

human.ChangeName("Ki Ki");
human.SayName();

bool result = await human.SaveAsync();

Console.WriteLine(result ? "Saving successful" : "Saving failed");

class Human
{
	public required string Name { get; set; }
	public int Age { get; set; }
}

static class HumanExtension
{
	public static void SayName(this Human human)
	{
		Console.WriteLine(human.Name);
	}

	public static void ChangeName(this Human human, string name)
	{
		human.Name = name;
	}

	public static async Task<bool> SaveAsync(this Human human)
	{
		bool isSuccessful;

		string currentDir = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName!;
		string path = Path.Join(currentDir + "/save.json");

		try
		{
			string json = JsonSerializer.Serialize(human);
			await File.WriteAllTextAsync(path, json);
			isSuccessful = true;
		}
		catch (Exception ex)
		{
			isSuccessful = false;
			Console.WriteLine(ex.Message);
		}

		return isSuccessful;
	}
}