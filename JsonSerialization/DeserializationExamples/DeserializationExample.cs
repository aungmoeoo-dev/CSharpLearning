using System.Text.Json;

namespace JsonSerialization.DeserializationExamples;

internal class DeserializationExample
{
    public static void Run()
    {
        string workingDirectory = Environment.CurrentDirectory;

        var projectDirectory = Directory.GetParent(workingDirectory)?.Parent?.Parent?.FullName;

        var jsonString = File.ReadAllText(projectDirectory + "./dummy.json");

        var humans = JsonSerializer.Deserialize<Human[]>(jsonString);

        if (humans is null)
        {
            Console.WriteLine("humans are null.");
            return;
        }

        foreach (var human in humans)
        {
            var father = human.parents[0];
            var mother = human.parents[1];

            string text = $@"{human.name} is {human.age} years old and
her parents are {father?.name} and {mother?.name}";

            Console.WriteLine(text);
            Console.WriteLine("------------------------------------------");
        }
    }
}
