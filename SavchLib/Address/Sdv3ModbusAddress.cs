﻿namespace SavchLib.Address;

/// <summary>
///		SDV3 数据的 modbus 地址。
/// </summary>
public static class Sdv3ModbusAddress
{
	/// <summary>
	///		获取 EI 的地址
	/// </summary>
	/// <param name="index"></param>
	/// <returns></returns>
	public static uint EI(uint index)
	{
		if (index >= 1 && index <= 5)
		{
			return 0x400 + index - 1;
		}
		else if (index >= 9 && index <= 24)
		{
			return 0x208 + index - 9;
		}

		throw new ArgumentOutOfRangeException($"{nameof(index)} 超出范围。");
	}

	/// <summary>
	///		lua 脚本 D 变量的地址。
	/// </summary>
	/// <param name="index"></param>
	/// <returns></returns>
	/// <exception cref="ArgumentOutOfRangeException"></exception>
	public static uint LuaD(uint index)
	{
		if (index > 127)
		{
			throw new ArgumentOutOfRangeException($"{nameof(index)} 超出范围。");
		}

		return 0xc100 + (index * 2);
	}

	/// <summary>
	///		监控 VREF
	/// </summary>
	/// <returns></returns>
	public static uint MonitorVref()
	{
		return 0x1020;
	}
}
