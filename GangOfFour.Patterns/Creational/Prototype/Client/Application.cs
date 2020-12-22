using GangOfFour.Patterns.Creational.Prototype.Prototypes;
using GangOfFour.Patterns.Creational.Prototype.Stuff;
using Shouldly;
using System.Collections.Generic;
using Xunit;

namespace GangOfFour.Patterns.Creational.Prototype.Client
{
    public class Application
    {
        [Theory]
        [MemberData(nameof(InjectDependencies))]
        public void ExamplePrototypePattern(IFolder chessFolder, IFolder backupFolder, IEnumerable<AbstractTextFile> files)
        {
            chessFolder.Files = (List<AbstractTextFile>)files;
            chessFolder.CopyTo(backupFolder);

            chessFolder.Files.Count.ShouldBe(2);
            backupFolder.Files.Count.ShouldBe(2);

            chessFolder.Files.ForEach(file => file.FolderPath.ShouldBe("C:\\Chess\\"));
            backupFolder.Files.ForEach(file => file.FolderPath.ShouldBe("C:\\Backup\\"));
        }

        public static IEnumerable<object[]> InjectDependencies()
        {
            // Create folder structure
            var root = new Folder("C:", null);
            var chessFolder = new Folder("Chess", root);
            var backupFolder = new Folder("Backup", root);

            root.Folders.Add(chessFolder);
            root.Folders.Add(backupFolder);

            // Create files
            var kasparov = new MicrosoftWordTextFile("Garry Kasparov", ".docx", chessFolder.Path, "Kasparov is the best attacker player", TextColors.Blue);
            var karpov = new NotepadPlusTextFile("Anatoly Karpov", ".txt", chessFolder.Path, "Karpov is the best positional player");

            return new List<object[]>
            {
                new object[] { chessFolder, backupFolder, new List<AbstractTextFile> { kasparov, karpov } }
            };
        }
    }
}
