using CookBook.App.Common;
using CookBook.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.App.Concrete
{
    public class MenuActionService : BaseService<MenuAction>
    {
        public List<MenuAction> GetMenuActionsByMenuName(string menuName)
        {
            List<MenuAction> results = new List<MenuAction>();
            foreach (var menuAction in Recipes)
            {
                if (menuAction.MenuName == menuName)
                {
                    results.Add(menuAction);
                }
            }

            return results;
        }
    }
}
