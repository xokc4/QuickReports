using QuickReports.Models.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickReports.Models
{
    internal abstract class AbstractFigure : IContainsPoint, IDrawable
    {
        // Свойства для цвета заливки и окантовки
        public Color FillColor { get; set; }
        public Color BorderColor { get; set; }

        // Конструктор, принимающий цвета заливки и окантовки
        protected AbstractFigure(Color fillColor, Color borderColor)
        {
            FillColor = fillColor;
            BorderColor = borderColor;
        }

        // Абстрактные методы для отрисовки и проверки точки внутри фигуры
        public abstract void Draw(Graphics graphics);
        public abstract bool ContainsPoint(AbstractPoint point);
    }
}
