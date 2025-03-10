using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class QuestCategoryRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("description")]
	public string Description { get; set; } = string.Empty;

	[TableColumn("localizedTextIdTitle")]
	public uint LocalizedTextIdTitle { get; set; }

	[TableColumn("questCategoryTypeEnum")]
	public uint QuestCategoryTypeEnum { get; set; }
}
