using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerialization;

internal class Human
{

	public string name { get; set; }
	public int age { get; set; }
	public Human?[] parents { get; set; }
}
