using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class MatchTypeRewardRotationContentRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("matchTypeEnum")]
	public uint MatchTypeEnum { get; set; }

	[TableColumn("rewardRotationContentIdRandomNormal")]
	public uint RewardRotationContentIdRandomNormal { get; set; }

	[TableColumn("rewardRotationContentIdRandomVeteran")]
	public uint RewardRotationContentIdRandomVeteran { get; set; }
}
