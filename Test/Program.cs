using SavchLib.Address;

Console.WriteLine($"EI9: {Sdv3Address.EI(9) + 1}");

for (uint i = 0; i <= 1; i++)
{
	Console.WriteLine($"D{i}: {Sdv3Address.LuaD(i) + 1}");
}

for (uint i = 100; i <= 109; i++)
{
	Console.WriteLine($"D{i}: {Sdv3Address.LuaD(i) + 1}");
}
