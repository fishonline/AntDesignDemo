using System;
using System.Collections.Generic;

namespace AntDesignDemo.Data
{
    public class MenuModel
    {
        public string Key { get; set; } = Guid.NewGuid().ToString();
        public string Label { get; set; }
        public string Icon { get; set; }
        public string Link { get; set; }
        public IList<MenuModel> Children { get; set; } = new List<MenuModel>();
    }
}