using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class HousingPlotTypeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("maxPlacedDecor")]
	public uint MaxPlacedDecor { get; set; }
}
