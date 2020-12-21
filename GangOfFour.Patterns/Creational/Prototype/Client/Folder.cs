using GangOfFour.Patterns.Creational.Prototype.Prototypes;
using System.Collections.Generic;
using System.Text;

namespace GangOfFour.Patterns.Creational.Prototype.Client
{
    public class Folder
    {
        private Stack<string> FolderNames;

        public string Name { get; set; }

        public List<AbstractTextFile> Files { get; set; }

        public Folder ParentFolder { get; set; }

        public List<Folder> Folders { get; set; }


        public Folder(string name, Folder parent)
        {
            Name = name;
            ParentFolder = parent;
            Files = new List<AbstractTextFile>();
            Folders = new List<Folder>();
        }

        public string Path
        {
            get
            {
                FolderNames = new Stack<string>();
                FolderNames.Push(Name);
                LoopParentFoldersRecursively();
                var path = new StringBuilder();
                PopFolderNamesRecursively(path);
                return path.ToString();
            }
        }

        private void LoopParentFoldersRecursively()
        {
            var parent = ParentFolder;
            while (parent != null)
            {
                FolderNames.Push(parent.Name);
                parent = parent.ParentFolder;
            }
        }

        private void PopFolderNamesRecursively(StringBuilder path)
        {
            while (FolderNames.Count > 0)
            {
                path.Append(FolderNames.Pop());
                path.Append("\\");
            }
        }
    }
}
