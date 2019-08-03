using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo123.Common
{
    public class MenuTree
    {
        public string title { get; set; }
        public string key { get; set; }
        public string id { get;  set; }
        public List<MenuTree>children { get; set; }
    }
}
