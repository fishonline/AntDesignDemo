using AntDesignDemo.Data;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace AntDesignDemo.Shared
{
    public partial class VMenu : ComponentBase
    {
        [Parameter]
        public IList<MenuModel> Menus { get; set; }
    }
}