using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinectProject {
    class Particule {

        private double x;

        public static int SIZE_X = 1;
        public static int SIZE_Y = 1;
        public static int Y = 5;
        public static int FREQUENCY = 100;

        public Particule() {
            x = 0;
        }

        public int getX() {
            return Math.Abs((int) x);
        }

        public void move() {
            x = 100*Math.Sin(Math.PI*((Math.Asin(x/100)*FREQUENCY/(Math.PI))+1)/FREQUENCY);
            if (x==100) {
                x = -100;
            }
        }

        public bool isCrashed() {
            return false;
        }
    }
}
