using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Namespace
{
    public partial class ComponentName
    {
        [Parameter] public RenderFragment ChildContent { get; set; }
    }
}
