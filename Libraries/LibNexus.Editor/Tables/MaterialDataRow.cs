using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class MaterialDataRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("row")]
	public uint Row { get; set; }

	[TableColumn("materialTypeId")]
	public uint MaterialTypeId { get; set; }
}
