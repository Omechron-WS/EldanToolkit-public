using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class SoundBankRow
{
	[TableColumn("id")]
	public uint Id { get; set; }

	[TableColumn("name")]
	public string Name { get; set; } = string.Empty;
}
