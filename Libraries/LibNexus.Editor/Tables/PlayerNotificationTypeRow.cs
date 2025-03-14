using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class PlayerNotificationTypeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("priority")]
	public uint Priority { get; set; }

	[TableColumn("lifetimeMs")]
	public uint LifetimeMs { get; set; }
}
