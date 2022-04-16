using System;
namespace Vehicle_Car_Bus.Models
{
	public class Bus : Vehicle
	{
		private int _passengerCount;
		public int PassengerCount
		{
			get => _passengerCount;

            set
			{
				if (value > 0 && value < 90)
				{
					_passengerCount = value;
				}
			}
		}

        public Bus(int passengerCount, int year) : base(year)
		{
			PassengerCount = passengerCount;
		}

		public override void ShowInfo()
		{
			Console.WriteLine($" Bus Information\n Passenger Count: {PassengerCount}\n Year {Year}\n");
		}
	}
}

