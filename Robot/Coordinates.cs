using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Coordinates
    {
        public enum Direction { North = 1, East = 2, South = 3, West = 4 };
        public enum Rotation { Right, Left };
        private int limitY = 0;
        private int limitX = 0;
        private int x = 0;
        private int y = 0;
        private Direction z;

        public Coordinates()
        {
        }

        public void SetLimits(int limitX, int limitY)
        {
            this.limitX = limitX;
            this.limitY = limitY;
        }

        public void SetDirection(Direction dir)
        {
            z = dir;
        }

        public void Rotate(Rotation rotation, int num = 1)
        {
            if (rotation == Rotation.Right)
            {
                z++;             
            }
            else if (rotation == Rotation.Left)
            {
                z--;
                z = z == 0 ? z = Direction.West: z;
    
            }
            if ((int)z != Enum.GetValues(typeof(Direction)).Cast<int>().Max())
                z = (Direction)((int)z % Enum.GetValues(typeof(Direction)).Cast<int>().Max());

        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public void SetX(int x)
        {
            if (x < 0 || x > limitX)
            {
                this.x = 0;
            }
            else
            {
                this.x = x;
            }
        }

        public void SetY(int y)
        {
            if (y < 0 || y > limitY)
            {
                this.y = 0;
            }
            else
            {
                this.y = y;
            }
        }

        public Direction GetDirection()
        {
            return z;
        }

        public void Move(int n)
        {
            if (this.z == Direction.North)
            {
                //increases y
               y = (y+ n) > limitY ? limitY: (y + n);
            }
            else if (this.z == Direction.South)
            {
                //decreases y
                y = (y - n) > 0 ? (y - n) : 0;
            }
            else if (this.z == Direction.West)
            {
                //decreases x
                x = (x - n) > 0 ? (x - n) : 0;
            }
            else if (this.z == Direction.East)
            {
                //increases x
                x = (x + n) > limitX ? limitX : (x + n);
            }

        }

    }
}
