using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickReports.Models.service
{
    internal interface IContainsPoint
    {
        bool ContainsPoint(AbstractPoint point);
    }
}
