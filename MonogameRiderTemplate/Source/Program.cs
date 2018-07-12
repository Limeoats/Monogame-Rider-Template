using System;
using Microsoft.Xna.Framework;

namespace TheVillageOfLife
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}