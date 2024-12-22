using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern;

public class Car
{
	private State _state { get; set; }

	public int Speed { get; set; }

	public void SetState(State state)
	{
		state.CommitState();
	}
}
