using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class Spell4TierRequirementsRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("tierIndex")]
	public uint TierIndex { get; set; }

	[TableColumn("levelRequirement")]
	public uint LevelRequirement { get; set; }
}
