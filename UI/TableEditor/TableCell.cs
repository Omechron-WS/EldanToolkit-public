using EldanToolkit.Project;
using EldanToolkit.Shared;
using Godot;
using System;
using System.Data;

public partial class TableCell : Container
{
	private Label CellName;
	private LineEdit CellLineEdit;
	private ReferenceDropdownButton CellReferenceButton;

	public void SetValues(uint id, TableDataSet set, GameTableName tableName, string column)
	{
		CellName = GetNode<Label>("%CellName");
		CellLineEdit = GetNode<LineEdit>("%CellLineEdit");
		CellReferenceButton = GetNode<ReferenceDropdownButton>("%CellReferenceButton");

		var table = set.GetTable(tableName);
		var row = table.GetRow(id);
		TableStructure ts = TableStructure.GetStructure(tableName);

		CellName.Text = column;

		var columnData = ts.GetColumn(column);

		CellLineEdit.Visible = false;
		CellReferenceButton.Visible = false;

		switch(columnData.Type)
		{
			case TableColumn.ColumnType.Default:
			case TableColumn.ColumnType.ID:
				CellLineEdit.Visible = true;
				CellLineEdit.Text = row.GetValueRaw(column)?.ToString() ?? "";
				CellLineEdit.TextChanged += (newText) =>
				{
					var table = set.GetTable(tableName); // Get again, in case some tablemod was loaded or changed
					var row = table.GetRow(id);
					row.SetValue(column, newText);
				};
				break;
			case TableColumn.ColumnType.Reference:
			case TableColumn.ColumnType.LocalizedTextID:
				CellReferenceButton.Visible = true;
				CellReferenceButton.Text = row.GetValueRaw(column)?.ToString() ?? "";
				GameTableName gtn = GameTableName.enUS;
				if (columnData.Type == TableColumn.ColumnType.Reference)
				{
					gtn = columnData.RefTable.Value;
				}
				CellReferenceButton.LoadData(set, gtn);
				CellReferenceButton.EntrySelected += (refID) =>
				{
					var table = set.GetTable(tableName); // Get again, in case some tablemod was loaded or changed
					var row = table.GetRow(id);

					if (refID != null)
					{
						var refTable = set.GetTable(gtn);
						var refRow = refTable.GetRow(refID.Value);
						row.SetValue(column, refRow.GetValue<uint>("UID"));
					}
					else
					{
						row.SetValue(column, 0);
					}
					Events.TableEntryChanged?.Invoke(tableName, row.GetValue<uint>("UID"));
				};
				break;
		}
	}
}