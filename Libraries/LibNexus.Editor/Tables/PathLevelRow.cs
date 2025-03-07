using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class PathLevelRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("pathTypeEnum")]
	public uint PathTypeEnum { get; set; }

	[TableColumn("pathLevel")]
	public uint PathLevel { get; set; }

	[TableColumn("pathXP")]
	public uint PathXp { get; set; }
}
