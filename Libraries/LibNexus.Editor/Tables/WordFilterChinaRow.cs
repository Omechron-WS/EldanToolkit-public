using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class WordFilterChinaRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("filter")]
	public string Filter { get; set; } = string.Empty;
}
