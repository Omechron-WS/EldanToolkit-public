using EldanToolkit.Project.ImportFiles;
using Godot;
using System.Xml.Serialization;

namespace EldanToolkit.Project.ImportFiles.FileTypes
{
	[XmlType("PNG2TEX")]
	public class CovnertPNG2TEX : ConvertData
	{
		[XmlAttribute("Depth")]
		public int depth = 1; // for LUTs and 3D textures
		[XmlAttribute("Mipmaps")]
		public int mipmaps = 1;

		public enum TexType
		{
			JPG1,
			JPG2,
			JPG3,
			ARGB1,
			ARGB2,
			RGB,
			GRAYSCALE,
			DXT1,
			DXT3,
			DXT5,
		}
		[XmlAttribute("TexType")]
		public TexType texType = TexType.DXT3;

		public override string[] Import(string source, string dest, Project project)
		{
			string srcfile = source.GetBaseName();
			if (srcfile.GetExtension().ToLower() != "tex")
			{
				return null;
			}
			NexusVaultWrapper.DoConvert(srcfile.GetBaseName() + ".png", dest, $"--png2tex-mipmaps {mipmaps}", $"--png2tex-depth {depth}", $"--png2tex-type {texType.ToString()}");
			return [dest];
		}
	}
}
