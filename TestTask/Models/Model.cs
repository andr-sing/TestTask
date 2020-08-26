using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;

namespace TestTask.Models
{
    //Радиоприемник
    public class Receiver
    {
        public double[] Coords { get; set; }
        
    }
    //Координаты в системе координат
    public class Coords2D
    {
        public double X { get; set; }
        public double Y;
        public Coords2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
    //Измерение времени прохождения до 3 точек
    public class Ping
    {
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double P3 { get; set; }
        public Ping(double p1, double p2, double p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }
    }
    public static class Model
    {
        //Чтение исходных данных
        public static void ReadInput( out List<Receiver> coords, out List<Ping> ping)
        {
            string path = Params.file;
            coords = new List<Receiver>();
            ping = new List<Ping>();

            
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;

                    //Координаты статичных приемников
                    line = sr.ReadLine();
                    string[] mas = line.Split(',');
                    int i = 0;
                    
                    while (i < mas.Length)
                    {
                        coords.Add(new Receiver { Coords = new double[] { double.Parse(mas[i], CultureInfo.InvariantCulture), double.Parse(mas[i + 1], CultureInfo.InvariantCulture) } });
                        i += 2;
                    }
                    //Время прохождения измерения
                    while ((line = sr.ReadLine()) != null)
                    {
                        mas = line.Split(',');
                        ping.Add(new Ping(double.Parse(mas[0], CultureInfo.InvariantCulture), double.Parse(mas[1], CultureInfo.InvariantCulture), double.Parse(mas[2], CultureInfo.InvariantCulture)));
                    }
                }
            
        }
        //Запись выходных данных в файл
        public static void WriteOutput(List<Coords2D> coords)
        {
            string path = $@"output_{DateTime.Now:dd_MM_yy_hh_mm}.txt";

            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                foreach (var item in coords)
                    sw.WriteLine($"{item.X.ToString("F" + 8, CultureInfo.InvariantCulture)},{item.Y.ToString("F" + 8, CultureInfo.InvariantCulture)}");                
            }
        }

        //Получение координат из исходных данных
        public static List<Coords2D> GetCoords(List<Receiver> receivers, List<Ping> ping, double prec)
        {
            List<Coords2D> coords = new List<Coords2D>();
            foreach (var item in ping)
            {
                Coords2D coord = Func.GetIntersect(receivers[0].Coords[0], receivers[0].Coords[1], item.P1 * Params.speed,
                                                receivers[1].Coords[0], receivers[1].Coords[1], item.P2 * Params.speed,
                                                receivers[2].Coords[0], receivers[2].Coords[1], item.P3 * Params.speed,
                                                prec);
                if (coord != null)
                    coords.Add(coord);
            }
            return coords;
        }

        //Получение выходных данных из координат и запись в файл
        public static void SaveCoords(List<Point> coords, List<Receiver> recs, MainForm form, out string path)
        {

            path = $@"input_{DateTime.Now:dd_MM_yy_hh_mm}.txt";

            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                foreach (var receiver in recs)
                    sw.Write($"{((receiver != recs[0]) ? ",":"")}{receiver.Coords[0].ToString("F" + 8, CultureInfo.InvariantCulture)},{receiver.Coords[1].ToString("F" + 8, CultureInfo.InvariantCulture)}");
                sw.WriteLine("");
                foreach (var item in coords)
                {
                    double[] ping = GetPing(item, recs, Params.DefPoint);
                    sw.WriteLine($"{ping[0].ToString("F" + 8, CultureInfo.InvariantCulture)},{ping[1].ToString("F" + 8, CultureInfo.InvariantCulture)},{ping[2].ToString("F" + 8, CultureInfo.InvariantCulture)}");
                }
            }
        }
        //Расчет времени прохождения сигнала
        public static double[] GetPing (Point coords, List<Receiver> recs, Point defCoords)
        {
            double[] mas = new double[3] ;
            for (int i=0; i<3; i++)
            {
                var x1 = (-defCoords.X + coords.X) / (Params.scale);
                var x2 = recs[i].Coords[0];
                var y1 = (defCoords.Y - coords.Y) / (Params.scale);
                var y2 = recs[i].Coords[1];
                mas[i]= Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2))/ Params.speed;
            }

            return mas;
        }
    }
}
