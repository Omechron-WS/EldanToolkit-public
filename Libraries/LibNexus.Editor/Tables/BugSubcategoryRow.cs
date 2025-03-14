using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class BugSubcategoryRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("bugCategoryId")]
	public uint BugCategoryId { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }
}
