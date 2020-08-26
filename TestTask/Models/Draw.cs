using System;
using System.Collections.Generic;
using System.Drawing;

namespace TestTask.Models
{
    static class Draw
    {
        //Отрисовка приемников
        public static void DrawReceivers(List<Receiver> recs, MainForm form)
        {
            const int size = 10;
            int i = 0;
            foreach (var receiver in recs)
            {
                Point center = ToPoint(new Coords2D(receiver.Coords[0], receiver.Coords[1]));
                    //new Point((Convert.ToInt32(Params.DefPoint.X - receiver.Coords[0] * Params.scale)), Convert.ToInt32(Params.DefPoint.Y - receiver.Coords[1] * Params.scale));
                Graphics graph = Graphics.FromHwnd(form.pictureBox1.Handle);
                Rectangle rct = new Rectangle(center.X - size / 2, center.Y - size / 2, size, size);
                Brush brush = new SolidBrush(Color.Black);
                graph.FillEllipse(brush, rct);
                i++;
            }
        }

        //Отрисовка сегмента траектории
        public static void DrawSegment(Point start, Point end, MainForm form)
        {
            Graphics graph = Graphics.FromHwnd(form.pictureBox1.Handle);
            Pen pen = new Pen(Color.Black);
            graph.DrawLine(pen, start, end);
        }

        //Отрисовка траектории
        public static void DrawPath(List<Coords2D> coords, MainForm form)
        {
            Point prevPoint = ToPoint(coords[0]);
            form.history = new List<Point>() { };
            
            foreach (var item in coords)
            {
                Point nextPoint = ToPoint(item);
                Graphics graph = Graphics.FromHwnd(form.pictureBox1.Handle);
                Pen pen = new Pen(Color.Black);
                graph.DrawLine(pen, prevPoint, nextPoint);
                form.history.Add(nextPoint);
                prevPoint = nextPoint;                
            }
        }

        //Пересчет координат в точки
        public static Point ToPoint(Coords2D coords)
        { 
            Point point = new Point((Convert.ToInt32(Params.DefPoint.X + coords.X * Params.scale)), Convert.ToInt32(Params.DefPoint.Y - coords.Y * Params.scale));

            return point;
        }
    }
}
