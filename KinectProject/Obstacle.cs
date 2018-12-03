using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinectProject {
    class Obstacle {

        private int x, y, size;

        public static int SIZE_X = 10;
        public static int SIZE_Y = 2;
        public static int Y_START = -10;

        public Obstacle() {
            size = SIZE_X ;
            y = Y_START;
            Random random = new Random();
            x = random.Next(101-SIZE_X); // x is a random int between 0 and 90 % if size = 10 %
        }

        public void scroll(int speed) {
            y -= speed;
        }

        public int getY() {
            return y;
        }
    }
}
