using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dane
{
   public class Circle : INotifyPropertyChanged {
        public int X { get; set; }
        public int Y { get; set; }
        public int Size { get; set; }
        public int Radius { get; set; }
        public int DirectionX { get; set; }
        public int DirectionY { get; set; }

        public Circle(int x, int y, int size, int radius) {
            X = x;
            Y = y;
            Size = size;
            Radius = radius;

            Random random = new Random();
            DirectionX = random.Next(-2, 2);
            DirectionY = random.Next(-2, 2);
            while (DirectionX == 0 && DirectionY == 0) {
                DirectionX = random.Next(-2, 2);
                DirectionY = random.Next(-2, 2);
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        static void Main(string[] args) {

        }
    }


}
