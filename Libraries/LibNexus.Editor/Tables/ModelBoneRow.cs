using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class ModelBoneRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("XSIName")]
	public string XsiName { get; set; } = string.Empty;
}
