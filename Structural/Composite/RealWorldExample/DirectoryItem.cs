using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Structural.Composite.RealWorldExample
{
    // Composite
    public class DirectoryItem : FileSystemItem
    {
        public List<FileSystemItem> Items { get; } = new List<FileSystemItem>();

        public DirectoryItem(string name) : base(name)
        {
        }

        public void Add(FileSystemItem component)
        {
            Items.Add(component);
        }

        public void Remove(FileSystemItem component)
        {
            Items.Remove(component);
        }

        public override decimal GetSizeInKB()
        {
            return Items.Sum(x => x.GetSizeInKB());
        }
    }
}
