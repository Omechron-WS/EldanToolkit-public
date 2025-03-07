using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class SoundImpactEventsRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("origin")]
	public uint Origin { get; set; }

	[TableColumn("target")]
	public uint Target { get; set; }

	[TableColumn("qualifier")]
	public uint Qualifier { get; set; }

	[TableColumn("event")]
	public uint Event { get; set; }
}
