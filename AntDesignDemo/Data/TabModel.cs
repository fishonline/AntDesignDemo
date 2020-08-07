using Microsoft.AspNetCore.Components;

namespace AntDesignDemo.Data
{
    public class TabModel
    {
        public string Key { get; set; }
        public string Label { get; set; }
        public RenderFragment Content { get; set; }
    }
}