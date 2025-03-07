using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class XpPerLevelRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("minXpForLevel")]
	public uint MinXpForLevel { get; set; }

	[TableColumn("baseQuestXpPerLevel")]
	public uint BaseQuestXpPerLevel { get; set; }

	[TableColumn("abilityPointsPerLevel")]
	public uint AbilityPointsPerLevel { get; set; }

	[TableColumn("attributePointsPerLevel")]
	public uint AttributePointsPerLevel { get; set; }

	[TableColumn("baseRepRewardPerLevel")]
	public uint BaseRepRewardPerLevel { get; set; }
}
