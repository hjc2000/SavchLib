﻿using SavchLib.Address;

Console.WriteLine($"EI9: {Sdv3ModbusAddress.EI(9) + 1}");

for (uint i = 0; i <= 1; i++)
{
	Console.WriteLine($"D{i}: {Sdv3ModbusAddress.LuaD(i) + 1}");
}

for (uint i = 100; i <= 109; i++)
{
	Console.WriteLine($"D{i}: {Sdv3ModbusAddress.LuaD(i) + 1}");
}
