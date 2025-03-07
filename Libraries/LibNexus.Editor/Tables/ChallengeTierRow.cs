using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class ChallengeTierRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("count")]
	public uint Count { get; set; }
}
