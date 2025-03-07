using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class Creature2AffiliationRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdTitle")]
	public uint LocalizedTextIdTitle { get; set; }

	[TableColumn("miniMapMarkerId")]
	public uint MiniMapMarkerId { get; set; }

	[TableColumn("overheadIconAssetPath")]
	public string OverheadIconAssetPath { get; set; } = string.Empty;
}
