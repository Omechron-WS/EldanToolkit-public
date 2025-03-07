using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class SoundContextRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("eventId")]
	public uint EventId { get; set; }

	[TableColumn("type")]
	public uint Type { get; set; }
}
