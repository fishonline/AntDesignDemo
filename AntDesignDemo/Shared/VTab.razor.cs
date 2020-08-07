using AntDesignDemo.Data;
using Microsoft.AspNetCore.Components;
using System.Collections.ObjectModel;

namespace AntDesignDemo.Shared
{
    public partial class VTab : ComponentBase
    {
        [Parameter]
        public ObservableCollection<TabModel> DataSource { get; set; }
    }
}