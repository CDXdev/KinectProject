using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinectProject {
    class Map {
        private List<Obstacle> obstacles;
        public Map() {
            obstacles = new List<Obstacle>();
        }

        public List<Obstacle> getObstacles() {
            return obstacles;
        }

        public void addObstacle() {
            obstacles.Add(new Obstacle());
        }

        public void scroll(int speed) {
            foreach (Obstacle obs in obstacles) {
                obs.scroll(speed);
            }
        }

        public void removeFirstIfOut() {
            if (obstacles.Count()>0 && obstacles[0].getY() > 100) {
                obstacles.RemoveAt(0);
            }
        }
    }
}
