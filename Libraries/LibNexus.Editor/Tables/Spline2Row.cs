using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class Spline2Row
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("worldId")]
	public uint WorldId { get; set; }

	[TableColumn("splineType")]
	public uint SplineType { get; set; }
}
