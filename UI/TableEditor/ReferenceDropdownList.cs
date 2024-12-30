using EldanToolkit.Shared;
using Godot;
using System;

public partial class ReferenceDropdownList : PopupPanel
{
	public ReferenceDropdownButton parent;
	private EntryListElement EntryList;
	private Button AcceptButton;
	uint id;
	TableDataSet set;
	GameTableName tableName;
	string column;

	public override void _Ready()
	{
		EntryList = GetNode<EntryListElement>("%EntryList");

		AcceptButton = GetNode<Button>("%AcceptButton");
		AcceptButton.Pressed += Accept;

		CloseRequested += Close;
	}

	public void LoadData(TableDataSet set, GameTableName tableName)
	{
		EntryList.DataSet = set;
		EntryList.TableName = tableName;
		EntryList.Refresh();
	}

	public void Accept()
	{
		parent?.EntrySelected?.Invoke(EntryList.SelectedID);
		Close();
	}

	public void Close()
	{
		Hide();
		QueueFree();
	}
}
