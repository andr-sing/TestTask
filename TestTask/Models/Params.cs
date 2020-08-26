using System.Drawing;

namespace TestTask.Models
{
    static class Params
    {
        public static Point DefPoint { get; set; }
        public const int scale = 10; //TODO: сделать масштаб автоматическим
        public const int speed = 1000000; //Скорость (м/с)
        public static string file;
    }
}
