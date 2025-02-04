using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultPattern;

public class Error
{
	public string Code;
	public string Description;

	public static readonly Error None = new()
	{
		Code = string.Empty,
		Description = string.Empty,
	};
}

public class CustomError
{
	public static Error FileNotFound = new()
	{
		Code = "FileNotFound",
		Description = "File not found description"
	};

	public static Error ValueBug(int value) => new() { Code = value + "IsBug", Description = "ValueBug description" };
}