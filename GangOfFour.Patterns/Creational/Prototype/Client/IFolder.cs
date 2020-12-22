using GangOfFour.Patterns.Creational.Prototype.Prototypes;
using System.Collections.Generic;

namespace GangOfFour.Patterns.Creational.Prototype.Client
{
    public interface IFolder
    {
        string Name { get; set; }

        Folder ParentFolder { get; set; }

        List<Folder> Folders { get; set; }

        List<AbstractTextFile> Files { get; set; }

        string Path { get; }

        void CopyTo(Folder target);
    }
}