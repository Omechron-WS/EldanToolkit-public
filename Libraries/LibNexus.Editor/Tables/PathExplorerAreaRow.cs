using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class PathExplorerAreaRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("pathSettlerHubId")]
	public uint PathSettlerHubId { get; set; }
}
