using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class RewardRotationEssenceRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("accountCurrencyTypeId")]
	public uint AccountCurrencyTypeId { get; set; }

	[TableColumn("minPlayerLevel")]
	public uint MinPlayerLevel { get; set; }

	[TableColumn("worldDifficultyFlags")]
	public uint WorldDifficultyFlags { get; set; }
}
