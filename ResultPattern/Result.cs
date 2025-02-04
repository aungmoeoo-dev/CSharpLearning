using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ResultPattern;

public class Result<TValue>
{
	public TValue Value { get; set; }
	public Error Error { get; set; }

	public bool IsSuccess => Value is not null && Error.GetType == Error.None.GetType;
	public bool IsFailure => !IsSuccess;

	public static Result<TValue> Success(TValue value) => new Result<TValue> { Value = value, Error = Error.None };

	public static Result<TValue> Failure(Error error) => new Result<TValue> { Error = error };
}

public static class ResultExtension
{
	public static T Match<T>(
		this Result<T> result,
		Func<T, T> OnSuccess,
		Func<Error, T, T> OnFailure
		)
	{
		if (result.IsSuccess) return OnSuccess(result.Value);
		return OnFailure(result.Error, result.Value);
	}
}