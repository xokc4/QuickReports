using QuickReports.Models.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickReports.Models
{
    internal class RectangleFigur : AbstractFigure
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Point Location { get; set; }

        // Конструктор прямоугольника
        public RectangleFigur(double width, double height, Point location, Color fillColor, Color borderColor)
            : base(fillColor, borderColor)
        {
            Width = width;
            Height = height;
            Location = location;
        }

        // Реализация метода отрисовки прямоугольника
        public override void Draw(Graphics graphics)
        {
            // Использование кисти для заливки и ручки для окантовки
            using (var brush = new SolidBrush(FillColor))
            using (var pen = new Pen(BorderColor))
            {
                graphics.FillRectangle(brush, Location.X, Location.Y, (float)Width, (float)Height);
                graphics.DrawRectangle(pen, Location.X, Location.Y, (float)Width, (float)Height);
            }
        }

        // Реализация метода проверки точки внутри прямоугольника
        public override bool ContainsPoint(AbstractPoint point)
        {
            return point.X >= Location.X && point.X <= Location.X + Width &&
                   point.Y >= Location.Y && point.Y <= Location.Y + Height;
        }
    }
}
