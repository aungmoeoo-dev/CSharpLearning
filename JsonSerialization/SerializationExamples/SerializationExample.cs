﻿using System.Text.Json;

namespace JsonSerialization.SerializationExamples;

internal class SerializationExample
{
    public static void Run()
    {

		var executableDirectory = Environment.CurrentDirectory;
        var projectDirectory = Directory.GetParent(executableDirectory)?.Parent?.Parent?.FullName;

		Human human = new()
		{
			name = "Test name",
			age = 10,
		};

		var jsonString = JsonSerializer.Serialize(human);

        try
        {
            var path = Path.Combine(projectDirectory!, "serialized_human.json");
            File.WriteAllText(path, jsonString);

            Console.WriteLine("human saved.");
        }
        catch (Exception e)
        {
            Console.Write(e.Message);
        }

    }
}
