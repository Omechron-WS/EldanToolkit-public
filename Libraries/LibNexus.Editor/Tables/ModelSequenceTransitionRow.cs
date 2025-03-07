using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class ModelSequenceTransitionRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("modelSequenceIdFrom")]
	public uint ModelSequenceIdFrom { get; set; }

	[TableColumn("modelSequenceIdTo")]
	public uint ModelSequenceIdTo { get; set; }

	[TableColumn("modelSequenceIdTransition")]
	public uint ModelSequenceIdTransition { get; set; }
}
