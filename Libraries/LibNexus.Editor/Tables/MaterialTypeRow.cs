using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class MaterialTypeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("MaterialFlags")]
	public uint MaterialFlags { get; set; }
}
