using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFood.Models;

namespace WebFood.Interfaces
{
   public interface IStore
    {
        List<Menu> GetSpecialMenuList();
        List<Menu> GetFullMenuList();

    }
}
