using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using Model;

namespace Logika
{
    public class Controller
    {

        public static void spawnCircles(int value, Canvas canvas)
        {
            for(int i = 0; i < value; i++)
            {
                spawnCircle(canvas, 5, 5);
            }
        }

        public static void spawnCircle(Canvas canvas, int size,  int radius)
        {

            Random r = new Random(Guid.NewGuid().GetHashCode());

            int x = r.Next(1, (int)canvas.ActualWidth);
            int y = r.Next(1, (int)canvas.ActualHeight);

            Circle circleObject = new Circle(x, y, size);

            Ellipse circle = new Ellipse();
            circle.Width = 2 * radius;
            circle.Height = 2 * radius;
            circle.Fill = new SolidColorBrush(Colors.Red);

            Canvas.SetLeft(circle, x - radius);
            Canvas.SetTop(circle, y - radius);

            canvas.Children.Add(circle);
        }

    }
}
