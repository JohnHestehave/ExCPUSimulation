using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCPUSimulation
{
	class Ram
	{
		public string[] Addresses;
		public Ram(int size)
		{
			Addresses = new string[size];
			for (int i = 0; i < size; i++)
			{
				Addresses[i] = "000000";
			}
		}

		public void PrintAll()
		{
			Console.WriteLine("Printing all addresses...");
			for (int i = 0; i < Addresses.Length; i++)
			{
				Console.WriteLine("Address "+ i+": "+Addresses[i]);
			}
		}
	}
}
