using AntDesign;
using AntDesignDemo.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace AntDesignDemo.Shared
{
    public partial class MainLayout : LayoutComponentBase
    {
        private bool Collapsed { get; set; }

        private ObservableCollection<TabModel> Tabs { get; set; } = new ObservableCollection<TabModel>();

        private IList<MenuModel> Menus { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }

        protected override void OnInitialized()
        {
            Menus = new List<MenuModel>
            {
                new MenuModel
                {
                    Label = "基础数据",
                    Icon = "desktop",
                    Children = new List<MenuModel>
                    {
                        new MenuModel
                        {
                            Label = "主数据",
                            Children = new List<MenuModel>
                            {
                                new MenuModel
                                {
                                    Label = "物料",
                                    Link = "/page1"
                                },
                                new MenuModel
                                {
                                    Label = "物料列表",
                                    Link = "/page2"
                                }
                            }
                        },
                        new MenuModel
                        {
                            Label = "公共资料",
                            Children = new List<MenuModel>
                            {
                                new MenuModel
                                {
                                    Label = "薪资",
                                    Link = "/page3"
                                },
                                new MenuModel
                                {
                                    Label = "业务员列表",
                                    Link = "/page4"
                                }
                            }
                        },
                        new MenuModel
                        {
                            Label = "单据类型",
                            Children = new List<MenuModel>
                            {
                                new MenuModel
                                {
                                    Label = "单据类型",
                                    Link = "/page5"
                                },
                                new MenuModel
                                {
                                    Label = "单据类型列表",
                                    Link = "/page6"
                                }
                            }
                        },
                        new MenuModel
                        {
                            Label = "编码规则",
                            Children = new List<MenuModel>
                            {
                                new MenuModel
                                {
                                    Label = "编码规则",
                                    Link = "/page7"
                                },
                                new MenuModel
                                {
                                    Label = "编码规则列表",
                                    Link = "/page8"
                                }
                            }
                        }
                    }
                },
                new MenuModel
                {
                    Label = "仓库列表",
                    Icon = "desktop",
                    Link = "/page9"
                },
                new MenuModel
                {
                    Label = "银行",
                    Icon = "desktop",
                    Link = "/page10"
                },
                new MenuModel
                {
                    Label = "内部帐号",
                    Icon = "desktop",
                    Link = "/page11"
                },
                new MenuModel
                {
                    Label = "现金帐号",
                    Icon = "desktop",
                    Link = "/page12"
                }
            };

            NavigationManager.LocationChanged -= NavigationManager_LocationChanged;
            NavigationManager.LocationChanged += NavigationManager_LocationChanged;
        }

        private void NavigationManager_LocationChanged(object sender, LocationChangedEventArgs e)
        {
            AddTab(new Uri(e.Location).LocalPath);
        }

        protected override void OnAfterRender(bool firstRender)
        {
            AddTab(new Uri(NavigationManager.Uri).LocalPath);
        }

        private void AddTab(string path)
        {
            var activeTab = Tabs.FirstOrDefault(x => x.Key == path);
            if (activeTab == null)
            {
                Tabs.Add(new TabModel
                {
                    Key = path
                });
            }
            //_panes.Add(new TabPane(
            //    key: path,
            //    tab: (b) => b.AddContent(0, $"Tab {path}"),
            //    childContent: (b) => b.AddContent(0, $"Content of Tab Pane {path}")
            //));

            //StateHasChanged();
        }
    }
}