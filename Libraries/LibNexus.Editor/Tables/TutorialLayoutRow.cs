using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class TutorialLayoutRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("form")]
	public string Form { get; set; } = string.Empty;

	[TableColumn("flags")]
	public uint Flags { get; set; }
}
