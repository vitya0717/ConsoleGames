using System;

namespace cLittleGame
{
    internal class PlayerObject
    {
        private string v1;
        private int v2;
        private Vector2 vector2;
        private int speed;


        public PlayerObject(string v1, int v2, Vector2 vector2, int speed)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.vector2 = vector2;
            this.speed = speed;
        }

        public int posY()
        {
            return vector2.y;
        }
        public int posX()
        {
            return vector2.x;
        }

        public string getName()
        {
            return v1;
        }

        public int getHealth()
        {
            return v2;
        }

        public void setHealth(int health)
        {
            this.v2 = health;
        }

        public int getSpeed()
        {
            return speed;
        }

        public Vector2 getVector2()
        {
            return vector2;
        }
    }
}