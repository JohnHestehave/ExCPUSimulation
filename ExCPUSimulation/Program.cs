using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCPUSimulation
{
	class Program
	{
		static void Main(string[] args)
		{
			Ram ram = new Ram(40);
			ram.Addresses[0] = "010020";
			ram.Addresses[1] = "020021";
			ram.Addresses[2] = "060022";
			ram.Addresses[3] = "990000";
			ram.Addresses[20] = "000100";
			ram.Addresses[21] = "000123";

			CPU cpu = new CPU(ram);

			cpu.Execute();
			Console.WriteLine();
			ram.PrintAll();
			Console.ReadKey();
		}
		

	}
}
