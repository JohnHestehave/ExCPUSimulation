using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCPUSimulation
{
	class CPU
	{
		int Accumulator;
		int ProgramCounter;
		Ram Ram;
		public CPU(Ram ram)
		{
			Ram = ram;
			ProgramCounter = 0;
			Accumulator = 0;
		}

		public void Execute()
		{
			bool running = true;
			while (running)
			{
				string code = Ram.Addresses[ProgramCounter];
				int opcode = int.Parse(code.Substring(0, 2));
				int address = int.Parse(code.Substring(2, 4));
				int value = int.Parse(Ram.Addresses[address].Substring(2, 4));
				switch (opcode)
				{
					case 1:
						Accumulator = value;
						Console.WriteLine("Load value " + value +" from address " + address + " into accumulator.");
						break;
					case 2:
						Accumulator += value;
						Console.WriteLine("Add value " + value +" from address " + address + " and store in accumulator");
						break;
					case 6:
						Ram.Addresses[address] = Accumulator.ToString().PadLeft(6, '0');
						Console.WriteLine("Store value " + value + " to address " + address);
						break;
					case 99:
						running = false;
						break;
				}
				ProgramCounter++;
			}
		}
	}
}
