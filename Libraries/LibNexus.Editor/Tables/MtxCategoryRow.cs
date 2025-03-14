using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class MtxCategoryRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("idString")]
	public string IdString { get; set; } = string.Empty;

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("mtxCategoryIdParent")]
	public uint MtxCategoryIdParent { get; set; }
}
