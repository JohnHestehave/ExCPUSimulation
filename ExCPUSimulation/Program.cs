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
			ram.Addresses[0] = "010020"; // Load 100
			ram.Addresses[1] = "030021"; // Subtract 70, accumulator = 30
			ram.Addresses[2] = "090010"; // Test if 520 is greater than accumulator
			ram.Addresses[3] = "070006"; // If not greater jump to 6
			ram.Addresses[4] = "070008"; // If greater, jump to 8
			ram.Addresses[6] = "060031"; // Store to 31
			ram.Addresses[7] = "070009"; // Jump to end
			ram.Addresses[8] = "060030"; // Store to 30
			ram.Addresses[9] = "990000"; // Stop

			// Values
			ram.Addresses[10] = "000520";
			ram.Addresses[20] = "000100";
			ram.Addresses[21] = "000070";

			CPU cpu = new CPU(ram);

			cpu.Execute();
			Console.WriteLine();
			//ram.PrintAll();
			Console.ReadKey();
		}
		

	}
}
