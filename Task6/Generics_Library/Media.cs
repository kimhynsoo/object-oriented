using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics_Library
{
    public interface Media
    {
        public string Title { get; set; }
        public string Publisher { get; set; }

        public void display_info();
    }
}
   