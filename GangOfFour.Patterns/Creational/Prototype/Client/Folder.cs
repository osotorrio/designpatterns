using GangOfFour.Patterns.Creational.Prototype.Prototypes;
using System.Collections.Generic;
using System.Text;

namespace GangOfFour.Patterns.Creational.Prototype.Client
{
    public class Folder
    {
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

                var parent = ParentFolder;
                while (parent != null)
                {
                    FolderNames.Push(parent.Name);
                    parent = parent.ParentFolder;
                }

                var path = new StringBuilder();

                while (FolderNames.Count > 0)
                {
                    path.Append(FolderNames.Pop());
                    path.Append("\\");
                }

                return path.ToString();
            }
        }

        private Stack<string> FolderNames;
    }
}
