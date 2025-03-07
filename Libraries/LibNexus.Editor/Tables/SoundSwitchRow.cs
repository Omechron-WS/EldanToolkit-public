using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class SoundSwitchRow
{
	[TableColumn("id")]
	public uint Id { get; set; }

	[TableColumn("nameHash")]
	public uint NameHash { get; set; }

	[TableColumn("groupHash")]
	public uint GroupHash { get; set; }
}
