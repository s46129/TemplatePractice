﻿using TemplatePractice.ShowDown;
using TemplatePractice.Uno;

namespace TemplatePractice
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var game = new ShowDownGame();
            game.Start();
        }
    }
}