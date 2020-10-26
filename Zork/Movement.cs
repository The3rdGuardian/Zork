﻿using System;

namespace Zork
{
    public static class MovementCommands
    {
        public static void North(Game game, CommandContext commandContext) => Move(game, Directions.NORTH);
        public static void South(Game game, CommandContext commandContext) => Move(game, Directions.SOUTH);
        public static void East(Game game, CommandContext commandContext) => Move(game, Directions.EAST);
        public static void West(Game game, CommandContext commandContext) => Move(game, Directions.WEST);

        private static void Move(Game game, Directions direction)
        {
            bool playerMoved = game.Player.Move(direction);
            if(playerMoved == false)
            {
                Console.WriteLine("The way is shut!");
            }    
        }

    }
}