using QuickReports.Controllers.IControllers;
using QuickReports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickReports.Controllers
{
    internal class GraphicPrimitiveControl : Control, IRemoveLastPoint, ICheckPointInFigures, ICreateNewPoint, IAddFigure
    {
        private List<AbstractFigure> figures = new List<AbstractFigure>();
        private List<ConcretePoint> points = new List<ConcretePoint>(); // Список для хранения точек

        public void AddFigure(AbstractFigure figure)
        {
            figures.Add(figure);
            Invalidate();
        }

        public bool CreateNewPoint(int x, int y)
        {
            if (points.Count >= 1)
            {
                return false;
            }
            else
            {
                // Создаем новую точку
                ConcretePoint newPoint = new ConcretePoint(x, y);
                points.Add(newPoint); // Добавляем точку в список точек

                Invalidate(); // Перерисовать
                return true;
            }
        }
        public bool CheckPointInFigures()
        {
            foreach (var figure in figures)
            {
                if (figure.ContainsPoint(points[0]))
                {
                    return true;
                }
            }
            return false;
        }
        public bool RemoveLastPoint()
        {

            if (points.Count > 0)
            {
                points.RemoveAt(0);

                Invalidate(); // Перерисовать
                return true;
            }
            else
            {
                return false;
            }

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Отрисовка всех фигур
            foreach (var figure in figures)
            {
                figure.Draw(e.Graphics);
            }

            // Отрисовка всех точек
            foreach (var point in points)
            {
                point.Draw(e.Graphics);
            }
        }
    }
}
