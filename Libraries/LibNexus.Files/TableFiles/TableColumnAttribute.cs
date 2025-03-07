using System;

namespace EldanToolkit.Libraries.LibNexus.Files.TableFiles;

[AttributeUsage(AttributeTargets.Property)]
public sealed class TableColumnAttribute : Attribute
{
	public string Name { get; }

	public TableColumnAttribute(string name)
	{
		Name = name;
	}
}
