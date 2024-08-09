namespace SavchLib.Address;
public class Sdv3Address
{
	/// <summary>
	///		获取 EI 的地址
	/// </summary>
	/// <param name="ei_index"></param>
	/// <returns></returns>
	public uint EI(uint ei_index)
	{
		if (ei_index >= 1 && ei_index <= 5)
		{
			return 0x400 + ei_index - 1;
		}
		else if (ei_index >= 9 && ei_index <= 24)
		{
			return 0x208 + ei_index - 9;
		}

		throw new ArgumentOutOfRangeException($"{nameof(ei_index)} 超出范围。");
	}
}
