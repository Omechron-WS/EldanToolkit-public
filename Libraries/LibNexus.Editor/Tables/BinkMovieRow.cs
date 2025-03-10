using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class BinkMovieRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("binkMovieAssetPath")]
	public string BinkMovieAssetPath { get; set; } = string.Empty;

	[TableColumn("flags")]
	public uint Flags { get; set; }
}
