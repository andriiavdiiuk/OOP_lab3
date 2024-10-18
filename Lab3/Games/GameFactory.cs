using Lab2.GameAccounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Games
{
    public static class GameFactory
    {
        public static T GetGame<T>(params object?[]? args) where T : BaseGame
        {
            return (T)Activator.CreateInstance(typeof(T), args)!;
        }
    }
}
