using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickReports.Controllers.IControllers
{
    internal interface ICreateNewPoint
    {
        public bool CreateNewPoint(int x, int y);
    }
}
