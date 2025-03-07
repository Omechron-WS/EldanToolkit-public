using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class PrerequisiteTypeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdError")]
	public uint LocalizedTextIdError { get; set; }
}
