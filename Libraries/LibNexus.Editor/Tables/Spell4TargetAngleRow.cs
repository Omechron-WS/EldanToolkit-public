using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class Spell4TargetAngleRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("targetAngle")]
	public float TargetAngle { get; set; }
}
