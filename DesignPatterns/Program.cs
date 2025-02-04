using System.Security.Cryptography;
using System.Text;

string has = "123".ToHashPassword("slh@gmail.com", "123");

Console.WriteLine(has);

public static class DevCode
{
	public static string ToHashPassword(this string password, string userName, string secretKey)
	{
		// Create a SHA256 hash of the password
		using SHA256 sha256Hash = SHA256.Create();
		byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(
			password +
			userName.Replace("a", "@").Replace("l", "!") +
			secretKey));

		// Convert the byte array to a hexadecimal string
		StringBuilder builder = new StringBuilder();
		for (int i = 0; i < bytes.Length; i++)
		{
			builder.Append(bytes[i].ToString("x2"));
		}
		return builder.ToString();
	}
}

class Person
{
	private readonly string name;

	public Person(string name)
	{
		this.name = name;
	}

	public void Greet()
	{
		Console.WriteLine($"Hello, I am {name}");
	}
}