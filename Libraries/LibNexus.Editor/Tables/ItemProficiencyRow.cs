using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class ItemProficiencyRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("bitMask")]
	public uint BitMask { get; set; }

	[TableColumn("localizedTextIdString")]
	public uint LocalizedTextIdString { get; set; }
}
