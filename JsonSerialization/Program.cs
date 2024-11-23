// See https://aka.ms/new-console-template for more information


using JsonSerialization;
using JsonSerialization.DeserializationExamples;
using JsonSerialization.SerializationExamples;

Human human = new() 
{
	name = "Test name",
	age = 10,
};
SerializationExample.Run(human);

DeserializationExample.Run();