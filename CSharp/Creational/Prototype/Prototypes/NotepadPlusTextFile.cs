namespace GangOfFour.Patterns.Creational.Prototype.Prototypes
{
    /// <summary>
    /// Concrete Prototype
    /// </summary>
    public class NotepadPlusTextFile : AbstractTextFile
    {
        public NotepadPlusTextFile(string name, string extension, string location, string content)
            : base(name, extension, location, content)
        { }

        public override AbstractTextFile Clone()
        {
            return new NotepadPlusTextFile(FileName, FileExtension, FolderPath, Content);
        }
    }
}
