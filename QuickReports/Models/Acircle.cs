using QuickReports.Models.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickReports.Models
{
    internal class Acircle : AbstractFigure
    {
        public double Radius { get; set; }
        public Point Center { get; set; }

        // Конструктор круга, добавляющий цвета заливки и окантовки
        public Acircle(double radius, Point center, Color fillColor, Color borderColor)
            : base(fillColor, borderColor)
        {
            Radius = radius;
            Center = center;
        }

        // Реализация метода отрисовки круга
        public override void Draw(Graphics graphics)
        {
            using (var brush = new SolidBrush(FillColor))
            using (var pen = new Pen(BorderColor))
            {
                graphics.FillEllipse(brush, (float)(Center.X - Radius), (float)(Center.Y - Radius), (float)(2 * Radius), (float)(2 * Radius));
                graphics.DrawEllipse(pen, (float)(Center.X - Radius), (float)(Center.Y - Radius), (float)(2 * Radius), (float)(2 * Radius));
            }
        }

        // Реализация метода проверки точки внутри круга
        public override bool ContainsPoint(AbstractPoint point)
        {
            double distance = Math.Sqrt(Math.Pow(point.X - Center.X, 2) + Math.Pow(point.Y - Center.Y, 2));
            return distance <= Radius;
        }
    }
}
