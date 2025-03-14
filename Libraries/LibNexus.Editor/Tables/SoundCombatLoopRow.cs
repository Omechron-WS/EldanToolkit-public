using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class SoundCombatLoopRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("soundEventIdStart")]
	public uint SoundEventIdStart { get; set; }

	[TableColumn("soundEventIdStop")]
	public uint SoundEventIdStop { get; set; }

	[TableColumn("soundParameterIdUnitsInCombat")]
	public uint SoundParameterIdUnitsInCombat { get; set; }
}
