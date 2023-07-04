using System;

namespace ClassLibrary
{
	public class Auto : IComparable<Auto>
	{
		public string Title { get; set; }
		public string Number { get; set; }

		public Auto(string title, string number)
		{
			Title = title;
			Number = number;
		}

		public int CompareTo(Auto other)
		{
			return Number.CompareTo(other.Number);
		}

		public void Show()
		{
			Console.WriteLine("Автомобиль:\n"+
				$"\tНазвание: {Title}\n"+
				$"\tНомер: {Number}");
		}
	}
}
