using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class Spell4TelegraphRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("spell4Id")]
	public uint Spell4Id { get; set; }

	[TableColumn("telegraphDamageId")]
	public uint TelegraphDamageId { get; set; }
}
