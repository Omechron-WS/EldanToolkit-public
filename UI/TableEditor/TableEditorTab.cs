using EldanToolkit.Project;
using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using WildStar.TestBed;

public partial class TableEditorTab : VBoxContainer
{
	private Stack<TableViewReference> Breadcrumbs = new();
	private Container BreadcrumbsHolder;
	private OptionButton TableSelector;
	private Dictionary<int, TableViewReference> TableSelectorLookup = new();
	private Container EntryEditor;
	private EntryListElement TableEntryList;
	private Button SaveButton;

	private TableModManager mods;

	private TableViewReference CurrentTable;
	private DataTable TableRef;
	private int? CurrentEntryID = null;

	[Export]
	public PackedScene EntryCell;

	public override void _Ready()
	{
		base._Ready();
		mods = new TableModManager(ProjectHolder.project);
		BreadcrumbsHolder = GetNode<Container>("%Breadcrumbs");
		TableSelector = GetNode<OptionButton>("%TableSelector");
		TableSelector.ItemSelected += TableSelected;

		EntryEditor = GetNode<Container>("%EntryEditor");
		TableEntryList = GetNode<EntryListElement>("%EntryList");
		TableEntryList.SelectionChanged += SelectEntry;

		SaveButton = GetNode<Button>("%SaveButton");
		SaveButton.Pressed += SaveTables;

		UpdateBreadcrumbs();
		UpdateTableSelector();
	}

	public void UpdateBreadcrumbs()
	{
		foreach(var c in BreadcrumbsHolder.GetChildren())
		{
			BreadcrumbsHolder.RemoveChild(c);
			c.QueueFree();
		}
		foreach(var c in Breadcrumbs)
		{
			Button button = new Button();
			button.Text = c.Name;
			BreadcrumbsHolder.AddChild(button);
		}
	}

	public void UpdateTableSelector()
	{
		TableSelector.Clear();
		TableSelectorLookup.Clear();
		int i = 0;
		foreach(var c in TableViewReference.TableList)
		{
			TableSelector.AddItem(c.Name, i);
			TableSelectorLookup[i] = c;
			i++;
		}
	}

	private void TableSelected(long index)
	{
		if (TableSelectorLookup.TryGetValue((int) index, out var table))
		{
			GotoTable(table, true, null);
		}
	}

	public void GotoTable(TableViewReference table, bool wipeCrumbs, int? entryID)
	{
		if(wipeCrumbs)
		{
			Breadcrumbs.Clear();
		}
		Breadcrumbs.Push(table);
		UpdateBreadcrumbs();

		SetTable(table);
	}

	private void SetTable(TableViewReference table)
	{
		CurrentTable = table;
		if (table.Type == TableViewReference.TableViewType.CustomView) return;

		TableRef = mods.GetTableMod(table.NameEnum);

		UpdateListCache();
		TableEntryList.GotoPage(0, true);
	}

	private void UpdateListCache()
	{
		TableEntryList.OrderedList = TableRef.GetRowList().OrderBy(r => r.Key).ToList(); // Good place to add any filters.
	}

	public void SelectEntry(uint? id)
	{
		if (id == CurrentEntryID) return;

		// Clear
		foreach (var child in EntryEditor.GetChildren())
		{
			child.QueueFree();
			EntryEditor.RemoveChild(child);
		}

		if (id == null || TableRef == null) return;

		TableStructure structure = TableStructure.GetStructure(TableRef.TableName);

		DataRow row = TableRef.GetRow(id.Value);

		foreach(var column in TableRef.schema)
		{
			if (column.Key == "UID") continue;
			var name = column.Key;
			var value = row.GetValue<object>(column.Key).ToString();
			structure.Columns.TryGetValue(name, out var columnStructure);
			EntryEditor.AddChild(CreateVariableCell(id.Value, TableRef, name, value, columnStructure));
		}
	}

	private Control CreateVariableCell(uint id, DataTable table, string name, string value, TableColumn type)
	{
		Control cell = EntryCell.Instantiate<Control>();
		Label varName = cell.GetNode<Label>("%VariableName");
		varName.Text = name;
		LineEdit edit = cell.GetNode<LineEdit>("%VariableEdit");
		edit.Text = value;
		edit.TextChanged += (string newText) =>
		{
			DataRow row = TableRef.GetRow(id);
			row.SetValueRaw(name, newText);
		};
		return cell;
	}

	public void SaveTables()
	{
		mods.SaveMods();
	}
}
