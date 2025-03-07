using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class Spell4SpellTypesRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("typeName")]
	public string TypeName { get; set; } = string.Empty;

	[TableColumn("enumName")]
	public string EnumName { get; set; } = string.Empty;
}
