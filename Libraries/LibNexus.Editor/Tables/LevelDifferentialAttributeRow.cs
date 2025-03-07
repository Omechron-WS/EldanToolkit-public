using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class LevelDifferentialAttributeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[TableColumn("levelDifferentialValue")]
	public uint LevelDifferentialValue { get; set; }

	[TableColumn("questXpMultiplier")]
	public float QuestXpMultiplier { get; set; }
}
