using EldanToolkit.Shared;
using System;

namespace EldanToolkit.Project
{
    public static class Events
    {
        public delegate void FileSystemLoadedEventHandler();
		public static FileSystemLoadedEventHandler FileSystemChanged;

		public delegate void RecentProjectsUpdatedEventHandler();
		public static RecentProjectsUpdatedEventHandler RecentProjectsUpdated;

		public delegate void TableEntryChangedEventHandler(GameTableName tableName, uint uid);
		public static TableEntryChangedEventHandler TableEntryChanged;

	}
}
