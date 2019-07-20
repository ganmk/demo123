using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo123.Common
{
    public class ResponseBaseModel
    {
        public int totalCount { get; set; }
        public int currentIndex { get; set; }
        public int pageCount { get; set; }
        public dynamic Data { get; set; }
    }
}
