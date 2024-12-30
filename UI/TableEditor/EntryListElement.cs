using EldanToolkit.Shared;
using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

public partial class EntryListElement : VBoxContainer
{
	[Export]
	public PackedScene EntryListButton;

	public List<KeyValuePair<uint, DataRow>> OrderedList = new();
	public TableDataSet DataSet;
	public GameTableName TableName;

	private ButtonGroup buttonGroup;
	public LongButtonListControl EntryList;

	public delegate void SelectionChangedEvent(uint? id);
	public SelectionChangedEvent SelectionChanged;

	public uint? SelectedID { get; private set; }

	public override void _Ready()
	{
		buttonGroup = new ButtonGroup();

		EntryList = GetNode<LongButtonListControl>("%EntryList");
		Refresh();
	}

	public void Refresh()
	{
		// Good place to add any filters.
		OrderedList = DataSet?.GetTable(TableName)?.GetRowList()?.OrderBy(r => r.Key).ToList();
		if (OrderedList == null) return;

		TableStructure ts = TableStructure.GetStructure(TableName);

		var objectList = OrderedList.Cast<object>().ToList();
		EntryList.LoadData(objectList, (control, entry, id) =>
		{
			var pair = (KeyValuePair<uint, DataRow>)entry;
			var button = control as Button;

			button.Text = ts.GetEntryDescriptionFormatted(pair.Value, DataSet);
			button.ToggleMode = true;
			button.ButtonGroup = buttonGroup;
			button.Pressed += () => ButtonPressed(pair.Key, button.ButtonPressed);
		});
	}

	private void ButtonPressed(uint id, bool pressed)
	{
		if (pressed)
			SelectedID = id;
		else
			SelectedID = null;
		SelectionChanged?.Invoke(SelectedID);
	}
}
