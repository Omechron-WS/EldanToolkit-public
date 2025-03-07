using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class RewardRotationContentRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("contentTypeEnum")]
	public uint ContentTypeEnum { get; set; }
}
