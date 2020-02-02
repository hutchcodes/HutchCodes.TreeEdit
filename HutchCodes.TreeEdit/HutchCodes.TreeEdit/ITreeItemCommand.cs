using System;
using System.Collections.Generic;
using System.Text;

namespace HutchCodes.TreeEdit
{
    public interface ITreeItemCommand
    {
        string IconClass { get; set; }
        string ToolTip { get; set; }
        Action Command { get; }
    }
}
