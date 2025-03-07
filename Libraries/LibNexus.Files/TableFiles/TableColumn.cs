using EldanToolkit.Libraries.LibNexus.Core.Extensions;
using System.IO;

namespace EldanToolkit.Libraries.LibNexus.Files.TableFiles;

public class TableColumn
{
	public const ulong Stride = 24;

	public ulong NameLength { get; }
	public ulong NameOffset { get; }
	public TableColumnType Type { get; }
	public TableColumnFlags Flags { get; }

	public TableColumn(Stream stream)
	{
		NameLength = stream.ReadUInt64();
		NameOffset = stream.ReadUInt64();
		Type = (TableColumnType)stream.ReadUInt32();
		Flags = (TableColumnFlags)stream.ReadUInt32();
	}
}
