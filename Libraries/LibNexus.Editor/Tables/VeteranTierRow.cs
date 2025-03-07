using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class VeteranTierRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("primeLevel")]
	public uint PrimeLevel { get; set; }

	[TableColumn("veteranTierScalingType")]
	public uint VeteranTierScalingType { get; set; }

	[TableColumn("unitPropertyOverrideMenace")]
	public uint UnitPropertyOverrideMenace { get; set; }
}
