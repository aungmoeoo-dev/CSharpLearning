using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern;

public class StatePatternMain
{
	public static void Run()
	{
		Car car = new Car();

		car.SetState(new IdleState());

		Console.WriteLine(car.Speed);

		car.SetState(new MoveState());

		Console.WriteLine(car.Speed);
	}
}
