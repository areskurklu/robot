using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Robot : IRobot
    {
        private Coordinates coordinates;
        public Robot(Coordinates c)
        {
            coordinates = c;
        }

        public void Move()
        {
            coordinates.Move(1);
        }

        public void Place(int x, int y)
        {
            coordinates.SetX(x);
            coordinates.SetY(y);
        }

        public string Report()
        {
            return $"{coordinates.GetX()} {coordinates.GetY()} {coordinates.GetDirection()}";
        }

        public void SetPosition(string position)
        {
            if (position.ToUpper() == "NORTH")
            {
                coordinates.SetDirection(Coordinates.Direction.North);
            }
            else if (position.ToUpper() == "EAST")
            {
                coordinates.SetDirection(Coordinates.Direction.East);
            }
            else if (position.ToUpper() == "WEST")
            {
                coordinates.SetDirection(Coordinates.Direction.West);
            }
            else if (position.ToUpper() == "SOUTH")
            {
                coordinates.SetDirection(Coordinates.Direction.South);
            }
            else
            {
                throw new Exception("Invalid position");
            }
        }

        public void TurnLeft()
        {
            coordinates.Rotate(Coordinates.Rotation.Left);
        }

        public void TurnRight()
        {
            coordinates.Rotate(Coordinates.Rotation.Right);
        }
    }
}
