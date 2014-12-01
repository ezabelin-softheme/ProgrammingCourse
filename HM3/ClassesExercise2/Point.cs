using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise2
{
    class Point
    {
        private int x;
        private int y;
        private string name;

        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public int coordinateX
        {
            get { return x; }
        }

        public int coordinateY
        {
            get { return y; }
        }

        public string PointName
        {
            get { return name; }
        }


    }
}
