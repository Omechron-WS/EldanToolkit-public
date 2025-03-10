using EldanToolkit.Libraries.LibNexus.Files.TableFiles;

namespace EldanToolkit.Libraries.LibNexus.Editor.Tables;

public class TicketSubCategoryRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("ticketCategoryId")]
	public uint TicketCategoryId { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }
}
