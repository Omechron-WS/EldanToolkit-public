using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class ModelSkinFxRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("suffix")]
	public string Suffix { get; set; } = string.Empty;
}
