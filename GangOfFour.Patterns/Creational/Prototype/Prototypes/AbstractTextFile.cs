namespace GangOfFour.Patterns.Creational.Prototype.Prototypes
{
    public abstract class AbstractTextFile
    {

        public string FileName { get; }

        public string FileExtension { get; }

        public string FolderPath { get; }

        public string Content { get; }

        public AbstractTextFile(string name, string extension, string location, string content)
        {
            FileName = name;
            FileExtension = extension;
            FolderPath = location;
            Content = content;
        }

        public abstract AbstractTextFile Clone();
    }
}
