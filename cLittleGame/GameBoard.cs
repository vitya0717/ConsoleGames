using System;

namespace cLittleGame
{
    class GameBoard
    {
        private int y;
        private int x;

        public int getScreenY()
        {
            return y;
        }
        public int getScreenX()
        {
            return x;
        }

        public int[] getStartPosition()
        {
            return new int[2] {y, x};
        }

        public GameBoard()
        {
        }

        public GameBoard(int y, int x)
        {
            this.y = y;
            this.x = x;
        }

        public void create(int y, int x)
        {
            Console.SetWindowSize(y, x);
        }

        internal void startPosition(int y, int x)
        {
            Console.SetCursorPosition(y, x);
        }


    }
}