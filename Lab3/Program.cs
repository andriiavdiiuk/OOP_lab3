using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.DAL;
using Lab3.BLL.Services;
using Lab3.BLL.GameAccounts;
using Lab3.BLL.Games;

namespace Lab3
{
    public class Program
    {
        static void Main(string[] args)
        {
            DbContext dbContext = new DbContext();
            IGameService GameService = new GameService(dbContext);
            IGameAccountService AccountService = new GameAccountService(dbContext);

            for (int i = 0; i < 3; i++)
            {
                AccountService.Create(GameAccountFactory.GetAccount(Enum.GetValues<AccountType>()[i % 3], AccountService, $"Player {i + 1}"));
            }
            Console.WriteLine(GetAllPlayersStats(AccountService));

            GameManager.PlayGame(AccountService.GetAll().ToList(), 10, GameService);

            Console.WriteLine(GetAllPlayersStats(AccountService));

            foreach (var player in AccountService.GetAll())
            {
                Console.WriteLine(player.GetStats());
            }

            Console.WriteLine(GetStats(GameService));
        }

        public static string GetStats(IGameService service)
        {
            string result = "All Games:\n";
            result += "-----------------------------------------------------------------------------------------------------------------------\n";
            result += $"|{"Winner",-12} | {"Loser",-12} | {"Rating",-6} | {"Winner Rating Change",-20} | {"Loser Rating Change",-20} | {"Id",-4} | {"Game Type",-24} |\n";
            result += "-----------------------------------------------------------------------------------------------------------------------\n";
            string winnerRating = "";
            string loserRating = "";
            foreach (GameResult game in service.GetAll())
            {
                winnerRating = $"{game.WinnerRating,-3} ({game.WinnerRatingChange})";
                loserRating = $"{game.LoserRating,-3} ({game.LoserRatingChange})";
                result += $"|{game.Winner.Username,-12} | {game.Loser.Username,-12} | {game.Rating,-6} | {winnerRating,-20} | {loserRating,-20} | {game.Id,-4} | {game.Type,-24} |\n";
            };
            result += "-----------------------------------------------------------------------------------------------------------------------\n";

            return result;
        }

        public static string GetAllPlayersStats(IGameAccountService service)
        {
            string result = "All Players:\n";
            result += "----------------------------------------------------------------------------------\n";
            result += $"| {"Id",-4} | {"Username",-15} | {"Current Rating",-15} | {"Games Count",-12} | {"Account Type",-20} |\n";
            result += "----------------------------------------------------------------------------------\n";
            foreach (BaseGameAccount account in service.GetAll())
            {
                result += $"| {account.Id,-4} | {account.Username,-15} | {account.CurrentRating,-15} | {account.GamesCount,-12} | {account.GetAccountType().ToString(),-20} |\n";
            }

            result += "----------------------------------------------------------------------------------\n";
            return result;
        }

    }
}
