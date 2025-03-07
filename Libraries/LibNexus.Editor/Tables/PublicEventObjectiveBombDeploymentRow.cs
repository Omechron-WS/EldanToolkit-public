using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class PublicEventObjectiveBombDeploymentRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("creature2IdBomb")]
	public uint Creature2IdBomb { get; set; }

	[TableColumn("spell4IdCarrying")]
	public uint Spell4IdCarrying { get; set; }
}
