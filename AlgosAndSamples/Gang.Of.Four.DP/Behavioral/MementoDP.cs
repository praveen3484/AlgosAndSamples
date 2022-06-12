using System;

namespace AlgosAndSamples.Gang.Of.Four.DP.Behavioral
{
	public class MementoDP
	{
		public static void CheckMemento()
		{
			MementoDP mementoDP = new MementoDP();
			mementoDP.Processor();
			Console.ReadKey();
		}
		public void Processor()
		{
			Originator og = new Originator();
			//Set initial state of Originator
			og.State = "ON";

			//Save state of Originator inside caretaker
			CareTaker caretaker = new CareTaker();
			caretaker.Memento = og.CreateMemento();

			//Change state of Originator
			og.State = "Off";

			//Restore saved State
			og.SetMemento(caretaker.Memento);

			//wait for user Key
			Console.ReadKey();
		}

		class Originator
		{
			private string state;

			public string State
			{
				get { return state; }
				set { state = value; Console.WriteLine("State = " + state); }
			}
			public Memento CreateMemento()
			{
				Console.WriteLine("Saving current state");
				return (new Memento(state));
			}
			public void SetMemento(Memento memento)
			{
				Console.WriteLine("Restoring State");
				state = memento.State;
				Console.WriteLine("Restored State: " + state);
			}
		}
		class Memento
		{
			readonly string state;
			public Memento(string state)
			{
				this.state = state;
			}
			public string State { get { return state; } }
		}
		class CareTaker
		{
			public Memento Memento { get; set; }
		}
	}
}
