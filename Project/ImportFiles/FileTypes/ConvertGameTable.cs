using System.IO;
using System.Xml.Serialization;

namespace EldanToolkit.Project.ImportFiles.FileTypes
{
	[XmlType("GameTable")]
	public class GameTableData : ConvertData
	{
		public override string[] Import(string source, string dest, Project project)
		{
			string DBPath = Path.GetDirectoryName(source);
			string destPath = Path.GetDirectoryName(dest);
			Directory.CreateDirectory(destPath);

			return ProjectHolder.CurrentProject.TableMods.ExportMods(destPath);
		}
	}
}
