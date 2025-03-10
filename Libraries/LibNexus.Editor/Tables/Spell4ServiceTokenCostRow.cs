using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class Spell4ServiceTokenCostRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("spell4Id")]
	public uint Spell4Id { get; set; }

	[TableColumn("serviceTokenCost")]
	public uint ServiceTokenCost { get; set; }
}
