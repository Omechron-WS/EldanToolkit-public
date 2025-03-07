using EldanToolkit.Project.ImportFiles.FileTypes;
using EldanToolkit.Shared;
using Godot;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;

namespace EldanToolkit.Project.ImportFiles
{
	[XmlRoot("ImportFile")]
	public class ImportFile
	{
		[XmlIgnore]
		public string FilePath;

		public static ImportFile Load(string path)
		{
			using var reader = XmlReader.Create(path);
			XmlSerializer serializer = new XmlSerializer(typeof(ImportFile), TypeList());
			ImportFile file = (ImportFile)serializer.Deserialize(reader);
			file.FilePath = path;
			return file;
		}

		public static void Save(string path, ImportFile file)
		{
			XmlWriterSettings settings = new XmlWriterSettings { Indent = true };
			using var writer = XmlWriter.Create(path, settings);
			XmlSerializer serializer = new XmlSerializer(typeof(ImportFile), TypeList());
			serializer.Serialize(writer, file);
		}

		public static Type[] TypeList()
		{
			// use reflection to get all derived types
			return Assembly.GetExecutingAssembly().GetTypes().Where(
				t => typeof(ConvertData).IsAssignableFrom(t)).ToArray();
		}

		public bool NeedsConversion(string source, string dest)
		{
			return true;
		}

		public string[] Import(string dest, bool forceConvert, Project project)
		{
			if (convertData != null)
			{
				return convertData.Import(FilePath, dest, project);
			}
			return null;
		}

		[XmlElement("ConvertData")]
		public ConvertData convertData = null;

		public enum TargetArchive
		{
			Client64,
			ClientData,
			ClientDataDE,
			ClientDataEN,
			ClientDataFR
		}

		[XmlAttribute("Archive")]
		public TargetArchive targetArchive = TargetArchive.ClientData;
	}

	[XmlType("ConvertData")]
	public abstract class ConvertData
	{
		public abstract string[] Import(string source, string dest, Project project);
	}
}