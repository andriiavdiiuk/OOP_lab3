using Lab3.BLL.GameAccounts;
using Lab3.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.BLL.Games
{
    public class StandardGame : BaseGame
    {
        private Random rand = new Random();

        public StandardGame(IGameService service) : base(service)
        {
        }

        public override int GetGameRating()
        {
            if (Rating < 0)
            {
                Rating = rand.Next(10, 100);
            }
            return Rating;
        }

        public override int GetRatingForPlayer(BaseGameAccount player)
        {
            return GetGameRating();
        }
    }
}
