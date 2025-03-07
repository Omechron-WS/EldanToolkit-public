using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class SoundMusicSetRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("soundEventIdStart")]
	public uint SoundEventIdStart { get; set; }

	[TableColumn("soundEventIdStop")]
	public uint SoundEventIdStop { get; set; }

	[TableColumn("restartDelayMin")]
	public float RestartDelayMin { get; set; }

	[TableColumn("restartDelayMax")]
	public float RestartDelayMax { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }
}
