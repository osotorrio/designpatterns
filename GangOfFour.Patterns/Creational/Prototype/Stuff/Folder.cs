using System.Collections.Generic;
using System.Text;

namespace GangOfFour.Patterns.Creational.Prototype.Stuff
{
    public class Folder
    {
        public string Name { get; set; }

        public Folder Parent { get; set; }

        public List<Folder> Childs { get; set; }

        public Folder(string name)
        {
            Name = name;
            Childs = new List<Folder>();
        }

        public string Path
        {
            get
            {
                FolderNames = new Stack<string>();
                FolderNames.Push(Name);

                var parent = Parent;
                while (parent != null)
                {
                    FolderNames.Push(parent.Name);
                    parent = parent.Parent;
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
