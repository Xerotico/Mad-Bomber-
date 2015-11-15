﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad_Bomber_
{
    class GameObj
    {
        //public enum Direction { NONE, UP, RIGHT, DOWN, LEFT }

        public int texture;
        protected Point size;

        public GameObj()
        {
            size = new Point(0,0);
        }
        public GameObj(string pathToTexture)
        {
            if(pathToTexture.Length == 0)
            {
                texture = 0;
                this.size = new Point(0, 0);
            }
            else
            {
                this.texture = Texture.getTexture(pathToTexture);
                this.size = Texture.getSizeOfTexture(pathToTexture);
            }
        }
        public GameObj(GameObj obj)
        {
            this.size = obj.size;
            this.texture = obj.texture;
        }

        public int getWidth()
        {
            return size.X;
        }
        public int getHeight()
        {
            return size.Y;
        }
    }
}
