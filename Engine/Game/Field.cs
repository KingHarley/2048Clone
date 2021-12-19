using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Clone
{
    public class Field
    {
        public Field Up;
        public Field Down;
        public Field Left;
        public Field Right;

        public int Value = 0;

        public Field(int val)
        {
            Value = val;
            Up = null;
            Down = null;
            Left = null;
            Right = null;

        }

        private Field GetNextField(string direction)
        {
            Field next = null;
            switch (direction)
            {
                case "up":
                    next = this.Up;
                    break;
                case "down":
                    next = this.Down;
                    break;
                case "left":
                    next = this.Left;
                    break;
                case "right":
                    next = this.Right;
                    break;
                default:
                    throw new System.Exception("Invalid input");
            }
            return next;
        }

        public void Move(string direction)
        {
            Field next = GetNextField(direction);

            if (next != null)
                next.Move(direction);
            else
                return;

            if (next.Value == this.Value)
            {
                next.Value *= 2;
                this.Value = 0;
            }
            else if (next.Value == 0)
            {
                next.Value = this.Value;
                this.Value = 0;
                next.Move(direction);
            }
            return;
        }
    }
}
