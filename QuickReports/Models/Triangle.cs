using QuickReports.Models.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickReports.Models
{
    internal class Triangle : AbstractFigure
    {
        public double SideLength { get; set; }
        public Point Center { get; set; }
        public double Angle { get; set; }

        // Конструктор треугольника
        public Triangle(double sideLength, Point center, double angle, Color fillColor, Color borderColor)
            : base(fillColor, borderColor)
        {
            SideLength = sideLength;
            Center = center;
            Angle = angle;
        }

        // Реализация метода отрисовки треугольника
        public override void Draw(Graphics graphics)
        {
            var height = (Math.Sqrt(3) / 2) * SideLength;
            var halfSide = SideLength / 2;
            var topPoint = new Point(Center.X, Center.Y - (int)(2 / 3.0 * height));
            var leftPoint = new Point(Center.X - (int)halfSide, Center.Y + (int)(1 / 3.0 * height));
            var rightPoint = new Point(Center.X + (int)halfSide, Center.Y + (int)(1 / 3.0 * height));

            Point[] points = { topPoint, leftPoint, rightPoint };

            // Использование кисти для заливки и ручки для окантовки
            using (var brush = new SolidBrush(FillColor))
            using (var pen = new Pen(BorderColor))
            {
                graphics.FillPolygon(brush, points);
                graphics.DrawPolygon(pen, points);
            }
        }

        // Реализация метода проверки точки внутри треугольника
        public override bool ContainsPoint(AbstractPoint point)
        {
            var height = (Math.Sqrt(3) / 2) * SideLength;
            var halfSide = SideLength / 2;

            var topPoint = new PointF(Center.X, Center.Y - (int)(2 / 3.0 * height));
            var leftPoint = new PointF(Center.X - (int)halfSide, Center.Y + (int)(1 / 3.0 * height));
            var rightPoint = new PointF(Center.X + (int)halfSide, Center.Y + (int)(1 / 3.0 * height));

            var area = 0.5 * (-leftPoint.Y * rightPoint.X + topPoint.Y * (-leftPoint.X + rightPoint.X) + topPoint.X * (leftPoint.Y - rightPoint.Y) + leftPoint.X * rightPoint.Y);
            var s = 1 / (2 * area) * (topPoint.Y * rightPoint.X - topPoint.X * rightPoint.Y + (rightPoint.Y - topPoint.Y) * point.X + (topPoint.X - rightPoint.X) * point.Y);
            var t = 1 / (2 * area) * (topPoint.X * leftPoint.Y - topPoint.Y * leftPoint.X + (topPoint.Y - leftPoint.Y) * point.X + (leftPoint.X - topPoint.X) * point.Y);

            return s >= 0 && t >= 0 && (s + t) <= 1;
        }
    }
}
