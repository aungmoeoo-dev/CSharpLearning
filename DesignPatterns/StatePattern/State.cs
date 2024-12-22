using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern;

public abstract class State
{
	protected Car _car { get; set; }

	public void SetSpeed(int speed)
	{
		_car.Speed = speed;
	}

	public abstract void CommitState();
}

public class IdleState : State
{
	public override void CommitState()
	{
		SetSpeed(0);
	}

}

public class MoveState : State
{
	public override void CommitState()
	{
		SetSpeed(10);
	}
}