using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class PathScientistExperimentationRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("numAttempts")]
	public uint NumAttempts { get; set; }
}
