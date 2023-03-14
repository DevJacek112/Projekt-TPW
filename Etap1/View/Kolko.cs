using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace View
{
    public class Kolko
    {
        public double Promien { get; set; }

        public void Rysuj(Canvas canvas, double x, double y)
        {
            Random r = new Random();

            x = r.Next(1, (int)canvas.ActualWidth);
            y = r.Next(1, (int)canvas.ActualHeight);

            Ellipse circle = new Ellipse();
            circle.Width = 2 * Promien;
            circle.Height = 2 * Promien;
            circle.Fill = new SolidColorBrush(Colors.Red);

            Canvas.SetLeft(circle, x - Promien);
            Canvas.SetTop(circle, y - Promien);

            canvas.Children.Add(circle);
        }
    }
}
