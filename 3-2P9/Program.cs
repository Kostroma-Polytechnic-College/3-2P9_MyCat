using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2P9
{
	public class Cat
    {
		string color;
		int norma;
		public Cat(string color, int norma)
        {
			this.color = color;
			this.norma = norma;
        }

		public delegate void MayDelegate(Cat cat);
		public event MayDelegate May;


		public void Eat(int v)
        {
			Console.WriteLine(this.norma.ToString() +" - "+ v);
			this.norma -= v;
			if (this.norma > 0)
				if (this.May != null)
					May(this);
        }
    }

	public static class Program
	{
		public static void Main()
		{
			Cat cat = new Cat("Белый", 100);
			cat.May += Add_eat;
			Add_eat(cat);
			Console.ReadKey();
		}

		public static void Add_eat(Cat cat)
        {
			cat.Eat(200);
        }

	}
}
