using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class TrackingSlotRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdLabel")]
	public uint LocalizedTextIdLabel { get; set; }

	[TableColumn("iconPath")]
	public string IconPath { get; set; } = string.Empty;

	[TableColumn("publicEventObjectiveId")]
	public uint PublicEventObjectiveId { get; set; }
}
