using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class RandomTextLineRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("randomTextLineSetId")]
	public uint RandomTextLineSetId { get; set; }
}
