using EldanToolkit.Project.ImportFiles;
using Godot;
using System.IO;
using System.Xml.Serialization;

namespace EldanToolkit.Project.ImportFiles.FileTypes
{
	[XmlType("CopyFile")]
	public class ConvertCopyFile : ConvertData
	{
		public override string[] Import(string source, string dest, Project project)
		{
			Directory.CreateDirectory(dest.GetBaseDir());
			File.Copy(source.GetBaseName(), dest, true); // includes path, excludes .import
			return [dest];
		}
	}
}
