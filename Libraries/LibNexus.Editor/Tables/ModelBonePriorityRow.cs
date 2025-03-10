using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class ModelBonePriorityRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("BoneID")]
	public uint BoneId { get; set; }

	[TableColumn("BoneSetID")]
	public uint BoneSetId { get; set; }

	[TableColumn("Priority")]
	public uint Priority { get; set; }
}
