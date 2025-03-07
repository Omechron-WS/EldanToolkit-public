using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class SoundUiContextRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("luaVariableName")]
	public string LuaVariableName { get; set; } = string.Empty;

	[TableColumn("soundEventId")]
	public uint SoundEventId { get; set; }
}
