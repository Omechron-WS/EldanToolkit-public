using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class Spell4ValidTargetsRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("targetBitmask")]
	public uint TargetBitmask { get; set; }
}
