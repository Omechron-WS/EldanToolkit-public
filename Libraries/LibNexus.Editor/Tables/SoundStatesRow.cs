using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class SoundStatesRow
{
	[TableColumn("id")]
	public uint Id { get; set; }

	[TableColumn("nameHash")]
	public uint NameHash { get; set; }

	[TableColumn("soundGroupHash")]
	public uint SoundGroupHash { get; set; }
}
