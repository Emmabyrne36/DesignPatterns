namespace DesignPatterns.Structural.Composite.RealWorldExample
{
    // Leaf
    public class FileItem : FileSystemItem
    {
        public long FileBytes { get; }

        public FileItem(string name, long fileBytes) : base(name)
        {
            FileBytes = fileBytes;
        }

        public override decimal GetSizeInKB()
        {
            return decimal.Divide(FileBytes, 1000);
        }
    }
}
