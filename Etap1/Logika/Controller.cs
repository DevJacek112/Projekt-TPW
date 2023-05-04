using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using Dane;


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

            int x = r.Next(0, (int)canvas.ActualWidth);
            int y = r.Next(0, (int)canvas.ActualHeight);

            Circle circleObject = new Circle(x, y, size, radius);

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

            Thread thread = new Thread(() =>
            {
                while (true) {
                    var dispatcher = Application.Current.Dispatcher;
                    dispatcher.Invoke(() =>
                    {
                        double left = Canvas.GetLeft(circle);
                        double top = Canvas.GetTop(circle);

                        if (left + circle.Width >= canvas.ActualWidth) {
                            circleObject.DirectionX = -1;
                        }
                        else if (left <= 0) {
                            circleObject.DirectionX = 1;
                        }

                        if (top + circle.Height >= canvas.ActualHeight) {
                            circleObject.DirectionY = -1;
                        }
                        else if (top <= 0) {
                            circleObject.DirectionY = 1;
                        }

                        circleObject.X += circleObject.DirectionX;
                        circleObject.Y += circleObject.DirectionY;

                        Canvas.SetLeft(circle, circleObject.X - circleObject.Radius);
                        Canvas.SetTop(circle, circleObject.Y - circleObject.Radius);
                    });
                    Thread.Sleep(20);
                }
            });
            thread.Start();

        }
    }
}
