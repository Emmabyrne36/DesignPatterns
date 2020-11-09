namespace DesignPatterns.Structural.Composite.RealWorldExample
{
    // Component 
    public abstract class FileSystemItem
    {
        public string Name { get; set; }
        protected FileSystemItem(string name)
        {
            Name = name;
        }

        public abstract decimal GetSizeInKB();
    }
}
