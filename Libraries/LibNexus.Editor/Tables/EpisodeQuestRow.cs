using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class EpisodeQuestRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("episodeId")]
	public uint EpisodeId { get; set; }

	[TableColumn("questId")]
	public uint QuestId { get; set; }

	[TableColumn("orderIdx")]
	public uint OrderIdx { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }
}
