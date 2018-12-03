using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinectProject {
    class Run {

        private int speed;

        public Run() {
            speed = 0;
            Particule particule = new Particule();
            Map map = new Map();
            while (!particule.isCrashed()) {
                particule.move();
                map.scroll(speed);
                if(true) { // touch
                    speed++;
                }
                // affichage
            }
        }
    }
}
