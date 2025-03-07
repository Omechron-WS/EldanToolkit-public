using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class MaterialRemapRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("materialDataRow")]
	public uint MaterialDataRow { get; set; }

	[TableColumn("materialSetId")]
	public uint MaterialSetId { get; set; }

	[TableColumn("materialDataRowRemap")]
	public uint MaterialDataRowRemap { get; set; }
}
