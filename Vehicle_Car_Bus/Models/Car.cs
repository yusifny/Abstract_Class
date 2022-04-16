using System;
namespace Vehicle_Car_Bus.Models
{
	public class Car : Vehicle
	{
		private int _maxSpeed;
        public string Brand { get; set; }
		public string Model { get; set; }
		public int MaxSpeed
		{
			get => _maxSpeed;
            set
			{
                if (value>0 && value<220)
                {
					_maxSpeed = value;
                }
            }
		}

		public Car(string brand, string model, int year) : base(year)
		{
			Brand = brand;
			Model = model;
		}

        public override void ShowInfo()
        {
            Console.WriteLine($" Car Information\n Brand: {Brand}\n Model{Model}\n Year{Year}\n");
        }


	}
}

