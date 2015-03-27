using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDproject.Interfaces
{
    interface IDoor:IArticle
    {
        string LockingSystem { get; set; }
    }
}
