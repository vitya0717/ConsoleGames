using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cLittleGame
{
    internal class Program
    {

        private static PlayerObject player;
        private static GameBoard gameBoard;
        private static Utils utils;

        static void Main(string[] args)
        {
            setupGame();

        }

        private static void setupGame()
        {
            utils = new Utils();
            gameBoard = new GameBoard(100,50);

            //gameBoard.create(width,height);
            gameBoard.create(gameBoard.getScreenY(),gameBoard.getScreenX());
            //kezdő pozíció
            gameBoard.startPosition(gameBoard.getScreenY()/2, gameBoard.getScreenX()/2);

            player = new PlayerObject("username", 20, new Vector2(gameBoard.getStartPosition()[0] / 2, gameBoard.getStartPosition()[1] / 2), 1);

            updateGame();
        }

        private static void updateGame()
        {
            while(true)
            {
                if(Console.ReadKey().Key== ConsoleKey.UpArrow) {
                    player.getVector2().y -= player.getSpeed();
                    Console.Clear();
                    Console.SetCursorPosition(player.getVector2().x,player.getVector2().y);
                } 
                if(Console.ReadKey().Key == ConsoleKey.DownArrow)
                {
                    player.getVector2().y += player.getSpeed();
                    Console.Clear();
                    Console.SetCursorPosition(player.getVector2().x, player.getVector2().y);
                }
                if (Console.ReadKey().Key == ConsoleKey.RightArrow)
                {
                    player.getVector2().x += player.getSpeed();
                    Console.Clear();
                    Console.SetCursorPosition(player.getVector2().x, player.getVector2().y);
                }
                if (Console.ReadKey().Key == ConsoleKey.LeftArrow)
                {
                    player.getVector2().x -= player.getSpeed();
                    Console.Clear();
                    Console.SetCursorPosition(player.getVector2().x, player.getVector2().y);
                }
            }
        }
    }
}
