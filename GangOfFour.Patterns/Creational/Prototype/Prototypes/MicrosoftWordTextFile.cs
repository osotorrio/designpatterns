using GangOfFour.Patterns.Creational.Prototype.Stuff;

namespace GangOfFour.Patterns.Creational.Prototype.Prototypes
{
    public class MicrosoftWordTextFile : AbstractTextFile
    {
        public TextColors TextColor { get; set; }

        public MicrosoftWordTextFile(string name, string extension, string location, string content, TextColors textColor) :
            base(name, extension, location, content)
        {
            TextColor = textColor;
        }

        public override AbstractTextFile Clone()
        {
            return new MicrosoftWordTextFile(FileName, FileExtension, FolderPath, Content, TextColor);
        }
    }
}
