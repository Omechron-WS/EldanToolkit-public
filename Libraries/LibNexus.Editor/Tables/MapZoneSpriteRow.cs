using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class MapZoneSpriteRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("spriteName")]
	public string SpriteName { get; set; } = string.Empty;
}
