using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            for (int i = 0; i < value; i++) 
            {
                spawnCircle(canvas, 5, 5);
            }
        }

        public static void spawnCircle(Canvas canvas, int size, int radius) 
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
            Random random = new Random();
            int directionX = random.Next(-2, 2); 
            int directionY = random.Next(-2, 2); 
            while(directionX== 0 && directionY == 0) {
                directionX = random.Next(-2, 2);
                directionY = random.Next(-2, 2);
            }

            Thread thread = new Thread(() => {
                while (true) {
                    var dispatcher = Application.Current.Dispatcher;
                    dispatcher.Invoke(() =>
                    {
                        double left = Canvas.GetLeft(circle);
                        double top = Canvas.GetTop(circle);

                        if (left + circle.Width >= canvas.ActualWidth) {
                            directionX = -1;
                        }
                        else if (left <= 0)
                        {
                            directionX = 1;
                        }

                        if (top + circle.Height >= canvas.ActualHeight) {
                            directionY = -1;
                        }
                        else if (top <= 0)
                        {
                            directionY = 1;
                        }

                        Canvas.SetLeft(circle, left + directionX);
                        Canvas.SetTop(circle, top + directionY);
                    });
                    Thread.Sleep(20);
                }
            });
            thread.Start();

        }
    }
}
