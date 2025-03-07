using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class ItemColorSetRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("dyeColorRampId00")]
	public uint DyeColorRampId00 { get; set; }

	[TableColumn("dyeColorRampId01")]
	public uint DyeColorRampId01 { get; set; }

	[TableColumn("dyeColorRampId02")]
	public uint DyeColorRampId02 { get; set; }
}
