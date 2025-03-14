using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class LuaEventRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("eventName")]
	public string EventName { get; set; } = string.Empty;

	[TableColumn("parameters")]
	public string Parameters { get; set; } = string.Empty;
}
