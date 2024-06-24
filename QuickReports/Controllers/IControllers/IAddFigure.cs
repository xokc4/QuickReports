using QuickReports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickReports.Controllers.IControllers
{
    internal interface IAddFigure
    {
        public void AddFigure(AbstractFigure figure);
    }
}
