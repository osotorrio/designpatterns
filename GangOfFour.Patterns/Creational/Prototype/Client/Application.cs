using GangOfFour.Patterns.Creational.Prototype.Prototypes;
using GangOfFour.Patterns.Creational.Prototype.Stuff;
using Shouldly;
using Xunit;

namespace GangOfFour.Patterns.Creational.Prototype.Client
{
    public class Application
    {
        [Fact]
        public void ExamplePrototypePattern()
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

            // Add files to chess folder
            chessFolder.Files.Add(kasparov);
            chessFolder.Files.Add(karpov);

            // Copy files from chess folder to backup folder
            chessFolder.CopyTo(backupFolder);

            // Assert
            chessFolder.Files.ForEach(file => file.FolderPath.ShouldBe("C:\\Chess\\"));
            backupFolder.Files.ForEach(file => file.FolderPath.ShouldBe("C:\\Backup\\"));
        }
    }
}
