﻿using EldanToolkit.WildStar.TestBed.TextTable.Static;
using System.Runtime.InteropServices;

namespace EldanToolkit.WildStar.TestBed.TextTable.IO
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Header
	{
		public uint Signature;
		public uint Version;
		public Language Language;
		public uint Unknown1;
		public long NameLength;
		public long NameOffset;
		public long CodeLength;
		public long CodeOffset;
		public long DescriptionLength;
		public long DescriptionOffset;
		public long RecordCount;
		public long RecordOffset;
		public long StringTableLength;
		public long StringTableOffset;
	}
}
