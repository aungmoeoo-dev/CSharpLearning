// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json;
using System.Net.Http.Json;

using HttpClient client = new();

var responseMessage = await client.GetAsync("https://raw.githubusercontent.com/burma-project-ideas/phayar-sar/refs/heads/main/data/1/1.json");
var content = await responseMessage.Content.ReadAsStringAsync();

var ph = JsonConvert.DeserializeObject<PhayarSar>(content);
Console.WriteLine(ph.title);


public class PhayarSar
{
	public int id { get; set; }
	public int groupId { get; set; }
	public string title { get; set; }
	public string content { get; set; }
}





//client.BaseAddress = new Uri("https://jsonplaceholder.org");
//var posts = client.GetFromJsonAsync<List<Post>>("/posts").Result!.Skip(10).Take(10);

//foreach (var post in posts!)
//{
//	Console.WriteLine($"{post.Slug}: {post.Title}");
//}

//class Post
//{
//	//public int Id { get; set; }
//	public string? Slug { get; set; }
//	public string? Url { get; set; }
//	public string? Title { get; set; }
//	public string? Content { get; set; }
//	public string? Image { get; set; }
//	public string? Thumbnail { get; set; }
//	public string? Status { get; set; }
//	public string? Category { get; set; }
//	public string? PublishedAt { get; set; }
//	public string? UpdatedAt { get; set; }
//	//public int UserId { get; set; }
//}

