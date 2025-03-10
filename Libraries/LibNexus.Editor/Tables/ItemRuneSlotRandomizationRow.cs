using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class ItemRuneSlotRandomizationRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("microchipTypeEnum")]
	public uint MicrochipTypeEnum { get; set; }

	[TableColumn("itemRoleFlagBitMask")]
	public uint ItemRoleFlagBitMask { get; set; }

	[TableColumn("randomWeight")]
	public float RandomWeight { get; set; }
}
