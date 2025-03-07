using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class MapZoneHexGroupEntryRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("mapZoneHexGroupId")]
	public uint MapZoneHexGroupId { get; set; }

	[TableColumn("hexX")]
	public uint HexX { get; set; }

	[TableColumn("hexY")]
	public uint HexY { get; set; }
}
