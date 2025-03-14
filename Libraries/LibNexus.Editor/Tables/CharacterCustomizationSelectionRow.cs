using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class CharacterCustomizationSelectionRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("characterCustomizationLabelId")]
	public uint CharacterCustomizationLabelId { get; set; }

	[TableColumn("value")]
	public uint Value { get; set; }

	[TableColumn("cost")]
	public ulong Cost { get; set; }
}
