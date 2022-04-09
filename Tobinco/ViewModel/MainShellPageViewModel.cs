using System;
using System.Collections.ObjectModel;
using Tobinco.DatabbaseServices;
using Tobinco.Model;

namespace Tobinco.ViewModel
{
    public class MainShellPageViewModel
    {

        public MainShellPageViewModel()
        {
            MenuList = GetMenus();
        }
       
        private ObservableCollection<MainMenuList> menuList;

        public ObservableCollection<MainMenuList> MenuList
        {
            get { return menuList; }
            set { menuList = value; }
        }
        private ObservableCollection<MainMenuList> GetMenus()
        {
            return new ObservableCollection<MainMenuList>
            {
                new MainMenuList { Icon = "order.png", Name = "List of Doctors"},
                new MainMenuList { Icon = "favorite.png", Name = "Hospitals Visited"},
                new MainMenuList { Icon = "shopping.png", Name = "Planned Schedule"},
                new MainMenuList { Icon = "settings.png", Name = "Activity Tracker"}
            };
        }
    }
}
