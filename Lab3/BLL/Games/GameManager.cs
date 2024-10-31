using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.BLL.GameAccounts;
using Lab3.BLL.Services;
namespace Lab3.BLL.Games
{
    public static class GameManager
    {
        private static Random random = new Random();
        
        public static void PlayGame(List<BaseGameAccount> players, int count, IGameService service)
        {
            for (int i = 0; i < players.Count(); i++)
            {
                for (int j = i + 1; j < players.Count(); j++)
                {
                    for (int k = 0; k < count; k++)
                    {
                        PlayRandomGame(players[i], players[j], service);
                    }
                }
            }
        }

        public static void PlayRandomGame(BaseGameAccount player1, BaseGameAccount player2, IGameService service)
        {
            int rand = random.Next(3);
            BaseGame game;
            switch (rand)
            {
                default:
                case 0:
                    game = GameFactory.GetGame(GameType.Standard,service);
                    break;
                case 1:
                    game = GameFactory.GetGame(GameType.Training, service);
                    break;
                case 2:
                    BaseGameAccount playerWithRating;
                    if (random.Next(2) == 0) playerWithRating = player1;
                    else playerWithRating = player2;
                    game = GameFactory.GetGame(GameType.SinglePlayerRating, service, playerWithRating);
                    break;
            }
            game.Play(player1, player2);
        }
    }
}
