using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    interface IRobot
    {
        void TurnRight();
        void TurnLeft();
        void Move();
        void Place(int x, int y);
        string Report();
        void SetPosition(string position);
    }
}
