using GangOfFour.Patterns.Creational.Prototype.Prototypes;
using System.Collections.Generic;
using System.Text;

namespace GangOfFour.Patterns.Creational.Prototype.Client
{
    /// <summary>
    /// Client Code
    /// </summary>
    public class Folder : IFolder
    {
        public string Name { get; set; }

        public Folder ParentFolder { get; set; }

        public List<Folder> Folders { get; set; } = new List<Folder>();

        public List<AbstractTextFile> Files { get; set; } = new List<AbstractTextFile>();

        public Folder(string name, Folder parent)
        {
            Name = name;
            ParentFolder = parent;
        }

        public string Path
        {
            get
            {
                var folderNames = new Stack<string>();
                folderNames.Push(Name);
                LoopParentFoldersRecursively(folderNames);
                var path = new StringBuilder();
                PopFolderNamesRecursively(path, folderNames);
                return path.ToString();
            }
        }

        public void CopyTo(IFolder target)
        {
            Files.ForEach(file =>
            {
                var copy = file.Clone();
                copy.FolderPath = target.Path;
                target.Files.Add(copy);
            });
        }

        private void LoopParentFoldersRecursively(Stack<string> folderNames)
        {
            var parent = ParentFolder;
            while (parent != null)
            {
                folderNames.Push(parent.Name);
                parent = parent.ParentFolder;
            }
        }

        private void PopFolderNamesRecursively(StringBuilder path, Stack<string> folderNames)
        {
            while (folderNames.Count > 0)
            {
                path.Append(folderNames.Pop());
                path.Append("\\");
            }
        }
    }
}
