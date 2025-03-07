using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class PeriodicQuestSetCategoryRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("periodicSetsOffered")]
	public uint PeriodicSetsOffered { get; set; }
}
