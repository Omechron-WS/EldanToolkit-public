using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class PositionalRequirementRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("angleCenter")]
	public uint AngleCenter { get; set; }

	[TableColumn("angleRange")]
	public uint AngleRange { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }
}
