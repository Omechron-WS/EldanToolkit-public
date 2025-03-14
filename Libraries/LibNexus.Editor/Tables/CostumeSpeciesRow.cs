using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class CostumeSpeciesRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("componentLayoutId")]
	public uint ComponentLayoutId { get; set; }

	[TableColumn("enumName")]
	public string EnumName { get; set; } = string.Empty;
}
