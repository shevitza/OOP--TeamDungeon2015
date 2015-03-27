using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WDproject.Models;

namespace WDproject.Interfaces
{
    interface IArticle        
    {
        string Name { get; set; }
        string Area { get; set; }
        Cross CrossType { get; set; }
        int ProductionDuration { get; set; }
        int InstallDuration { get; set; }
    }
}
