using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class SoundParameterRow
{
	[TableColumn("id")]
	public uint Id { get; set; }

	[TableColumn("hash")]
	public uint Hash { get; set; }
}
