using demo123.Common;
using demo123.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo123.Manager
{
    public class UserMenuManager : DbContext<user_menu>
    {

        public List<MenuTree> GetTreeMenu()
        {
            List<MenuTree> _list = new List<MenuTree>();
            List<user_menu> user_Menus = CurrentDb.GetList(i => i.parent_id ==0);
            if (user_Menus.Count > 0)
            {
                foreach (var item in user_Menus)
                {
                    MenuTree menuTree = new MenuTree();
                    menuTree.title = item.um_title;
                    menuTree.id = Convert.ToString(item.um_id);
                    menuTree.key = $"{user_Menus.IndexOf(item)}";
                    _list.Add(menuTree);
                }

                foreach (var item in _list)
                {
                    List<user_menu> _Menus = CurrentDb.GetList(i => i.parent_id == Convert.ToInt32(item.id));
                    if (_Menus.Count > 0)
                    {
                        List<MenuTree> menuTrees = new List<MenuTree>();
                        foreach (var _item in _Menus)
                        {
                            MenuTree menuTree = new MenuTree();
                            menuTree.id =Convert.ToString(_item.um_id);
                            menuTree.title = _item.um_title;
                            menuTree.key = $"{item.key}-{_Menus.IndexOf(_item)}";
                            menuTrees.Add(menuTree);
                        }
                        item.children = menuTrees;
                    }
                }
            }
            return _list;
        }
    }
}
