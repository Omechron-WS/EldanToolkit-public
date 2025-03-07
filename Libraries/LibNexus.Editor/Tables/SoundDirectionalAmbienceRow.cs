using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class SoundDirectionalAmbienceRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("soundEventIdOutsideStart")]
	public uint SoundEventIdOutsideStart { get; set; }

	[TableColumn("soundEventIdOutsideStop")]
	public uint SoundEventIdOutsideStop { get; set; }
}
