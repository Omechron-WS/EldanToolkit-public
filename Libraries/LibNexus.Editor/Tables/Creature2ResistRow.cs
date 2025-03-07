using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class Creature2ResistRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("resistPhysicalMultiplier")]
	public float ResistPhysicalMultiplier { get; set; }

	[TableColumn("resistTechMultiplier")]
	public float ResistTechMultiplier { get; set; }

	[TableColumn("resistMagicMultiplier")]
	public float ResistMagicMultiplier { get; set; }
}
