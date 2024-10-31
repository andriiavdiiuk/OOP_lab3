using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.DAL.Models;

namespace Lab3.DAL.Repositories
{
    public interface IGameRepository
    {
        int Create(GameModel game);
        IEnumerable<GameModel> GetAll();
        GameModel Read(int id);
        void Update(GameModel game);
        void Delete(int id);
    }
}
