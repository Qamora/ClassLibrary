using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class Driver
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public List<Auto> Autos = new List<Auto>();

		public Driver(string name, string class_) 
        { 
            Name = name;
			Class = class_;
        }

        // Выводит информацию
		public void ShowAll()
        {
            Console.Write("Водитель:\n"+
				$"\tФИО: {Name}\n"+
				$"\tКвалификация: {Class}\n\n"+
				"Список автомобилей:\n");

			Autos.Sort();
            foreach (var auto in Autos)
            {
				auto.Show();
            }
        }
    }
}
