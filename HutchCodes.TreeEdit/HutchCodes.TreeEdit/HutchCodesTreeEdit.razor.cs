using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace HutchCodes.TreeEdit
{
    public partial class HutchCodesTreeEdit
    {
        [Parameter]
        public IList<ITreeItem> Nodes { get; set; }


    }
}
