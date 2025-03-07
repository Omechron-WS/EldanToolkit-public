using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class ClientEventActionRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("actionTypeEnum")]
	public uint ActionTypeEnum { get; set; }

	[TableColumn("actionData00")]
	public uint ActionData00 { get; set; }

	[TableColumn("actionData01")]
	public uint ActionData01 { get; set; }

	[TableColumn("localizedTextIdSubZoneName")]
	public uint LocalizedTextIdSubZoneName { get; set; }
}
