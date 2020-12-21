namespace GangOfFour.Patterns.Creational.Prototype.Prototypes
{
    /// <summary>
    /// Abstract Prototype
    /// </summary>
    public abstract class AbstractTextFile
    {
        public string FileName { get; set; }

        public string FileExtension { get; set; }

        public string FolderPath { get; set; }

        public string Content { get; set; }

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
