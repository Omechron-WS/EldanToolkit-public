using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class ActionSlotPrereqRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("slotIndex")]
	public uint SlotIndex { get; set; }

	[TableColumn("prerequisiteIdUnlock")]
	public uint PrerequisiteIdUnlock { get; set; }
}
