using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace HutchCodes.TreeEdit
{
    public partial class HutchCodesTreeEditItem
    {
        [Parameter]
        public ITreeItem Node { get; set; }

        private void ToggleExpandCollapse()
        {
            Node.IsExpanded = !Node.IsExpanded;
        }
    }
}
