using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickReports.Models.service
{
    public abstract class AbstractPoint : IDrawable
    {
        public abstract int X { get; set; }
        public abstract int Y { get; set; }

        public abstract void Draw(Graphics graphics);
    }
}
