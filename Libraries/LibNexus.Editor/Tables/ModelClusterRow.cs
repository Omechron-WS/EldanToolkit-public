using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class ModelClusterRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("EnumName")]
	public string EnumName { get; set; } = string.Empty;
}
