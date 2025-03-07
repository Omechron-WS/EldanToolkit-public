using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class PathScientistDatacubeDiscoveryRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("worldZoneId")]
	public uint WorldZoneId { get; set; }
}
