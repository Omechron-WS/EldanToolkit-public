using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class TutorialAnchorRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("tutorialAnchorOrientationEnum")]
	public uint TutorialAnchorOrientationEnum { get; set; }

	[TableColumn("hOffset")]
	public uint HOffset { get; set; }

	[TableColumn("vOffset")]
	public uint VOffset { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }
}
