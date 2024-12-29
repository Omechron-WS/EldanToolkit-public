using Godot;
using System.IO;

namespace EldanToolkit.Project
{
    public partial class Project : Node
    {
        public ProjectFileSystem FileSystem {  get; private set; }
        public TableManager TableManager { get; private set; }
        public TableModManager TableMods { get; private set; }
        //public TableModManager TableModWIP { get; private set; }
        public LogSystem LogSystem { get; private set; }

        public string ProjectPath { get; private set; }

        private Project()
		{
			FileSystem = new ProjectFileSystem(this);
			TableManager = new TableManager(this);
            TableMods = new TableModManager(this, TableManager);
            //TableModWIP = new TableModManager(this, TableMods);
			LogSystem = new LogSystem(this);
        }

        public void Save()
        {
        }

        public static Project NewProject(string path)
        {
            Project proj = new Project();
            if (proj._NewProject(path))
            {
                return proj;
            }
            return null;
        }

        private bool _NewProject(string path)
        {
            ProjectPath = path;

            FileSystem.projectPath = path;
            FileSystem.MakeFolders();

            Save();
            return true;
        }

        public static Project LoadProject(string path)
        {
            Project proj = new Project();
            if (proj._LoadProject(path))
            {
                return proj;
            }
            return null;
        }

        private bool _LoadProject(string path)
        {
            ProjectPath = path;

            if (!Directory.Exists(ProjectPath))
                return false;

            FileSystem.projectPath = path;
			FileSystem.MakeFolders();

			return true;
        }

        public void ConvertFiles()
        {
            FileSystem.ConvertFiles();
        }

        public void ConvertAndCompile()
        {
            FileSystem.CompileProject();
        }
    }
}
