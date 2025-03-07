using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class Spell4StackGroupRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("stackCap")]
	public uint StackCap { get; set; }

	[TableColumn("stackTypeEnum")]
	public uint StackTypeEnum { get; set; }
}
