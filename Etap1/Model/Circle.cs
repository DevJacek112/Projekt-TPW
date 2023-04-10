using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Circle : INotifyPropertyChanged
    {
        float x;
        float y;
        float size;

        public Circle(float x, float y, float size)
        {
            this.x = x;
            this.y = y;
            this.size = size;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        static void Main(string[] args)
        {

        }


    }
}
