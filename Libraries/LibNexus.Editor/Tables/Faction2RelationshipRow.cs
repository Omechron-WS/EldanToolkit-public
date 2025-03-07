using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class Faction2RelationshipRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("factionId0")]
	public uint FactionId0 { get; set; }

	[TableColumn("factionId1")]
	public uint FactionId1 { get; set; }

	[TableColumn("factionLevel")]
	public uint FactionLevel { get; set; }
}
