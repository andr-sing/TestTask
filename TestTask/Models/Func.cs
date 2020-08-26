using System;

namespace TestTask.Models
{
    static class Func
    {
        //Определение точки пересечения 3 окружностей
        public static Coords2D GetIntersect(double x0, double y0, double r0,
                                                 double x1, double y1, double r1,
                                                 double x2, double y2, double r2,
                                                 double prec)
        {
            double a, dx, dy, d, h, rx, ry;
            double point2_x, point2_y;
            
            dx = x1 - x0;
            dy = y1 - y0;

            //Определение расстояния между 2 окружностями
            d = Math.Sqrt((dy * dy) + (dx * dx));

            //Проверка на пересечение окружностей
            if (d > (r0 + r1) * (1d + prec))
            {
                return null;
            }
            if (d * (1d + prec) < Math.Abs(r0 - r1))
            {                
                return null;
            }

            //Определение координат точки пересечения линии между центрами окружностей и точками пересечения
            a = ((r0 * r0) - (r1 * r1) + (d * d)) / (2.0 * d);
            point2_x = x0 + (dx * a / d);
            point2_y = y0 + (dy * a / d);

            //Определение расстояния между точкой и точками пересечения окружностей
            h = double.IsNaN(Math.Sqrt((r0 * r0) - (a * a))) ? 0 : (Math.Sqrt((r0 * r0) - (a * a)));
            
            rx = -dy * (h / d);
            ry = dx * (h / d);

            //Определение координат пересечения
            double intersectionPoint1_x = point2_x + rx;
            double intersectionPoint2_x = point2_x - rx;
            double intersectionPoint1_y = point2_y + ry;
            double intersectionPoint2_y = point2_y - ry;

            //Определение точки пересечения с третьей окружностью
            dx = intersectionPoint1_x - x2;
            dy = intersectionPoint1_y - y2;
            double d1 = Math.Sqrt((dy * dy) + (dx * dx));

            dx = intersectionPoint2_x - x2;
            dy = intersectionPoint2_y - y2;
            double d2 = Math.Sqrt((dy * dy) + (dx * dx));

            //TODO: уточнить координату взяв среднее расстояние

            if (Math.Abs(d1 - r2) < Math.Abs(d2 - r2))
            {
                return new Coords2D(intersectionPoint1_x, intersectionPoint1_y);
            }
            else
            {
                return new Coords2D(intersectionPoint2_x, intersectionPoint2_y);
            }
        }
    }
}
