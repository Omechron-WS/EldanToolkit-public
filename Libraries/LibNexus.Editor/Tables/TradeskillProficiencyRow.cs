using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class TradeskillProficiencyRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("proficiencyFlagEnum")]
	public uint ProficiencyFlagEnum { get; set; }
}
