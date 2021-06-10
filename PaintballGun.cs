

using System;

namespace Paintball
{
    class PaintballGun
    {
        public const int Magazine_Size = 16;

        private int balls = 0;
        private int ballsloaded = 0;

        public int GetBallsLoaded() { return ballsloaded; }
        public bool isEmpty() { return ballsloaded == 0; }

        public int Balls
        {
            get { return balls; }

            set
            {
                if (value > 0)
                    balls = value;
                Reload();
            }
        }
        public void Reload()
        {
            if (balls > Magazine_Size)
                ballsloaded = Magazine_Size;
            else
                ballsloaded = balls;
        }

        public bool Shoot()
        {
            if( ballsloaded == 0) { return false; }
            ballsloaded--;
            balls--;
            return true;
        }
    }
}
