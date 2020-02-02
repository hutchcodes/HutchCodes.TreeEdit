using System;
using System.Collections.Generic;
using System.Text;

namespace HutchCodes.TreeEdit
{
    public class SimpleTreeItem : ITreeItem
    {
        public string Text { get ; set; }
        public string Href { get; set; }
        public string IconClass { get; set; }
        public bool IsExpanded { get; set; }

        public bool CanDrag => false;

        public IList<ITreeItem> Nodes { get; set; } = new List<ITreeItem>();

        public IEnumerable<ITreeItemCommand> TreeItemCommands => new List<ITreeItemCommand>();

        public bool CanDrop(ITreeItem treeItem)
        {
            return false;
        }
    }
}
