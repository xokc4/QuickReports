using QuickReports.Models.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickReports.Models
{
    public class ConcretePoint : AbstractPoint
    {
        public override int X { get; set; }
        public override int Y { get; set; }

        public ConcretePoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public ConcretePoint()
        {
        }

        public override void Draw(Graphics graphics)
        {
            int size = 10; // Размер точки
            graphics.FillRectangle(Brushes.Black, X - size / 2, Y - size / 2, size, size);
        }
    }
}
