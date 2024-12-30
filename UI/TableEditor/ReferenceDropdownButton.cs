using EldanToolkit.Shared;
using Godot;
using System;

public partial class ReferenceDropdownButton : Button
{
	[Export]
	public PackedScene DropdownScene;

	[Export]
	public Vector2I DropdownSize = new Vector2I(600, 800);

	TableDataSet set;
	GameTableName tableName;

	private ReferenceDropdownList dropdown;
	public delegate void EntrySelectedEventHandler(uint? id);
	public EntrySelectedEventHandler EntrySelected;

	public override void _Ready()
	{
		Pressed += CreateDropdown;
	}

	public void LoadData(TableDataSet set, GameTableName tableName)
	{
		this.set = set;
		this.tableName = tableName;
	}

	private void CreateDropdown()
	{
		if (ButtonPressed)
		{
			float extra = DropdownSize.X - Size.X;
			dropdown = DropdownScene.Instantiate<ReferenceDropdownList>();
			dropdown.Position = (Vector2I) (GetScreenPosition() + new Vector2(-extra / 2, Size.Y));
			dropdown.Size = DropdownSize;
			dropdown.FocusExited += Uncheck;
			dropdown.parent = this;
			GetTree().Root.AddChild(dropdown);
			dropdown.Show();
			dropdown.LoadData(set, tableName);
		}
		else
		{
			if (dropdown != null)
			{
				dropdown.Close();
				dropdown = null;
			}
		}
	}

	private void Uncheck()
	{
		ButtonPressed = false;
	}
}
