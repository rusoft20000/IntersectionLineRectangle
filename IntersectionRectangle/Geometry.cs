using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry2D
{
   // interface IInterfaceList
   // {
   // }
   // interface IContourPoint
   // {
   //     double GetX { get; }
   //     double GetY { get; }


   // }
   // interface IContourBit
   // {
   //     int GetPointCount { get; }// количество точек в фрагменте
   //     bool IsClosed { get; } //флажок замкнутости контура. Тру – последняя точка соединена с первой.
   //     IContourPoint GetPoint(int idx); // Null если (idx < 0) or (idx >= GetPointCount) 

   // }
   // interface IContourEdit { }
   //public interface IContour
   // {
   //     int GetContourBitCount { get; } // количество фрагментов
   //     IContourBit GetContourBit(int idx);


   // }
   // public interface IContours
   // {
   //     int GetContourCount();
   //     IContour GetContour(int idx);


   // }
   // interface IContourBitEdit
   // {

   //     void AddPoint(double x, double y, double value); //Value всегда должно быть = 0
   //     void SetClosed(bool closed);
   // }
    public static class IntersectionLineRectangle
      
    {

       // public static Tuple<PointF, PointF> CutContoursByWindow(IContours Cntrs);
       //{
       //     IContours x = Cntrs;
       // x;
       //{
    
         
        /// <summary>
        /// http://en.wikipedia.org/wiki/Cohen%E2%80%93Sutherland_algorithm
        /// </summary
        [Flags]

        enum OutCode
        {
            Inside = 0,
            Left = 1,
            Right = 2,
            Bottom = 4,
            Top = 8
        }
     //   private static RectangleF TRect_Float(double x1, double x2, double xx31, double hx1);
     

        private static OutCode ComputeOutCode(float x, float y, RectangleF r)
        {
            var code = OutCode.Inside;

            if (x < r.Left) code |= OutCode.Left;
            if (x > r.Right) code |= OutCode.Right;
            if (y < r.Top) code |= OutCode.Top;
            if (y > r.Bottom) code |= OutCode.Bottom;

            return code;
        }
        private static OutCode ComputeOutCode(PointF p, RectangleF r) { return ComputeOutCode(p.X, p.Y, r); }

        public static Tuple<PointF, PointF> ClipSegment(RectangleF r, PointF p1, PointF p2)
        {
            // classify the endpoints of the line
            // классифицируем конечные точки линии
            var outCodeP1 = ComputeOutCode(p1, r);
            var outCodeP2 = ComputeOutCode(p2, r);
            var accept = false;

            while (true)
            { // should only iterate twice, at most
              // Case 1:
              // both endpoints are within the clipping region

                // только две итерации
                // Случай 1:
                // обе конечные точки находятся внутри границ области прямоугольника
                if ((outCodeP1 | outCodeP2) == OutCode.Inside)
                {
                    accept = true;
                    break;
                }

                // Case 2:
                // both endpoints share an excluded region, impossible for a line between them to be within the clipping region
                // Случай 2:
                // обе конечные точки разделяют исключенную область, обрезку не производим

                if ((outCodeP1 & outCodeP2) != 0)
                {
                    break;
                }

                // Case 3:
                // The endpoints are in different regions, and the segment is partially within the clipping rectangle
                // Select one of the endpoints outside the clipping rectangle
                // Конечные точки находятся в разных регионах(под углом к стороне прямоугольника, а сегмент частично находится в отсекающем прямоугольнике)
                //Выбераем одну из конечных точек вне отсекающего прямоугольника.
                var outCode = outCodeP1 != OutCode.Inside ? outCodeP1 : outCodeP2;

                // calculate the intersection of the line with the clipping rectangle using parametric line equations
                // вычисляем пересечение линии с отсекающим прямоугольником с помощью параметрических линейных уравнений

                var p = CalculateIntersection(r, p1, p2, outCode);

                // update the point after clipping and recaluculate outcode
                // обновляем точку после обрезки и пересчитываем outcode
                if (outCode == outCodeP1)
                {
                    p1 = p;
                    outCodeP1 = ComputeOutCode(p1, r);
                }
                else
                {
                    p2 = p;
                    outCodeP2 = ComputeOutCode(p2, r);
                }
            }
            // if clipping area contained a portion of the line
            // если область отсечения содержит часть линии
            if (accept)
            {
                return new Tuple<PointF, PointF>(p1, p2);
            }

            // the line did not intersect the clipping area
            // линия не пересекала область отсечения
            return null;
        }

        private static PointF CalculateIntersection(RectangleF r, PointF p1, PointF p2, OutCode clipTo)
        {
            var dx = (p2.X - p1.X);
            var dy = (p2.Y - p1.Y);

            var slopeY = dx / dy; // наклон для вертикальных линий// slope to use for possibly-vertical lines
            var slopeX = dy / dx; // наклон для горизонтальных линий// slope to use for possibly-horizontal lines

            if (clipTo.HasFlag(OutCode.Top))
            {
                return new PointF(
                    p1.X + slopeY * (r.Top - p1.Y),
                    r.Top
                    );
            }
            if (clipTo.HasFlag(OutCode.Bottom))
            {
                return new PointF(
                    p1.X + slopeY * (r.Bottom - p1.Y),
                    r.Bottom
                    );
            }
            if (clipTo.HasFlag(OutCode.Right))
            {
                return new PointF(
                    r.Right,
                    p1.Y + slopeX * (r.Right - p1.X)
                    );
            }
            if (clipTo.HasFlag(OutCode.Left))
            {
                return new PointF(
                    r.Left,
                    p1.Y + slopeX * (r.Left - p1.X)
                    );
            }
            throw new ArgumentOutOfRangeException("clipTo = " + clipTo);
        }

      
            
      


    }
}