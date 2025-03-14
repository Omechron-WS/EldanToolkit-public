using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class SoundReplaceRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("soundReplaceDescriptionId")]
	public uint SoundReplaceDescriptionId { get; set; }

	[TableColumn("soundEventIdOld")]
	public uint SoundEventIdOld { get; set; }

	[TableColumn("soundEventIdNew")]
	public uint SoundEventIdNew { get; set; }
}
