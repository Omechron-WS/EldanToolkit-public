using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class HousingDecorLimitCategoryRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("decorLimit")]
	public uint DecorLimit { get; set; }
}
