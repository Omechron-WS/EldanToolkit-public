﻿using EldanToolkit.Project;
using Godot;

public partial class ProjectFileManager : Control
{
    [Export]
    public ProjectFileSystemView FileView;

    [Export]
    public Container SidebarContainer;

    private Control ArchivePathWarning = null;
    private Button AddToProject = null;
    private Button RemoveFromProject = null;
    private Button LoadModel = null;

    private ProjectFileSystem pfs { get { return ProjectHolder.project?.FileSystem; } }

    public override void _Ready()
    {
        base._Ready();
        FileView.SelectedFileChanged += OnSelectedFileChanged;

        ArchivePathWarning = GetNode<Control>("%ArchivePathWarning");

        AddToProject = GetNode<Button>("%AddToProject");
        AddToProject.Connect("pressed", Callable.From(() => {
            if (FileView.selectedFile != null)
            {
                pfs?.AddtoProject(FileView.selectedFilePath);
                FileView.Refresh();
            }
        }));

        RemoveFromProject = GetNode<Button>("%RemoveFromProject");
        RemoveFromProject.Connect("pressed", Callable.From(() => {
            if (FileView.selectedFile != null)
            {
                pfs?.RemoveFromProject(FileView.selectedFilePath);
                FileView.Refresh();
            }
        }));

        LoadModel = GetNode<Button>("%LoadModel");
        LoadModel.Connect("pressed", Callable.From(() => {
            if (FileView.selectedFile != null)
            {
                pfs?.LoadModel(FileView.selectedFilePath);
                FileView.Refresh();
            }
        }));
        SetButtons();
    }

    public void OnSelectedFileChanged(string filename, string folder, string importFile)
    {
        SetButtons();
    }

    protected void SetButtons()
    {
        ArchivePathWarning.Visible = false;
        AddToProject.Visible = false;
        RemoveFromProject.Visible = false;
        LoadModel.Visible = false;

        if (FileView.selectedFile != null)
        {
            if (FileView.selectedFile != null && pfs.IsInProject(FileView.selectedFilePath))
            {
                RemoveFromProject.Visible = true;
                LoadModel.Visible = true;
            }
            else
            {
                AddToProject.Visible = true;
            }
        }

        if (ProgramSettings.ArchivePath == null)
        {
            ArchivePathWarning.Visible = true;
        }
    }
}