﻿using EldanToolkit.WildStar.TestBed.GameTable.Static;
using System.IO;
using System.Runtime.InteropServices;

namespace EldanToolkit.WildStar.TestBed.GameTable.IO
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct TblColumn
	{
		public long NameLength;
		public long NameOffset;
		public DataType Type;
		public ushort Unknown2;
		public uint Unknown3;

		public void Write(BinaryWriter writer)
		{
			writer.Write(NameLength);
			writer.Write(NameOffset);
			writer.Write((ushort)Type);
			writer.Write(Unknown2);
			writer.Write(Unknown3);
		}
	}
}
