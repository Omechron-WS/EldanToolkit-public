using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class PathExplorerDoorRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("worldZoneIdInsideMicro")]
	public uint WorldZoneIdInsideMicro { get; set; }

	[TableColumn("targetGroupIdActivate")]
	public uint TargetGroupIdActivate { get; set; }

	[TableColumn("targetGroupIdKill")]
	public uint TargetGroupIdKill { get; set; }
}
