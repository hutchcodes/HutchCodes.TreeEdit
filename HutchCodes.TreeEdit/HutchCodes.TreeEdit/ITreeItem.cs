using System;
using System.Collections.Generic;
using System.Text;

namespace HutchCodes.TreeEdit
{
    public interface ITreeItem
    {
        string Text { get;}
        string Href { get; }
        string IconClass { get; }
        bool IsExpanded { get; set; }
        bool CanDrag { get; }
        bool CanDrop(ITreeItem treeItem);

        IList<ITreeItem> Nodes { get; }
        IEnumerable<ITreeItemCommand> TreeItemCommands { get; }
    }
}
