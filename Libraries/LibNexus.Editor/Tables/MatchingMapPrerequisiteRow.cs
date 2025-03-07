using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class MatchingMapPrerequisiteRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("matchingGameMapId")]
	public uint MatchingGameMapId { get; set; }

	[TableColumn("matchingEligibilityFlagEnum")]
	public uint MatchingEligibilityFlagEnum { get; set; }
}
