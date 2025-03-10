using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class TargetMarkerRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("visualEffectId")]
	public uint VisualEffectId { get; set; }

	[TableColumn("iconPath")]
	public string IconPath { get; set; } = string.Empty;
}
