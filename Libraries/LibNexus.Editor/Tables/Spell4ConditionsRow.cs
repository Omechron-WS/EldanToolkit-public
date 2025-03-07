using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class Spell4ConditionsRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("conditionMask")]
	public uint ConditionMask { get; set; }

	[TableColumn("conditionValue")]
	public uint ConditionValue { get; set; }
}
