using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class Creature2ActionSetRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("description")]
	public string Description { get; set; } = string.Empty;

	[TableColumn("prerequisiteId")]
	public uint PrerequisiteId { get; set; }
}
