using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class InputActionCategoryRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }
}
